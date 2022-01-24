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
            Manager.Check_User(IDBOX.Text, PWBOX.Text);
            this.Close();
        }
    }
}
