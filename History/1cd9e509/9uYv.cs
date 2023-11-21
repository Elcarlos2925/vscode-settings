using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    internal class ClaseAlumnos
    {
        public void MostrarAlumnos(DataGridView tablaAlumnos)
        {
            try
            {
                cadena objConexión = new cadena();
                String Query = "select * from ALUMNOS";
                tablaAlumnos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, objConexión.establecerConexión());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlumnos.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se muestran los datos" + e.ToString());
            }
        }
        public void GuardarAlumnos(TextBox ID,TextBox Nom, TextBox Ape, TextBox Date)
        {
            try
            {
                cadena objConex = new cadena();
                string query = "insert into ALUMNOS (ID_ALUMNO, NOMBRE, APELLIDOS, F_NACIMIENTO)" +
                "values(" + ID.Text + ",'" + Nom.Text + "','" + Ape.Text + "','" + Date.Text + "');";

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
        public void ConsultaAlumnos(TextBox ID,TextBox Nom, TextBox Ape, TextBox Date)
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
                    ID.Text = MyReader.GetString();
                    Nom.Text = (String)MyReader.GetString();
                    Ape.Text = (String)MyReader.GetString();
                    Date.Text = MyReader["F_NACIMIENTO"].ToString();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error " + e.ToString());
            }
        }
    }
}