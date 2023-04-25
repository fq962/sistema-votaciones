namespace sistema_votaciones
{
    partial class frmLogin
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
            this.boton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.boton1.IconColor = System.Drawing.Color.Black;
            this.boton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.boton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton1.Location = new System.Drawing.Point(283, 167);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(129, 54);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "Hola";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton1);
            this.Name = "frmLogin";
            this.Text = "LOGIN";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton boton1;
    }
}

