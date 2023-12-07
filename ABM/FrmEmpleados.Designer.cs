namespace ABM
{
    partial class FrmEmpleados
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtLegajo = new TextBox();
            txtSueldo = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtSector = new TextBox();
            lblLegajo = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblSector = new Label();
            lblSueldo = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(24, 210);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(124, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(93, 19);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(125, 27);
            txtLegajo.TabIndex = 2;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(93, 151);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(125, 27);
            txtSueldo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(93, 85);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 5;
            // 
            // txtSector
            // 
            txtSector.Location = new Point(93, 118);
            txtSector.Name = "txtSector";
            txtSector.Size = new Size(125, 27);
            txtSector.TabIndex = 6;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(24, 26);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(54, 20);
            lblLegajo.TabIndex = 7;
            lblLegajo.Text = "Legajo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(24, 92);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Location = new Point(24, 125);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(51, 20);
            lblSector.TabIndex = 10;
            lblSector.Text = "Sector";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(24, 158);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(55, 20);
            lblSueldo.TabIndex = 11;
            lblSueldo.Text = "Sueldo";
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 266);
            Controls.Add(lblSueldo);
            Controls.Add(lblSector);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblLegajo);
            Controls.Add(txtSector);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtSueldo);
            Controls.Add(txtLegajo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FrmEmpleados";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtLegajo;
        private TextBox txtSueldo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtSector;
        private Label lblLegajo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblSector;
        private Label lblSueldo;
    }
}