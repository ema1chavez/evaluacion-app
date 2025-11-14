using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion_app
{
    internal class Conexion
    {
        SqlConnection connection = new SqlConnection("Database=libros_app;Data Source=192.168.10.2;User Id=sa;Password=Hyp3r10nPr0_;TrustServerCertificate=True");
        public void Conectar()
     
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection ObtenerConexion()
        {
            return connection;
        }
    }
}
