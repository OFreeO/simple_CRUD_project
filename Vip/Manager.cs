using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace Vip
{
    public class Manager
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
              "(ADDRESS=(PROTOCOL=TCP)(HOST=KB-PC)(PORT=1521)))" +
              "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
              "User Id=test;Password=1234;";
        public static OracleConnection OraConn = new OracleConnection(ORADB);

        public static List<Member> members = new List<Member>();

        const string Table = "Member";

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

        public static void find(string f)
        {
            ConnectDB();

            string sql = $"select * from {Table} where Phonenum = '{f}'";
            int i = 0;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, Table);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                if (f.Equals(item["Phonenum"]))
                {
                    System.Windows.Forms.MessageBox.Show($"성함 : {item["Name"]}\n주민번호 : {item["jumin"]}\n" +
                        $"전화번호 : {item["Phonenum"]}\n멤버쉽 등급 : {item["grade"]}");
                    i = 1;
                    break;
                }
            }
            if (i == 0)
            {
                System.Windows.Forms.MessageBox.Show("등록된 정보가 없습니다.");
            }
            OraConn.Close();
        }
        public static void selectQuery()
        {
            ConnectDB();

            string sql = "select * from " + Table +" order by name";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, Table);

            members.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Member member = new Member();
                member.Name = item["name"].ToString();
                member.Jumin = item["jumin"].ToString();
                member.PhoneNum = item["Phonenum"].ToString();
                member.Grade = item["grade"].ToString();
                member.AddTime = item["Datatime"].ToString()
                    == "" ? new DateTime() : DateTime.Parse(item["Datatime"].ToString());  
           
                members.Add(member);
            }
            OraConn.Close();
        }

        public static Member SelectQuery(string F)
        {
            ConnectDB();

            string sql = $"select * from {Table} where jumin = '{F}'";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText= sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, Table);

            DataRow item = ds.Tables[0].Rows[0];
            Member member = new Member();
            member.Name = item["name"].ToString();
            member.Jumin = item["jumin"].ToString();
            member.PhoneNum = item["Phonenum"].ToString();
            member.Grade = item["grade"].ToString();
            member.AddTime = item["AddTime"].ToString()
                == "" ? new DateTime() : DateTime.Parse(item["AddTime"].ToString());

            OraConn.Close();
            return member;
        }

        static string Query(string menu, string name,string jumin, string phonenum, string grade)
        {
            string query = "";
            switch (menu)
            {
                case "update":
                    query = $"update {Table} set name = '{name}', Phonenum = '{phonenum}'," +
                $"grade = '{grade}', Datatime = sysdate where jumin = '{jumin}'";
                    break;
                case "insert":
                    query = $"insert into {Table} values ('{name}', '{jumin}', '{phonenum}', '{grade}', sysdate)";
                    break;
                case "delete":
                    query = $"delete from {Table} where name = '{name}' and jumin like '{jumin}'";
                    break;
                default:
                    break;
            }
        return query;
        }

        public static void executeQuery(string menu, string name, string jumin=null, string phonenum=null, string grade=null)
        {
            //DB접속
            ConnectDB();
            //스트링형 쿼리문 공백으로 선언
            string query = "";

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                //입력된 정보를 토대로 Query 함수에 정보 전달
                query = Query(menu, name, jumin, phonenum, grade);
                //작성
                cmd.CommandText = query;
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                OraConn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                throw new Exception(query + "_" + ex.Message + "오류위치" + Environment.NewLine + ex.StackTrace);
            }

            OraConn.Close();
        }
    }
}
