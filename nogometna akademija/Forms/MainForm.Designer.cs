namespace nogometna_akademija.UI.Forms
{
    partial class MainForm
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
            this.ulogiranlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ulogiranlbl
            // 
            this.ulogiranlbl.AutoSize = true;
            this.ulogiranlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulogiranlbl.Location = new System.Drawing.Point(247, 122);
            this.ulogiranlbl.Name = "ulogiranlbl";
            this.ulogiranlbl.Size = new System.Drawing.Size(179, 39);
            this.ulogiranlbl.TabIndex = 0;
            this.ulogiranlbl.Text = "Ulogiran si";
            this.ulogiranlbl.Click += new System.EventHandler(this.ulogiranlbl_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ulogiranlbl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ulogiranlbl;
    }
}