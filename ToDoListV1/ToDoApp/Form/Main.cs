using System.Windows.Forms;
namespace TodoApp
{
    public partial class Main : Form
    {
        void Update_Combo_filter()
        {
            Status_CB.Items.Add(DatabaseQuery.Process[0]);
            Status_CB.Items.Add(DatabaseQuery.Process[1]);
            Status_CB.Items.Add(DatabaseQuery.Process[2]);
            Status_CB.Items.Add(DatabaseQuery.Process[3]);
            Status_CB.Items.Add(DatabaseQuery.Process[4]);
            Priority_CB.Items.Add(DatabaseQuery.Day[0]);
            Priority_CB.Items.Add(DatabaseQuery.Day[1]);
            Priority_CB.Items.Add(DatabaseQuery.Day[2]);
            Priority_CB.Items.Add(DatabaseQuery.Day[3]);
            Priority_CB.Items.Add(DatabaseQuery.Day[4]);
            Status_CB.SelectedIndex = 0;
            Priority_CB.SelectedIndex = 0;
        }
        public void Update_Database_Default()
        {
            Data_View.DataSource = null;
            Data_View.ReadOnly = true;
            string cmd = "SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST";
            Data_View.DataSource = DatabaseQuery.Data(cmd);
            Data_View.Columns[0].HeaderText = "Trạng thái";
            Data_View.Columns[0].Width = 75;
            Data_View.Columns[1].HeaderText = "Tiêu đề";
            Data_View.Columns[1].Width = 150;
            Data_View.Columns[2].HeaderText = "Mức độ ưu tiên";
            Data_View.Columns[2].Width = 150;
            Data_View.Columns[3].HeaderText = "Thời gian lên lịch";
            Data_View.Columns[3].Width = 150;
            Data_View.Columns[4].HeaderText = "Thời gian hoàn thành";
            Data_View.Columns[4].Width = 150;
            Data_View.Columns[5].HeaderText = "Ghi chú";
            Data_View.Columns[5].Width = 150;
            Data_View.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public Main()
        {
            InitializeComponent();
            if(DatabaseQuery.Check_Database())
            {
                Status_LB.Text = "Database Status: Kết nối thành công";
                Add_Btn.Enabled = true;
                Edit_Btn.Enabled = true;
                Delete_Btn.Enabled = true;
                Find_Btn.Enabled = true; 
            }
            else
            {
                Status_LB.Text = "Database Status: Lỗi kết nối";
            }
            Update_Database_Default();
            Update_Combo_filter();
            RB_1.Select();
        }

        private void Add_Btn_Click(object sender, System.EventArgs e)
        {
            AddForm Add = new AddForm();
            Add.ShowDialog();
            Update_Database_Default();
        }

        private void Edit_Btn_Click(object sender, System.EventArgs e)
        {
            EditForm Edit = new EditForm();
            Edit.ShowDialog();
            Update_Database_Default();
        }

        private void Delete_Btn_Click(object sender, System.EventArgs e)
        {
            RemoveForm RM = new RemoveForm();
            RM.ShowDialog();
            Update_Database_Default();
        }

        private void Update_DataTable(string Command)
        {
            Data_View.DataSource = null;
            Data_View.ReadOnly = true;
            Data_View.DataSource = DatabaseQuery.Data(Command);
            Data_View.Columns[0].HeaderText = "Trạng thái";
            Data_View.Columns[0].Width = 75;
            Data_View.Columns[1].HeaderText = "Tiêu đề";
            Data_View.Columns[1].Width = 150;
            Data_View.Columns[2].HeaderText = "Mức độ ưu tiên";
            Data_View.Columns[2].Width = 150;
            Data_View.Columns[3].HeaderText = "Thời gian lên lịch";
            Data_View.Columns[3].Width = 150;
            Data_View.Columns[4].HeaderText = "Thời gian hoàn thành";
            Data_View.Columns[4].Width = 150;
            Data_View.Columns[5].HeaderText = "Ghi chú";
            Data_View.Columns[5].Width = 200;
            Data_View.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Find_Btn_Click(object sender, System.EventArgs e)
        {
            if(RB_1.Checked)
            {
                string Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE STATUS = '{DatabaseQuery.Process[Status_CB.SelectedIndex]}'";
                Update_DataTable(Command);
            }
            else if(RB_2.Checked)
            {
                string Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE PRIORITY = '{DatabaseQuery.Day[Priority_CB.SelectedIndex]}'";
                Update_DataTable(Command);
            }
            else
            {
                string Day = Time_End_CB.Value.ToShortDateString();
                string Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE TIME_END = '{Day}'";
                Update_DataTable(Command);
            }
        }

        private void Reset_Btn_Click(object sender, System.EventArgs e)
        {
            Update_Database_Default();
        }
    }
}
