namespace whyNot
{
    partial class Form1
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
            this.dtgvBecas = new System.Windows.Forms.DataGridView();
            this.dtgvAlumno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBecasAlumno = new System.Windows.Forms.Label();
            this.dtgvBecasAlumno = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPosgrado = new System.Windows.Forms.RadioButton();
            this.rbGrado = new System.Windows.Forms.RadioButton();
            this.rbIngresante = new System.Windows.Forms.RadioButton();
            this.btnAgregarAlumnos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumnos = new System.Windows.Forms.Button();
            this.btnModificarAlumnos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminarBecas = new System.Windows.Forms.Button();
            this.btnAgregarBecas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.rb3XCuota = new System.Windows.Forms.RadioButton();
            this.rb2XCuota = new System.Windows.Forms.RadioButton();
            this.rb1xCuota = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBecasAlumno)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBecas
            // 
            this.dtgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBecas.Location = new System.Drawing.Point(353, 30);
            this.dtgvBecas.Name = "dtgvBecas";
            this.dtgvBecas.Size = new System.Drawing.Size(304, 150);
            this.dtgvBecas.TabIndex = 1;
            // 
            // dtgvAlumno
            // 
            this.dtgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumno.Location = new System.Drawing.Point(29, 30);
            this.dtgvAlumno.Name = "dtgvAlumno";
            this.dtgvAlumno.Size = new System.Drawing.Size(304, 150);
            this.dtgvAlumno.TabIndex = 2;
            this.dtgvAlumno.SelectionChanged += new System.EventHandler(this.dtgvAlumno_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alumnos :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Becas :";
            // 
            // labelBecasAlumno
            // 
            this.labelBecasAlumno.AutoSize = true;
            this.labelBecasAlumno.Location = new System.Drawing.Point(350, 197);
            this.labelBecasAlumno.Name = "labelBecasAlumno";
            this.labelBecasAlumno.Size = new System.Drawing.Size(87, 13);
            this.labelBecasAlumno.TabIndex = 6;
            this.labelBecasAlumno.Text = "Becas - Alumno :";
            // 
            // dtgvBecasAlumno
            // 
            this.dtgvBecasAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBecasAlumno.Location = new System.Drawing.Point(353, 213);
            this.dtgvBecasAlumno.Name = "dtgvBecasAlumno";
            this.dtgvBecasAlumno.Size = new System.Drawing.Size(304, 150);
            this.dtgvBecasAlumno.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPosgrado);
            this.groupBox1.Controls.Add(this.rbGrado);
            this.groupBox1.Controls.Add(this.rbIngresante);
            this.groupBox1.Location = new System.Drawing.Point(32, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // rbPosgrado
            // 
            this.rbPosgrado.AutoSize = true;
            this.rbPosgrado.Location = new System.Drawing.Point(7, 65);
            this.rbPosgrado.Name = "rbPosgrado";
            this.rbPosgrado.Size = new System.Drawing.Size(70, 17);
            this.rbPosgrado.TabIndex = 2;
            this.rbPosgrado.Text = "Posgrado";
            this.rbPosgrado.UseVisualStyleBackColor = true;
            // 
            // rbGrado
            // 
            this.rbGrado.AutoSize = true;
            this.rbGrado.Location = new System.Drawing.Point(7, 43);
            this.rbGrado.Name = "rbGrado";
            this.rbGrado.Size = new System.Drawing.Size(54, 17);
            this.rbGrado.TabIndex = 1;
            this.rbGrado.Text = "Grado";
            this.rbGrado.UseVisualStyleBackColor = true;
            // 
            // rbIngresante
            // 
            this.rbIngresante.AutoSize = true;
            this.rbIngresante.Checked = true;
            this.rbIngresante.Location = new System.Drawing.Point(7, 20);
            this.rbIngresante.Name = "rbIngresante";
            this.rbIngresante.Size = new System.Drawing.Size(75, 17);
            this.rbIngresante.TabIndex = 0;
            this.rbIngresante.TabStop = true;
            this.rbIngresante.Text = "Ingresante";
            this.rbIngresante.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumnos
            // 
            this.btnAgregarAlumnos.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarAlumnos.Name = "btnAgregarAlumnos";
            this.btnAgregarAlumnos.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAlumnos.TabIndex = 8;
            this.btnAgregarAlumnos.Text = "Agregar";
            this.btnAgregarAlumnos.UseVisualStyleBackColor = true;
            this.btnAgregarAlumnos.Click += new System.EventHandler(this.btnAgregarAlumnos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarAlumnos);
            this.groupBox2.Controls.Add(this.btnModificarAlumnos);
            this.groupBox2.Controls.Add(this.btnAgregarAlumnos);
            this.groupBox2.Location = new System.Drawing.Point(29, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 56);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones -Alumno";
            // 
            // btnEliminarAlumnos
            // 
            this.btnEliminarAlumnos.Location = new System.Drawing.Point(168, 19);
            this.btnEliminarAlumnos.Name = "btnEliminarAlumnos";
            this.btnEliminarAlumnos.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAlumnos.TabIndex = 10;
            this.btnEliminarAlumnos.Text = "Eliminar";
            this.btnEliminarAlumnos.UseVisualStyleBackColor = true;
            this.btnEliminarAlumnos.Click += new System.EventHandler(this.btnEliminarAlumnos_Click);
            // 
            // btnModificarAlumnos
            // 
            this.btnModificarAlumnos.Location = new System.Drawing.Point(87, 19);
            this.btnModificarAlumnos.Name = "btnModificarAlumnos";
            this.btnModificarAlumnos.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAlumnos.TabIndex = 9;
            this.btnModificarAlumnos.Text = "Modificar";
            this.btnModificarAlumnos.UseVisualStyleBackColor = true;
            this.btnModificarAlumnos.Click += new System.EventHandler(this.btnModificarAlumnos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminarBecas);
            this.groupBox3.Controls.Add(this.btnAgregarBecas);
            this.groupBox3.Location = new System.Drawing.Point(161, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 82);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones -Becas";
            // 
            // btnEliminarBecas
            // 
            this.btnEliminarBecas.Location = new System.Drawing.Point(23, 48);
            this.btnEliminarBecas.Name = "btnEliminarBecas";
            this.btnEliminarBecas.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarBecas.TabIndex = 10;
            this.btnEliminarBecas.Text = "Eliminar";
            this.btnEliminarBecas.UseVisualStyleBackColor = true;
            this.btnEliminarBecas.Click += new System.EventHandler(this.btnEliminarBecas_Click);
            // 
            // btnAgregarBecas
            // 
            this.btnAgregarBecas.Location = new System.Drawing.Point(23, 19);
            this.btnAgregarBecas.Name = "btnAgregarBecas";
            this.btnAgregarBecas.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarBecas.TabIndex = 8;
            this.btnAgregarBecas.Text = "Agregar";
            this.btnAgregarBecas.UseVisualStyleBackColor = true;
            this.btnAgregarBecas.Click += new System.EventHandler(this.btnAgregarBecas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPagar);
            this.groupBox4.Controls.Add(this.rb3XCuota);
            this.groupBox4.Controls.Add(this.rb2XCuota);
            this.groupBox4.Controls.Add(this.rb1xCuota);
            this.groupBox4.Location = new System.Drawing.Point(29, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 122);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones - Pagar";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(6, 93);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 10;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // rb3XCuota
            // 
            this.rb3XCuota.AutoSize = true;
            this.rb3XCuota.Location = new System.Drawing.Point(10, 67);
            this.rb3XCuota.Name = "rb3XCuota";
            this.rb3XCuota.Size = new System.Drawing.Size(72, 17);
            this.rb3XCuota.TabIndex = 5;
            this.rb3XCuota.Text = "3 X Cuota";
            this.rb3XCuota.UseVisualStyleBackColor = true;
            // 
            // rb2XCuota
            // 
            this.rb2XCuota.AutoSize = true;
            this.rb2XCuota.Location = new System.Drawing.Point(10, 45);
            this.rb2XCuota.Name = "rb2XCuota";
            this.rb2XCuota.Size = new System.Drawing.Size(72, 17);
            this.rb2XCuota.TabIndex = 4;
            this.rb2XCuota.Text = "2 X Cuota";
            this.rb2XCuota.UseVisualStyleBackColor = true;
            // 
            // rb1xCuota
            // 
            this.rb1xCuota.AutoSize = true;
            this.rb1xCuota.Checked = true;
            this.rb1xCuota.Location = new System.Drawing.Point(10, 22);
            this.rb1xCuota.Name = "rb1xCuota";
            this.rb1xCuota.Size = new System.Drawing.Size(72, 17);
            this.rb1xCuota.TabIndex = 3;
            this.rb1xCuota.TabStop = true;
            this.rb1xCuota.Text = "1 X Cuota";
            this.rb1xCuota.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 504);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelBecasAlumno);
            this.Controls.Add(this.dtgvBecasAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvAlumno);
            this.Controls.Add(this.dtgvBecas);
            this.Name = "Form1";
            this.Text = "Simulador de Pagos - Alumnos.";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBecasAlumno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBecas;
        private System.Windows.Forms.DataGridView dtgvAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBecasAlumno;
        private System.Windows.Forms.DataGridView dtgvBecasAlumno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPosgrado;
        private System.Windows.Forms.RadioButton rbGrado;
        private System.Windows.Forms.RadioButton rbIngresante;
        private System.Windows.Forms.Button btnAgregarAlumnos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarAlumnos;
        private System.Windows.Forms.Button btnModificarAlumnos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarBecas;
        private System.Windows.Forms.Button btnAgregarBecas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.RadioButton rb3XCuota;
        private System.Windows.Forms.RadioButton rb2XCuota;
        private System.Windows.Forms.RadioButton rb1xCuota;
    }
}

