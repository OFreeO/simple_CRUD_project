using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        public bool checkAdd(bool a)
        {
            a = true;
            if(PWBOX.Text != PW_CHKBOX.Text)
                //비밀번호와 비밀번호 확인의 동일 유무 확인
            {
                MessageBox.Show("비밀번호가 서로 다릅니다.");
                a = false;
                return a;
            }
            else
            {
                //회원가입 로직으로 이동
                Manager.ADD(IDBOX.Text,PWBOX.Text,CODE.Text);
                a = true;
                return a;
            }
        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
            bool a = true;
            checkAdd(a);
            if (a == true)
                this.Close();
            else
                return;
        }

        private void ADD_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ADDbtn_Click(sender, e);
            }
        }
    }
}
