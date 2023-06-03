using FinalProject.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class parentF : Form
    {
        public parentF()
        {
            InitializeComponent();
        }
        private void panel2_Paint(object sender, EventArgs e)
        {

        }
        private void DashBTN_Click(object sender, EventArgs e)
        {

        }
        private void HomeBTN_Click(object sender, EventArgs e)
        {

        }
        public void hideLogin()
        {
            loginpage1.SendToBack();
            loginpage1.Hide();
        }

        private void loginpage1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
        /*
        var Loginpage = new Loginpage();
        Loginpage.Show(); //Show new form
        his.Hide(); // Hide the current form
        */
    }
}
