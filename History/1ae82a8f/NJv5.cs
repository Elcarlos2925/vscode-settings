using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_datos_Conexión.clases
{
    internal class Clase_Alumnos
    {
        public void mostraralumnos(DataGridView tablaAlumnos)
        {
            try
            {
                CConexiones objConexion = new CConexiones();
                String query = "select * from alumnos";
                tablaAlumnos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConexion.establecerconeccion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlumnos.DataSource = dt;

            }
            catch(Exception e)
            {
                MessageBox.Show("No hay datos disponibles"+ e.ToString());
            }
        }

        public void GuardarAlumnos(TextBox id, TextBox nom, TextBox ape, TextBox fecha)
        {
            try
            {
                CConexiones objConexion = new CConexiones();
                string query = "insert into alumnos(ID_ALUMNO, NOMBRE, APELIDO, FECHA_NACIMIENTO)"+
                    "values('"+id.Text+"','"+ nom.Text + "','" + ape.Text + "','" + fecha.Text + "');";
                MySQLCommand mcommand = new MYSQLCommand(query, objConexion.establecerconeccion());
                MySQLDataReader myReader = mcommand.ExecuteReader();
                MessageBox.Show("Se guardo el registro en la Base de Datos");
            }
            catch
            {

            }
        }
    }
}
