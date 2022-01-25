using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vip
{
    public partial class Form1 : Form
    {

        private Point MousePoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (MousePoint.X - e.X),
                    this.Top - (MousePoint.Y - e.Y));
            }
        }

        public Form1()
        {
            InitializeComponent();

            Log_Info("프로그램 시작");

            None.Checked = true;
            Manager.selectQuery();
            refresh();
            timer1.Interval = 1000;
            timer1.Start();

            //로그 조회 관련 세팅
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;


        }
        public void Log_Start()
        {
            //로그 파일 경로 지정
            string local = @"C:\log";

            //파일 이름 지정
            string title = DateTime.Now.ToString("yyyy-MM-dd");

            OpenFileDialog ofd = new OpenFileDialog();
            //메모장 형식으로 생성
            ofd.Filter = title + "(*.txt) | *.txt";
            //경로
            ofd.InitialDirectory = local + "\\log";
            //파일 유무 검사
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    listView1.Items.Clear();

                    string filename = "";
                    filename = ofd.FileName;
                //없을시 메시지 도출
                    if (!System.IO.File.Exists(filename))
                    {
                        MessageBox.Show("해당 파일이 없습니다");
                        return;
                    }
                    else
                    {
                    //선택된경우 내용 표시.
                        string[] value = System.IO.File.ReadAllLines(filename);
                        for(int i = 0; i < value.Length; i++)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = (i + 1).ToString();
                            lvi.SubItems.Add(value[i]);

                            listView1.Items.Add(lvi);
                        }
                    }
                }
            }

        public bool Log_Info(string M)
        {
            try
            {
                //문자열 2개 선언
                string checkfolder = "";
                string filename = "";

                //경로 선언
                string local = @"C:\log";

                checkfolder = local + "\\log";

                //파일이 존재하지 않을경우 생성
                if (!System.IO.Directory.Exists(checkfolder))
                {
                    System.IO.Directory.CreateDirectory(checkfolder);
                }
                //파일 이름 지정
                filename = checkfolder + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                //파일에 내용 작성
                System.IO.StreamWriter FileWriter = new System.IO.StreamWriter(filename, true);
                FileWriter.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " : " + M + "\r\n");

                FileWriter.Flush();
                //작성 종료
                FileWriter.Close();

            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        void refresh()
        {
            MemberView.DataSource = null;
            try
            {
                if(Manager.members.Count > 0)
                {
                    MemberView.DataSource = Manager.members;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Addbtn_Click(object sender, System.EventArgs e)
        {
            string grade = "";
            try
            {
                if(NameBox.Text == "")
                {
                    //이름 확인
                    MessageBox.Show("고객의 이름을 입력해주세요.");
                    return;
                }
                if(JuminBox.Text == "")
                {
                    //주민번호 확인
                    MessageBox.Show("고객의 주민번호를 입력해주세요.");
                    return;
                }
                if (PhoneBox.Text == "")
                {
                    //휴대전화 미소지자를 위한 대우
                    PhoneBox.Text = "휴대폰 미소유";
                }
                else
                {
                    //라디오 체크의 대한 분류
                    if (VVIP.Checked == true)
                    {
                        grade = "VVIP";
                    }
                    if (VIP.Checked == true)
                    {
                        grade = "VIP";
                    }
                    if (None.Checked == true)
                    {
                        grade = "일반";
                    }
                    //함수로 쿼리문 작성
                    Manager.executeQuery("insert", NameBox.Text, JuminBox.Text,
                    PhoneBox.Text, grade);
                    Manager.selectQuery();
                    //로그에 표시될 내용
                    Log_Info($"{NameBox.Text} 님 등록(등급 : {grade})");
                    //안내메세지창 띄우기
                    MessageBox.Show($"{NameBox.Text}님 등록 완료.");
                    //등록후 텍스트 박스초기화.
                    NameBox.Text = "";
                    JuminBox.Text = "";
                    PhoneBox.Text = "";
                    //그리드뷰 새로고침
                    refresh();

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void Find_Click(object sender, System.EventArgs e)
        {
            string F = Find_Phonenum_Box.Text;
            Manager.find(F);
            Find_Phonenum_Box.Text = "";
        }

        private void Updatebtn_Click(object sender, System.EventArgs e)
        {
            //회원 추가와 코드가 거의 유사하다
            string grade = "";
            try
            {
                if (NameBox.Text == "")
                {
                    MessageBox.Show("고객의 이름을 입력해주세요.");
                    return;
                }
                if (JuminBox.Text == "")
                {
                    MessageBox.Show("고객의 전화번호를 입력해주세요.");
                    return;
                }
                else
                {
                    if (VVIP.Checked == true)
                    {
                        grade = "VVIP";
                    }
                    else if (VIP.Checked == true)
                    {
                        grade = "VIP";
                    }
                    else if(None.Checked == true)
                    {
                        grade = "일반";
                    }
                    Manager.executeQuery("update", NameBox.Text, JuminBox.Text,
                    PhoneBox.Text, grade);
                    Manager.selectQuery();
                    Log_Info($"{NameBox.Text} 님 정보 수정 완료");
                    NameBox.Text = "";
                    JuminBox.Text = "";
                    PhoneBox.Text = "";
                    refresh();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Delbtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(Del_NameBox.Text == "")
                {
                    MessageBox.Show("이름을 입력해주세요.");
                    return;
                }
                if (Del_JuminBox.Text == "")
                {
                    MessageBox.Show("주민번호를 입력해주세요.");
                    return;
                }
                else
                {
                    Manager.executeQuery("delete", Del_NameBox.Text, Del_JuminBox.Text);
                    Manager.selectQuery();
                    refresh();
                    Log_Info($"{Del_NameBox.Text} 고객님 해지 처리 완료");
                    MessageBox.Show($"{Del_NameBox.Text}고객님 해지 처리 완료");
                    Del_JuminBox.Text = "";
                    Del_NameBox.Text = "";
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private void MemberView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Member  mem = MemberView.CurrentRow.DataBoundItem as Member;
            NameBox.Text = mem.Name.ToString();
            JuminBox.Text = mem.Jumin;
            PhoneBox.Text = mem.PhoneNum;
            if(mem.Grade == "VVIP")
            {
                VVIP.Checked = true;
            }
            if(mem.Grade == "VIP")
            {
                VIP.Checked = true;
            }
            if(mem.Grade == "일반")
            {
                None.Checked = true;
            }
        }


        private void Time_Tick(object sender, System.EventArgs e)
        {

            Time.Text = System.DateTime.Now.ToString();
        }

        private void MemberView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(MemberView.Rows[e.RowIndex].Cells[3].Value.ToString() == "VIP")
            {
                e.CellStyle.BackColor = Color.Aqua;
            }
            if (MemberView.Rows[e.RowIndex].Cells[3].Value.ToString() == "VVIP")
            {
                e.CellStyle.BackColor = Color.Yellow;
            }
            if (MemberView.Rows[e.RowIndex].Cells[3].Value.ToString() == "일반")
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void quit_Click(object sender, System.EventArgs e)
        {
            Log_Info("프로그램 종료");
            this.Close();
        }

        private void What_If_Click(object sender, System.EventArgs e)
        {
            Log_Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
