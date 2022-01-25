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
        //DB 접속 정보
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
      "(ADDRESS=(PROTOCOL=TCP)(HOST=KB-PC)(PORT=1521)))" +
      "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
      "User Id=test;Password=1234;";

        public static OracleConnection OraConn = new OracleConnection(ORADB);

        public static List<Login_Info> login = new List<Login_Info>();

        const string table = "login";

        static void ConnectDB()
        {
            //DB접속 클래스
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
            //접속
            ConnectDB();
            try
            {
                //sql문
                string sql = $"select * from {table}";
                //새 접속
                OracleDataAdapter oda = new OracleDataAdapter();
                //오라클 생성
                oda.SelectCommand = new OracleCommand();
                //오라클 접속 참조
                oda.SelectCommand.Connection = OraConn;
                //sql 삽입
                oda.SelectCommand.CommandText = sql;

                //데이터셋 선언
                DataSet ds = new DataSet();
                //table 내 데이터를 데이터셋에 적용
                oda.Fill(ds, table);

                login.Clear();
                int i = 1;
                //존재하는 아이템 값 확인
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    Login_Info login = new Login_Info();
                    if (ID == item["ID"].ToString())
                    {//생성 아이디와 기존 아이디 중복 여부 체크
                        System.Windows.Forms.MessageBox.Show("이미 있는 아이디 입니다.");
                        OraConn.Close();
                        i = 0;
                        break;
                    }
                    if (C != "Free")
                    {//등록 승인 코드 일치 여부 확인
                        System.Windows.Forms.MessageBox.Show("승인 코드가 틀립니다.");
                        OraConn.Close();
                        i = 0;
                        break;
                    }
                }
                if(i == 1)
                {//등록 구문
                    sql = $"insert into {table} values ('{ID}','{PW}')";
                    System.Windows.Forms.MessageBox.Show("등록되었습니다.");
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = OraConn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                OraConn.Close();
            }
            catch (Exception ex)
            {
                OraConn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
  
            }
            OraConn.Close();
            //접속해제
        }
        public static bool Check_User(string ID, string PW)
        {//로그인 클래스
            ConnectDB();
            try
            {
                //sql문
                string sql = $"select * from {table}";
                //새 접속선언
                OracleDataAdapter oda = new OracleDataAdapter();
                //oracle 관련문 선언
                oda.SelectCommand = new OracleCommand();
                //oracle 접속 선언
                oda.SelectCommand.Connection = OraConn;
                //sql문 사용
                oda.SelectCommand.CommandText = sql;

                //데이터셋 선언
                DataSet ds = new DataSet();
                //데이터셋을 접속한 DB의 테이블 내용 적용
                oda.Fill(ds, table);

                login.Clear();
                // 확인용 i 선언
                int i = 0;
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    Login_Info login = new Login_Info();
                    if (ID == item["ID"].ToString() && PW == item["PW"].ToString())
                    {
                        //정보가 일치시 i 를 1로 변경
                        i = 1;
                        //멤버관리창 선언

                       
                        OraConn.Close();
                        return true;
                        //Login.Hide();
                        //main.ShowDialog();
                        //Login.Close();

                    }
                }

                if (i == 0)
                {
                    //모두 비교하여도 i가 0인경우 안내메세지 도출
                    System.Windows.Forms.MessageBox.Show("아이디 혹은 비밀번호를 확인해주세요.");
                }
                OraConn.Close();
                return false;
            }
            catch (Exception)
            {

                OraConn.Close();
                throw;
            }
            
        }
    }
}
