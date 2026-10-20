namespace _3NLIDTS_JoséPeña_07._0
{
    partial class Form1
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
            this.BtnEncender = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEncender
            // 
            this.BtnEncender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEncender.Location = new System.Drawing.Point(312, 129);
            this.BtnEncender.Name = "BtnEncender";
            this.BtnEncender.Size = new System.Drawing.Size(161, 54);
            this.BtnEncender.TabIndex = 0;
            this.BtnEncender.Text = "Encender LED";
            this.BtnEncender.UseVisualStyleBackColor = false;
            this.BtnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.Red;
            this.BtnApagar.Location = new System.Drawing.Point(312, 247);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(161, 54);
            this.BtnApagar.TabIndex = 1;
            this.BtnApagar.Text = "Apagar LED";
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BtnEncender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEncender;
        private System.Windows.Forms.Button BtnApagar;
    }
}

