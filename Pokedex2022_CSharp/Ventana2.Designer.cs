namespace Pokedex2022_CSharp
{
    partial class Ventana2
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
            this.cajaDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cajaDescripcion
            // 
            this.cajaDescripcion.Location = new System.Drawing.Point(128, 99);
            this.cajaDescripcion.Name = "cajaDescripcion";
            this.cajaDescripcion.Size = new System.Drawing.Size(184, 139);
            this.cajaDescripcion.TabIndex = 0;
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 470);
            this.Controls.Add(this.cajaDescripcion);
            this.Name = "Ventana2";
            this.Text = "Ventana2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cajaDescripcion;
    }
}