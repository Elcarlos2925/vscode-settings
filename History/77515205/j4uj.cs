namespace WinFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox5 = new GroupBox();
            label1 = new Label();
            btnAC = new Button();
            btnCursos = new Button();
            btnProfesores = new Button();
            btnAlumnos = new Button();
            btnSalir = new Button();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.None;
            groupBox5.BackColor = SystemColors.ActiveBorder;
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(btnAC);
            groupBox5.Controls.Add(btnCursos);
            groupBox5.Controls.Add(btnProfesores);
            groupBox5.Controls.Add(btnAlumnos);
            groupBox5.Location = new Point(112, 121);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(569, 171);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Opciones ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(232, 15);
            label1.TabIndex = 5;
            label1.Text = "Seleccione la tabla a la que desee ingresar: ";
            // 
            // btnAC
            // 
            btnAC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAC.Location = new Point(413, 67);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(121, 52);
            btnAC.TabIndex = 3;
            btnAC.Text = "Alumnos Cursos";
            btnAC.UseVisualStyleBackColor = true;
            btnAC.Click += btnAC_Click;
            // 
            // btnCursos
            // 
            btnCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCursos.Location = new Point(286, 67);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(121, 52);
            btnCursos.TabIndex = 2;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProfesores.Location = new Point(159, 67);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(121, 52);
            btnProfesores.TabIndex = 1;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAlumnos.Location = new Point(32, 67);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(121, 52);
            btnAlumnos.TabIndex = 0;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(563, 298);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;

// 
            // btnBuscarALumno
            // 
            btnBuscarAlumno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarAlumno.Location = new Point(563, 67);
            btnBuscarAlumno.Name = "btnBuscarAlumno";
            btnBuscarAlumno.Size = new Size(107, 34);
            btnBuscarAlumno.TabIndex = 6;
            btnBuscarAlumno.Text = "Consulta Alumno";
            btnBuscarAlumno.UseVisualStyleBackColor = true;
            btnBuscarAlumno.Click += btnBuscarAlumno_Click;

// btnBuscarProfesor
            // 
            btnBuscarProfesor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarProfesor.Location = new Point(563, 167);
            btnBuscarProfesor.Name = "btnBuscarProfesor";
            btnBuscarProfesor.Size = new Size(107, 34);
            btnBuscarProfesor.TabIndex = 7;
            btnBuscarProfesor.Text = "Consulta Profesor";
            btnBuscarProfesor.UseVisualStyleBackColor = true;
            btnBuscarProfesor.Click += btnBuscarProfesor_Click;

// btnBuscarCurso
            // 
            btnBuscarCurso.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarCurso.Location = new Point(563, 267);
            btnBuscarCurso.Name = "btnBuscarCurso";
            btnBuscarCurso.Size = new Size(107, 34);
            btnBuscarCurso.TabIndex = 8;
            btnBuscarCurso.Text = "Consulta Curso";
            btnBuscarCurso.UseVisualStyleBackColor = true;
            btnBuscarCurso.Click += btnBuscarCurso_Click;

// btnBuscarALumnos_Curso
            // 
            btnBuscarAlumnoAlumnos_Cursos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarAlumnoAlumnos_Cursos.Location = new Point(563, 367);
            btnBuscarAlumnoAlumnos_Cursos.Name = "btnBuscarAlumnoAlumnos_Cursos";
            btnBuscarAlumnoAlumnos_Cursos.Size = new Size(107, 34);
            btnBuscarAlumnoAlumnos_Cursos.TabIndex = 6;
            btnBuscarAlumnoAlumnos_Cursos.Text = "Consulta Alumnos_Cursos";
            btnBuscarAlumnoAlumnos_Cursos.UseVisualStyleBackColor = true;
            btnBuscarAlumnoAlumnos_Cursos.Click += btnAlumnoAlumno_Cursos_Click;



            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(groupBox5);
            Name = "Menu";
            Text = "Menú";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox5;
        private Button btnAC;
        private Button btnCursos;
        private Button btnProfesores;
        private Button btnAlumnos;
        private Button btnSalir;
        private Label label1;
        private Button btnBuscarAlumno;
        private Button btnBuscarProfesor;
        private Button btnBuscarCurso;
        private Button btnBuscarAlumnoAlumnos_Cursos;

    }
}