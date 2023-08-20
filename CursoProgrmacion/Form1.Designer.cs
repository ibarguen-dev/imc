namespace CursoProgrmacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNombre = new Label();
            lblAltura = new Label();
            lblPeso = new Label();
            txtNombre = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            btnConfirmar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(23, 65);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(26, 118);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(35, 15);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(97, 70);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 4;
            txtAltura.KeyPress += txtAltura_KeyPress;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(97, 118);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 5;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(87, 200);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(42, 166);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 319);
            Controls.Add(lblResultado);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtNombre);
            Controls.Add(lblPeso);
            Controls.Add(lblAltura);
            Controls.Add(lblNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "IMC";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblAltura;
        private Label lblPeso;
        private TextBox txtNombre;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Button btnConfirmar;
        private Label lblResultado;
    }
}