using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evaluacion_app.Modelos;

namespace evaluacion_app
{
    public partial class AutoresFrm : Form
    {
        int autores_id = 0;
        public AutoresFrm()
        {
            InitializeComponent();
        }

        private void AutoresFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Autores.Obtener();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = txtnombre.Text;
            string apellidos = txtapellidos.Text;
            string fecha_nacimiento = txtfecha.Text;
            string pais = txtpais.Text;
            string biografia = txtbio.Text;
            bool resultado = false;
            if( autores_id==0)
            {
                resultado = Autores.Crear(nombres, apellidos, fecha_nacimiento, pais, biografia);
            }
            else
            {
               resultado = Autores.Editar(autores_id, nombres, apellidos, fecha_nacimiento, pais, biografia);
            }
            if (resultado)
            {
                MessageBox.Show("Operacion Realizada Correctamente");
            }
            else
            {
                MessageBox.Show("Error al realizar la operacion");
            }
            dataGridView1.DataSource = Autores.Obtener();
            limpiar();
        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtapellidos.Clear();
            txtfecha.Clear();
            txtpais.Clear();
            txtbio.Clear();
            autores_id = 0;
            txtnombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Text = dataGridView1.CurrentRow.Cells["nombres"].Value.ToString();
            txtapellidos.Text = dataGridView1.CurrentRow.Cells["apellidos"].Value.ToString();
            txtfecha.Text = dataGridView1.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
            txtpais.Text = dataGridView1.CurrentRow.Cells["pais"].Value.ToString();
            txtbio.Text = dataGridView1.CurrentRow.Cells["biografia"].Value.ToString();
            autores_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            if(Autores.Eliminar(id))
            {
                MessageBox.Show("Registro Eliminado Correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro");
            }
            dataGridView1.DataSource = Autores.Obtener();
            limpiar();
        }
    }
}
