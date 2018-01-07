using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (User.Text == "Pro" && Pass.Text == "Pro")
            {
                //this.Visible = false;
                //new Prog().Show();
                this.Hide();
                var prog = new Prog();
                prog.Closed += (s, args) => this.Close();
                prog.Show();

            }
            else if (User.Text == "Tes" && Pass.Text == "Tes")
            {
                this.Hide();
                var tes = new Tester();
                tes.Closed += (s, args) => this.Close();
                tes.Show();

            }
            else if (User.Text == "Dev" && Pass.Text == "Dev")
            {
                
                this.Hide();
                var dev = new Dev();
                dev.Closed += (s, args) => this.Close();
                dev.Show();
            }

        }
    }
}
