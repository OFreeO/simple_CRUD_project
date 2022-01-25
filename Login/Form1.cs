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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_user_Click(object sender, EventArgs e)
        {
            ADD add = new ADD();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = Manager.Check_User(IDBOX.Text, PWBOX.Text);
            if(result)
            {
                this.Hide();
                //Form2 form2 = new Form2();
                //form2.ShowDialog();
                Vip.Form1 main = new Vip.Form1();
                //멤버관리창 호출
                main.ShowDialog();
                this.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void PWBOX_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                //button1_Click(sender, e);
            }
        }
    }
}
