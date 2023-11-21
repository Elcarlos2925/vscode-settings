using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
