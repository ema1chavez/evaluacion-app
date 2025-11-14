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

    public partial class CategoriaFrm : Form
    {
     int categorias_id = 0;

        public CategoriaFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = txtno.Text;
            bool resultado = false;
            if (categorias_id == 0)
            {
                resultado = Categorias.guardar(nombres);
            }
            else
            {
                resultado = Categorias.editar(categorias_id, nombres);
            }

            if (resultado)
            {
                MessageBox.Show("Operacion Realizada Correctamente");
            }
            dataGridView1.DataSource = Categorias.Obtener();
            limpiar();
        }

        private void limpiar()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
               txtno.Text = dataGridView1.CurrentRow.Cells["nombres"].Value.ToString();
            categorias_id=Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Categorias.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado Correctamente");
            }
            else
            {
                MessageBox.Show("Error al Eliminar el Cliente");
            }
                dataGridView1.DataSource = Categorias.Obtener();
            limpiar();
        }

        private void CategoriaFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Categorias.Obtener();
        
        }
    }
    }



