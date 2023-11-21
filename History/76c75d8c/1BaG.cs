using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    internal class Clase_Profesores
    {
        public void MostrarProfesores(DataGridView tablaProfe)
        {
            try
            {
                cadena objConexión = new cadena();
                String Query = "select * from PROFESORES";
                tablaProfe.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, objConexión.establecerConexión());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaProfe.DataSource = dt;


            }
            catch (Exception e)
            {
                MessageBox.Show("No se muestran los datos" + e.ToString());
            }
        }
        public void GuardarProfesores(TextBox ID,TextBox Nom, TextBox Ape, TextBox Date)
        {
            try
            {
                cadena objConex = new cadena();
                string query = "insert into PROFESORES (ID_PROFESOR, NOMBRE, APELLIDOS, F_NACIMIENTO)" +
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
    }
}