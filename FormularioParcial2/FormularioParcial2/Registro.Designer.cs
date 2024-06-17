namespace FormularioParcial2
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btoIngresar = new Button();
            label4 = new Label();
            lbPais = new ListBox();
            gbGenero = new GroupBox();
            rbNoBinario = new RadioButton();
            rbFemenino = new RadioButton();
            rbMasculino = new RadioButton();
            gbCurso = new GroupBox();
            chkJavaScript = new CheckBox();
            chkCplus = new CheckBox();
            chkc = new CheckBox();
            gbDetalleUsuario = new GroupBox();
            label5 = new Label();
            mtbCUIT = new MaskedTextBox();
            nupEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbGenero.SuspendLayout();
            gbCurso.SuspendLayout();
            gbDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdad).BeginInit();
            SuspendLayout();
            // 
            // btoIngresar
            // 
            btoIngresar.Location = new Point(371, 343);
            btoIngresar.Name = "btoIngresar";
            btoIngresar.Size = new Size(124, 27);
            btoIngresar.TabIndex = 20;
            btoIngresar.Text = "Ingresar";
            btoIngresar.UseVisualStyleBackColor = true;
            btoIngresar.Click += btoIngresar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 195);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 18;
            label4.Text = "País";
            // 
            // lbPais
            // 
            lbPais.FormattingEnabled = true;
            lbPais.ItemHeight = 15;
            lbPais.Items.AddRange(new object[] { "Argentina", "Chile ", "Uruguay" });
            lbPais.Location = new Point(93, 207);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(177, 94);
            lbPais.TabIndex = 19;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbNoBinario);
            gbGenero.Controls.Add(rbFemenino);
            gbGenero.Controls.Add(rbMasculino);
            gbGenero.Location = new Point(370, 25);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(137, 149);
            gbGenero.TabIndex = 22;
            gbGenero.TabStop = false;
            gbGenero.Text = "Genero";
            // 
            // rbNoBinario
            // 
            rbNoBinario.AutoSize = true;
            rbNoBinario.Location = new Point(19, 97);
            rbNoBinario.Name = "rbNoBinario";
            rbNoBinario.Size = new Size(81, 19);
            rbNoBinario.TabIndex = 10;
            rbNoBinario.TabStop = true;
            rbNoBinario.Text = "No Binario";
            rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(19, 68);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(78, 19);
            rbFemenino.TabIndex = 9;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(19, 39);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 8;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCurso
            // 
            gbCurso.Controls.Add(chkJavaScript);
            gbCurso.Controls.Add(chkCplus);
            gbCurso.Controls.Add(chkc);
            gbCurso.Location = new Point(370, 195);
            gbCurso.Name = "gbCurso";
            gbCurso.Size = new Size(137, 124);
            gbCurso.TabIndex = 23;
            gbCurso.TabStop = false;
            gbCurso.Text = "Curso";
            // 
            // chkJavaScript
            // 
            chkJavaScript.AutoSize = true;
            chkJavaScript.Location = new Point(18, 87);
            chkJavaScript.Name = "chkJavaScript";
            chkJavaScript.Size = new Size(78, 19);
            chkJavaScript.TabIndex = 13;
            chkJavaScript.Text = "JavaScript";
            chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCplus
            // 
            chkCplus.AutoSize = true;
            chkCplus.Location = new Point(18, 58);
            chkCplus.Name = "chkCplus";
            chkCplus.Size = new Size(50, 19);
            chkCplus.TabIndex = 12;
            chkCplus.Text = "C++";
            chkCplus.UseVisualStyleBackColor = true;
            // 
            // chkc
            // 
            chkc.AutoSize = true;
            chkc.FlatStyle = FlatStyle.Flat;
            chkc.Location = new Point(18, 29);
            chkc.Name = "chkc";
            chkc.Size = new Size(38, 19);
            chkc.TabIndex = 11;
            chkc.Text = "C#";
            chkc.UseVisualStyleBackColor = true;
            // 
            // gbDetalleUsuario
            // 
            gbDetalleUsuario.Controls.Add(label5);
            gbDetalleUsuario.Controls.Add(mtbCUIT);
            gbDetalleUsuario.Controls.Add(nupEdad);
            gbDetalleUsuario.Controls.Add(txtDireccion);
            gbDetalleUsuario.Controls.Add(txtNombre);
            gbDetalleUsuario.Controls.Add(label3);
            gbDetalleUsuario.Controls.Add(label2);
            gbDetalleUsuario.Controls.Add(label1);
            gbDetalleUsuario.Location = new Point(12, 12);
            gbDetalleUsuario.Name = "gbDetalleUsuario";
            gbDetalleUsuario.Size = new Size(303, 162);
            gbDetalleUsuario.TabIndex = 21;
            gbDetalleUsuario.TabStop = false;
            gbDetalleUsuario.Text = "Detalle del Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 130);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "CUIT/L";
            // 
            // mtbCUIT
            // 
            mtbCUIT.Location = new Point(83, 124);
            mtbCUIT.Mask = "00-00000000-0";
            mtbCUIT.Name = "mtbCUIT";
            mtbCUIT.Size = new Size(177, 23);
            mtbCUIT.TabIndex = 6;
            // 
            // nupEdad
            // 
            nupEdad.Location = new Point(83, 93);
            nupEdad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nupEdad.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nupEdad.Name = "nupEdad";
            nupEdad.Size = new Size(177, 23);
            nupEdad.TabIndex = 5;
            nupEdad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(81, 62);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(177, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 101);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 68);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Dirección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 382);
            Controls.Add(btoIngresar);
            Controls.Add(label4);
            Controls.Add(lbPais);
            Controls.Add(gbGenero);
            Controls.Add(gbCurso);
            Controls.Add(gbDetalleUsuario);
            Name = "Registro";
            Text = "Registro";
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            gbCurso.ResumeLayout(false);
            gbCurso.PerformLayout();
            gbDetalleUsuario.ResumeLayout(false);
            gbDetalleUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btoIngresar;
        private Label label4;
        private ListBox lbPais;
        private GroupBox gbGenero;
        private RadioButton rbNoBinario;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private GroupBox gbCurso;
        private CheckBox chkJavaScript;
        private CheckBox chkCplus;
        private CheckBox chkc;
        private GroupBox gbDetalleUsuario;
        private Label label5;
        private MaskedTextBox mtbCUIT;
        private NumericUpDown nupEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
