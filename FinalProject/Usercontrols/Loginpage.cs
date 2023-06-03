using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Usercontrols
{
    public partial class Loginpage : UserControl
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void signBTN_Click(object sender, EventArgs e)
        {
            var Parent = this.Parent as parentF;
            if (Parent != null) {
                Parent.hideLogin();
            }
        }
    }
}
