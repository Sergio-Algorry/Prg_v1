using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg_v1.FrontEnd
{
    public partial class frmSergio : Form
    {
        public frmSergio()
        {
            InitializeComponent();
        }

        private void btSaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola " + txtNombre.Text + "!!!!!!!";
        }
    }
}
