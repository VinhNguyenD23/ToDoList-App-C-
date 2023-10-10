using System;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class AddForm : Form
    {
        void Update_Combo_filter()
        {
            Priority_CB.Items.Add(DatabaseQuery.Day[0]);
            Priority_CB.Items.Add(DatabaseQuery.Day[1]);
            Priority_CB.Items.Add(DatabaseQuery.Day[2]);
            Priority_CB.Items.Add(DatabaseQuery.Day[3]);
            Priority_CB.Items.Add(DatabaseQuery.Day[4]);
            Priority_CB.SelectedIndex = 0;
        }
        public AddForm()
        {
            InitializeComponent();
            Update_Combo_filter();
            Add_Btn.Enabled = true;
            Time_End_CB.Enabled = false;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Title_txt.Text != "")
                {
                    string st = "null";

                    DatabaseQuery.Add_Data(st, Title_txt.Text, Priority_CB.SelectedItem.ToString(), Time_Begin_CB.Value.ToShortDateString(), Time_End_CB.Text, Note_txt.Text);
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng không bỏ trống tiêu đề", "Thông báo");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Priority_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = DatabaseQuery.StartOfWeek(Time_Begin_CB.Value.AddDays(7), DayOfWeek.Sunday);
            int[] increase_day = { 0, 3, dt.Day - Time_Begin_CB.Value.Day, 14, DateTime.DaysInMonth(Time_Begin_CB.Value.Year, Time_Begin_CB.Value.Month) - Time_Begin_CB.Value.Day };
            Time_End_CB.Text = Time_Begin_CB.Value.AddDays(increase_day[Priority_CB.SelectedIndex]).ToString("d");
        }

        private void Time_Begin_CB_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DatabaseQuery.StartOfWeek(Time_Begin_CB.Value.AddDays(7), DayOfWeek.Sunday);
            int[] increase_day = { 0, 3, dt.Day - Time_Begin_CB.Value.Day, 14, DateTime.DaysInMonth(Time_Begin_CB.Value.Year, Time_Begin_CB.Value.Month) - Time_Begin_CB.Value.Day };
            Time_End_CB.Text = Time_Begin_CB.Value.AddDays(increase_day[Priority_CB.SelectedIndex]).ToString("d");
        }
    }
}
