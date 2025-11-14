using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion_app
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CategoriaFrm frm = new CategoriaFrm();
            frm.MdiParent = this;
            frm.Show();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AutoresFrm frm = new AutoresFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            EditorialesFrm frm = new EditorialesFrm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
