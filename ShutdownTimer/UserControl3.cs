using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class UserControl3 : UserControl
    {
        public event EventHandler Button_Click;
        public event EventHandler ButtonBack_Click;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Button_Click != null)
                Button_Click(this, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ButtonBack_Click != null)
                ButtonBack_Click(this, e);
        }
    }
}
