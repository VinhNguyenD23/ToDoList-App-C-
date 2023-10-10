using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class EditForm : Form
    {
        string ID_TASK = "";
        public void Update_Database_Default()
        {
            Data_View.DataSource = null;
            Data_View.ReadOnly = true;
            string cmd = "SELECT * FROM TODOLIST";
            Data_View.DataSource = DatabaseQuery.Data(cmd);
            Data_View.Columns[0].HeaderText = "ID";
            Data_View.Columns[0].Width = 150;
            Data_View.Columns[1].HeaderText = "Trạng thái";
            Data_View.Columns[1].Width = 75;
            Data_View.Columns[2].HeaderText = "Tiêu đề";
            Data_View.Columns[2].Width = 150;
            Data_View.Columns[3].HeaderText = "Mức độ ưu tiên";
            Data_View.Columns[3].Width = 150;
            Data_View.Columns[4].HeaderText = "Thời gian lên lịch";
            Data_View.Columns[4].Width = 150;
            Data_View.Columns[5].HeaderText = "Thời gian hoàn thành";
            Data_View.Columns[5].Width = 150;
            Data_View.Columns[6].HeaderText = "Ghi chú";
            Data_View.Columns[6].Width = 150;
            Data_View.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void Update_Combo_filter()
        {
            Priority_CB.Items.Add(DatabaseQuery.Day[0]);
            Priority_CB.Items.Add(DatabaseQuery.Day[1]);
            Priority_CB.Items.Add(DatabaseQuery.Day[2]);
            Priority_CB.Items.Add(DatabaseQuery.Day[3]);
            Priority_CB.Items.Add(DatabaseQuery.Day[4]);
        }
        public EditForm()
        {
            InitializeComponent();
            Update_Database_Default();
            Update_Combo_filter();
        }

        


        private void Data_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dt = DatabaseQuery.StartOfWeek(Time_Begin_CB.Value.AddDays(7), DayOfWeek.Sunday);
            int[] increase_day = { 0, 3, dt.Day - Time_Begin_CB.Value.Day, 14, DateTime.DaysInMonth(Time_Begin_CB.Value.Year, Time_Begin_CB.Value.Month) - Time_Begin_CB.Value.Day };
            if (e.RowIndex >= 0)
            {
                Title_txt.Text = Data_View.Rows[e.RowIndex].Cells[2].Value.ToString();
                ID_TASK = Data_View.Rows[e.RowIndex].Cells[0].Value.ToString();
                Time_Begin_CB.Value = DateTime.Parse(Data_View.Rows[e.RowIndex].Cells[4].Value.ToString());
                Note_Txt.Text = Data_View.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            int index = 0;
            for(int i = 0; i < DatabaseQuery.Day.Length; i++)
            {
                if(e.RowIndex >= 0)
                {
                    if (Data_View.Rows[e.RowIndex].Cells[3].Value.ToString() == DatabaseQuery.Day[i])
                    {
                        break;
                    }
                    else
                        index++;
                }
            }
            Priority_CB.SelectedIndex = index;
            Time_End_CB.Text = Time_Begin_CB.Value.AddDays(increase_day[Priority_CB.SelectedIndex]).ToString("d");
            
        }

        private void Cancelled_Btn_Click(object sender, EventArgs e)
        {
            if(ID_TASK == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần thay đổi", "Thông báo");
            }
            else
            {
                using (SQLiteConnection con = new SQLiteConnection(DatabaseQuery.path_database))
                {
                    string Command = $"UPDATE TODOLIST SET STATUS = '{DatabaseQuery.Process[3]}' WHERE ID_TASK = '{ID_TASK}'";
                    using(SQLiteCommand cmd = new SQLiteCommand(Command,con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Hủy task thành công", "Thông báo");
                        Update_Database_Default();
                    }
                }
            }
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            if(Title_txt.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần thay đổi", "Thông báo");
            }
            else
            {
                using (SQLiteConnection con = new SQLiteConnection(DatabaseQuery.path_database))
                {
                    string Command = $"UPDATE TODOLIST SET TITLE = '{Title_txt.Text.ToString()}', PRIORITY = '{Priority_CB.SelectedItem.ToString()}' , TIME_BEGIN = '{Time_Begin_CB.Value.ToShortDateString()}' , TIME_END = '{Time_End_CB.Text}' , NOTE = '{Note_Txt.Text}' WHERE ID_TASK = '{ID_TASK}'";
                    using(SQLiteCommand cmd = new SQLiteCommand(Command, con))
                    {
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                            Update_Database_Default();
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show(er.Message, er.StackTrace);
                        }
                        con.Close();
                    }
                }
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
            if (Priority_CB.SelectedIndex >= 0)
            {
                Time_End_CB.Text = Time_Begin_CB.Value.AddDays(increase_day[Priority_CB.SelectedIndex]).ToString("d");
            }
        }

        private void Complete_Btn_Click(object sender, EventArgs e)
        {
            if(ID_TASK == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần thay đổi", "Thông báo");
            }
            else
            {
                using (SQLiteConnection con = new SQLiteConnection(DatabaseQuery.path_database))
                {
                    string Command = $"UPDATE TODOLIST SET STATUS = '{DatabaseQuery.Process[1]}' WHERE ID_TASK = '{ID_TASK}' ";
                    using (SQLiteCommand cmd = new SQLiteCommand(Command, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                        con.Close();
                        Update_Database_Default();
                    }
                }
            }
        }
    }
}
