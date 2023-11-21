using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.ClaseAlumnos objAlumnos = new Clases.ClaseAlumnos();
            objAlumnos.MostrarAlumnos(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.cadena objConecta = new Clases.cadena();
            objConecta.establecerConexión();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaseAlumnos ObjConex = new ClaseAlumnos();
            //ObjConex.GuardarAlumnos(textBox1, textBox2, textBox3, textBox4);
            ObjConex.ConsultaAlumnos(texBox1);
            ObjConex.MostrarAlumnos(databGridView1);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}