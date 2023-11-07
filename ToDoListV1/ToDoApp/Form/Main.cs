using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
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
            if (DatabaseQuery.Check_Database())
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
            string Command;
            if (Title_Search_txt.Text == "")
            {
                if (RB_1.Checked)
                {
                    Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE STATUS = '{DatabaseQuery.Process[Status_CB.SelectedIndex]}'";
                    Update_DataTable(Command);
                }
                else if (RB_2.Checked)
                {
                    Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE PRIORITY = '{DatabaseQuery.Day[Priority_CB.SelectedIndex]}'";
                    Update_DataTable(Command);
                }
                else
                {
                    string Day = Time_End_CB.Value.ToShortDateString();
                    Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE TIME_END = '{Day}'";
                    Update_DataTable(Command);
                }
                Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE TITLE LIKE '%%'";
                Update_DataTable(Command);
            }
            else
            {
                if (RB_1.Checked)
                {
                    Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE (STATUS = '{DatabaseQuery.Process[Status_CB.SelectedIndex]}') AND (TITLE LIKE '%{Title_Search_txt.Text}%')";
                    Update_DataTable(Command);
                }
                else if (RB_2.Checked)
                {
                    Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE (PRIORITY = '{DatabaseQuery.Day[Priority_CB.SelectedIndex]}') AND (TITLE LIKE '%{Title_Search_txt.Text}%')";
                    Update_DataTable(Command);
                }
                else
                {
                    string Day = Time_End_CB.Value.ToShortDateString();
                    Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE (TIME_END = '{Day}') AND (TITLE LIKE '%{Title_Search_txt.Text}%')";
                    Update_DataTable(Command);
                }
                Command = $"SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST WHERE TITLE LIKE '%{Title_Search_txt.Text}%'";
                Update_DataTable(Command);
            }
        }

        private void Reset_Btn_Click(object sender, System.EventArgs e)
        {
            Update_Database_Default();
        }

        private void Export_excel_Btn_Click(object sender, System.EventArgs e)
        {
            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            string Name_File = @"Data\DATA" + DateTime.Now.ToShortDateString().Replace('/', '-') + ".csv";
            DataTable DT = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection(DatabaseQuery.path_database))
            {
                string Command1 = "SELECT * FROM TODOLIST";
                using (SQLiteCommand cmd = new SQLiteCommand(Command1, con))
                {
                    con.Open();
                    SQLiteDataReader Dr = cmd.ExecuteReader();
                    DT.Load(Dr);
                    con.Close();
                }
            }
            string Data_EX = "Trạng thái;Tiêu đề;Mức độ ưu tiên;Thời gian bắt đầu;Thời gian kết thúc;Ghi chú\n";
            //string Data_EX = "STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE\n";
            foreach (DataRow item in DT.Rows)
            {
                string status = item["STATUS"].ToString();
                string Title = item["TITLE"].ToString();
                string Priority = item["PRIORITY"].ToString();
                string Time_Begin = item["TIME_BEGIN"].ToString().Replace('/','.');
                string Time_End = item["TIME_END"].ToString().Replace('/', '.');
                string Note = item["NOTE"].ToString();
                //Data_EX += status + ';' + Title + ';' + Priority + ';' + Time_Begin + ';' + Time_End + ';' + Note + "\n";
                Data_EX += $"{status};{Title};{Priority};{Time_Begin};{Time_End};{Note}\n";
            }
            using (File.Create(Name_File))
            {
                //null
            }
            try
            {
                File.WriteAllText(Name_File, Data_EX, System.Text.Encoding.UTF8);
                MessageBox.Show("Xuất file .csv thành công", "Thông báo");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                throw;
            }
        }
    }
}
