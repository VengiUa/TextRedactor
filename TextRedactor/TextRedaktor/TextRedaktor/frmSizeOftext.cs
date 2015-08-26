using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRedaktor
{
    public partial class frmSizeOftext : Form
    {
        public frmSizeOftext()
        {
            InitializeComponent();
        }

        private void SendSize(object sender, EventArgs e)
        {

            this.Text = txtBSize.Text;
        }

        private void EnterEnter(object sender, EventArgs e)
        {
            

            this.Text = txtBSize.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
            this.Dispose();



        }

       

       




    }
}
