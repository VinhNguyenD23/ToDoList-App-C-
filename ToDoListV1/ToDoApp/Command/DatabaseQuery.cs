using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace TodoApp
{
    public class DatabaseQuery
    {
        public static string path_database = @"Data Source=Database\Data.db;Version=3";
        public static string[] Process = { "Chưa hoàn thành", "Hoàn thành", "Đang làm", "Bị hủy", "Quá hạn" };
        public static string[] Day = { "Trong ngày", "Ba ngày", "Trong tuần", "Hai tuần", "Trong tháng" };
        public static bool Check_Database()
        {
            try
            {
                string path = "Database";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                if (!File.Exists(@"Database\Data.db"))
                {
                    SQLiteConnection.CreateFile(@"Database\Data.db");
                    using (SQLiteConnection con = new SQLiteConnection(path_database))
                    {
                        string Command = "CREATE TABLE 'TODOLIST' ( 'ID_TASK' TEXT NOT NULL,'STATUS' TEXT NOT NULL,'TITLE' TEXT NOT NULL,'PRIORITY' TEXT NOT NULL,'TIME_BEGIN' TEXT NOT NULL,'TIME_END' TEXT NOT NULL,'NOTE' TEXT);";
                        using (SQLiteCommand cmd = new SQLiteCommand(Command, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void Add_Data(string status, string title, string priority, string Time_begin, string Time_end, string Note)
        {
            using (SQLiteConnection con = new SQLiteConnection(path_database))
            {
                string Command = $@"INSERT INTO TODOLIST (ID_TASK,STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE) VALUES(@ID,@a, @b, @c, @d, @e, @f);";
                using(SQLiteCommand cmd = new SQLiteCommand(Command, con))
                {
                    con.Open();
                    string ID_TASK = DateTime.Now.ToString("HHmmssddMMyyyy");
                    cmd.Parameters.AddWithValue("@ID", "TASK" + ID_TASK);
                    cmd.Parameters.AddWithValue("@a", status);
                    cmd.Parameters.AddWithValue("@b", title);
                    cmd.Parameters.AddWithValue("@c", priority);
                    cmd.Parameters.AddWithValue("@d", Time_begin);
                    cmd.Parameters.AddWithValue("@e", Time_end);
                    cmd.Parameters.AddWithValue("@f", Note);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        private static int STATUS_TODOLIST(DateTime Time_Begin,DateTime Time_End)
        {
            if (Time_Begin.ToShortDateString() == Time_End.ToShortDateString() && Time_End.ToShortDateString() == DateTime.Now.ToShortDateString()) return 2;
            if(Time_Begin <= DateTime.Now)
            {
                if (DateTime.Now <= Time_End)
                    return 2;
                else
                    return 4;
            }
            return 0;
        }
        public static void Update_status_Data()
        {
            DataTable DT = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection(path_database))
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
            using (SQLiteConnection con = new SQLiteConnection(path_database))
            {
                string Command1 = "";
                
                using (SQLiteCommand cmd = new SQLiteCommand(Command1, con))
                {
                    con.Open();
                    foreach (DataRow item in DT.Rows)
                    {
                        string ID_TASK = item["ID_TASK"].ToString();
                        string TIME_BEGIN = item["TIME_BEGIN"].ToString();
                        string TIME_END = item["TIME_END"].ToString();
                        if (item["STATUS"].ToString() == Process[1] || item["STATUS"].ToString() == Process[3]) continue;
                        string STATUS = Process[STATUS_TODOLIST(DateTime.Parse(TIME_BEGIN), DateTime.Parse(TIME_END))];
                        Command1 = $"UPDATE TODOLIST SET STATUS = '{STATUS}' WHERE ID_TASK = '{ID_TASK}';";
                        cmd.CommandText = Command1;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            
        }

        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        public static DataTable Data(string Command1)
        {
            Update_status_Data();
            DataTable DT = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection(path_database))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(Command1, con))
                {
                    con.Open();
                    SQLiteDataReader Dr = cmd.ExecuteReader();
                    DT.Load(Dr);
                    con.Close();
                }
            }
            return DT;
        } 
        public static void Update_Data(string Command)
        {
            using (SQLiteConnection con = new SQLiteConnection(path_database))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(Command, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
