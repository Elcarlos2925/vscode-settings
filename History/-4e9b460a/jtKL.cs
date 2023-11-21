using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    internal class Clases_Cursos
    {
        public void mostrarCursos(DataGridView tablaCurso)
        {
            try
            {
                cadena objConexión = new cadena();
                String Query = "select * from CURSOS";
                tablaCurso.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, objConexión.establecerConexión());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCurso.DataSource = dt;


            }
            catch (Exception e)
            {
                MessageBox.Show("No se muestran los datos" + e.ToString());
            }
        }
        public void GuardarCurso(TextBox ID, TextBox Materia, TextBox ID_Profe)
        {
            try
            {
                cadena objConex = new cadena();
                String query = "insert into CURSOS (ID_CURSO, TITULO, ID_PROFESOR)" +
                   "values(" + ID.Text + ",'" + Materia.Text + "'," + ID_Profe.Text + ");";

                MySqlCommand MCommand = new MySqlCommand(query, objConex.establecerConexión());
                MySqlDataReader MyReader = MCommand.ExecuteReader();
                MessageBox.Show("Se guardo exitosamente el registro en la base de datos", "Guardado exisosamente");
                while (MyReader.Read()) { }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error " + e.ToString());
            }
        }
        public void ConsultaCursos(TextBox ID, TextBox Materia, TextBox ID_Profe)
        {
            try
            {
                cadena objConex = new cadena();
                string query = "SELECT ID_CURSO, TITULO, ID_PROFESOR FROM CURSOS WHERE " +
                "ID_CURSO = " + ID.Text + ";";
                MySqlCommand(query, objCon.establecerConexion());
                MySqlDataReader MyReader;
                MyReader = command.ExecuteReader();
                while (MyReader.Read())
                {
                    ID.Text = MyReader.GetString();
                    Materia.Text = (String)MyReader.GetString();
                    ID_Profe.Text = (String)MyReader.GetString();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error " + e.ToString());
            }
        }
    }
}
