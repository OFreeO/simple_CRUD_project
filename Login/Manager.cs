using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Manager
    {

        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
      "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
      "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
      "User Id=test;Password=1234;";

        public static OracleConnection OraConn = new OracleConnection(ORADB);

        public static List<Login_Info> login = new List<Login_Info>();

        const string table = "login";

        static void ConnectDB()
        {
            try
            {
                OraConn.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
        }
       
        public static void ADD(string ID,string PW, string C)
        {
            ConnectDB();
            try
            {
                string sql = $"select * from {table}";
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand();
                oda.SelectCommand.Connection = OraConn;
                oda.SelectCommand.CommandText = sql;

                DataSet ds = new DataSet();
                oda.Fill(ds, table);

                login.Clear();

                foreach(DataRow item in ds.Tables[0].Rows)
                {
                    Login_Info login = new Login_Info();
                    if (ID == item["ID"].ToString())
                    {
                        System.Windows.Forms.MessageBox.Show("이미 있는 아이디 입니다.");
                        return;
                    }
                    if (C != "Free")
                    {
                        System.Windows.Forms.MessageBox.Show("승인 코드가 틀립니다.");
                        return;
                    }
                    else
                    {
                        sql = $"insert into {table} values ('{ID}','{PW}')";
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = OraConn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                OraConn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
  
            }
            OraConn.Close();
        }
        public static void Check_User(string ID, string PW)
        {
            ConnectDB();

            string sql = $"select * from {table}";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, table);

            login.Clear();

            int i = 0;
            foreach(DataRow item in ds.Tables[0].Rows)
            {
                Login_Info login = new Login_Info();
                if (ID == item["ID"].ToString() && PW == item["PW"].ToString())
                {
                    i = 1;
                    Form1 form = new Form1();
                    Succes s = new Succes();
                    s.Show();
                }
            }
            if (i == 0)
            {
                System.Windows.Forms.MessageBox.Show("아이디 혹은 비밀번호를 확인해주세요.");
                return;
            }
        }
    }
}
