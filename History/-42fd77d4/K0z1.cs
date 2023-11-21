using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    internal class Clase_Alumnos_Curso
    {
        public void MostrarAlumnosCursos(DataGridView TablaAlumnoCurso)
        {
            try
            {
                cadena objConexión = new cadena();
                String Query = "select * from ALUMNOS_CURSOS";
                TablaAlumnoCurso.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, objConexión.establecerConexión());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TablaAlumnoCurso.DataSource = dt;


            }
            catch (Exception e)
            {
                MessageBox.Show("No se muestran los datos" + e.ToString());
            }
        }
        public void GuardarAlumnosCurso(TextBox ID_Alumno, TextBox ID_Curso, TextBox NOTA)
        {
            try
            {
                cadena objConex = new cadena();
                String query = "insert into ALUMNOS_CURSOS (ID_ALUMNO, ID_CURSO, NOTA)" +
                   "values(" + ID_Alumno.Text + "," + ID_Curso.Text + "," + NOTA.Text + ");";
                 //"values('" + ID_Alumno.Text + "','" + ID_Curso.Text + "','" + NOTA.Text + "');";

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
        public void ConsultaAlumnosCurso(TextBox ID_Alumno, TextBox ID_Curso, TextBox NOTA)
        {
            try
            {
                cadena objConex = new cadena();
                string query = "SELECT ID_ALUMNO, NOMBRE, APELLIDOS, F_NACIMIENTO FROM ALUMNOS WHERE " +
                "ID_ALUMNO = " + ID.Text + ";";
                MySqlCommand(query, objCon.establecerConexion());
                MySqlDataReader MyReader;
                MyReader = command.ExecuteReader();
                while (MyReader.Read())
                {
                    ID_Alumno.Text = MyReader.GetString();
                    ID_Curso.Text = (String)MyReader.GetString();
                    NOTA.Text = (String)MyReader.GetString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error " + e.ToString());
            }
        }
    }
}
