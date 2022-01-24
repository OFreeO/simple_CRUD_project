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
            {
                MessageBox.Show("비밀번호가 서로 다릅니다.");
                a = false;
                return a;
            }
            else
            {
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
    }
}
