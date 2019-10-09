namespace _01_HolaMundoWindowsForms_CSharp
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnsaludar = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblerrorape = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(138, 52);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(86, 55);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = " Nombre:";
            this.lblnombre.Click += new System.EventHandler(this.lblnombre_Click);
            // 
            // btnsaludar
            // 
            this.btnsaludar.Location = new System.Drawing.Point(138, 168);
            this.btnsaludar.Name = "btnsaludar";
            this.btnsaludar.Size = new System.Drawing.Size(75, 23);
            this.btnsaludar.TabIndex = 3;
            this.btnsaludar.Text = "Saludar";
            this.btnsaludar.UseVisualStyleBackColor = true;
            this.btnsaludar.Click += new System.EventHandler(this.btnsaludar_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(245, 58);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 3;
            this.lblerror.Click += new System.EventHandler(this.lblerror_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(89, 93);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(138, 90);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 1;
            // 
            // lblerrorape
            // 
            this.lblerrorape.AutoSize = true;
            this.lblerrorape.ForeColor = System.Drawing.Color.Red;
            this.lblerrorape.Location = new System.Drawing.Point(248, 96);
            this.lblerrorape.Name = "lblerrorape";
            this.lblerrorape.Size = new System.Drawing.Size(0, 13);
            this.lblerrorape.TabIndex = 14;
            // 
            // FormularioPrincipal
            // 
            this.AcceptButton = this.btnsaludar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblerrorape);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnsaludar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnombre);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnsaludar;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblerrorape;
    }
}

