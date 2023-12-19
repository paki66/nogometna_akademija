namespace nogometna_akademija.UI.Forms
{
    partial class LoginForm
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
            this.naslovlbl = new System.Windows.Forms.Label();
            this.lozinkalbl = new System.Windows.Forms.Label();
            this.imelbl = new System.Windows.Forms.Label();
            this.imetxt = new System.Windows.Forms.TextBox();
            this.lozinkatxt = new System.Windows.Forms.TextBox();
            this.prijavabtn = new System.Windows.Forms.Button();
            this.odustanibtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naslovlbl
            // 
            this.naslovlbl.AutoSize = true;
            this.naslovlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovlbl.Location = new System.Drawing.Point(75, 39);
            this.naslovlbl.Name = "naslovlbl";
            this.naslovlbl.Size = new System.Drawing.Size(650, 46);
            this.naslovlbl.TabIndex = 0;
            this.naslovlbl.Text = "Dobrodosli u nogometnu akademiju";
            // 
            // lozinkalbl
            // 
            this.lozinkalbl.AutoSize = true;
            this.lozinkalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkalbl.Location = new System.Drawing.Point(154, 200);
            this.lozinkalbl.Name = "lozinkalbl";
            this.lozinkalbl.Size = new System.Drawing.Size(112, 32);
            this.lozinkalbl.TabIndex = 1;
            this.lozinkalbl.Text = "lozinka:";
            // 
            // imelbl
            // 
            this.imelbl.AutoSize = true;
            this.imelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imelbl.Location = new System.Drawing.Point(178, 140);
            this.imelbl.Name = "imelbl";
            this.imelbl.Size = new System.Drawing.Size(68, 32);
            this.imelbl.TabIndex = 2;
            this.imelbl.Text = "ime:";
            // 
            // imetxt
            // 
            this.imetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imetxt.Location = new System.Drawing.Point(382, 150);
            this.imetxt.Name = "imetxt";
            this.imetxt.Size = new System.Drawing.Size(162, 38);
            this.imetxt.TabIndex = 3;
            this.imetxt.TextChanged += new System.EventHandler(this.imetxt_TextChanged);
            // 
            // lozinkatxt
            // 
            this.lozinkatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkatxt.Location = new System.Drawing.Point(382, 200);
            this.lozinkatxt.Name = "lozinkatxt";
            this.lozinkatxt.PasswordChar = '*';
            this.lozinkatxt.Size = new System.Drawing.Size(162, 38);
            this.lozinkatxt.TabIndex = 4;
            // 
            // prijavabtn
            // 
            this.prijavabtn.Location = new System.Drawing.Point(170, 329);
            this.prijavabtn.Name = "prijavabtn";
            this.prijavabtn.Size = new System.Drawing.Size(75, 23);
            this.prijavabtn.TabIndex = 5;
            this.prijavabtn.Text = "Prijava";
            this.prijavabtn.UseVisualStyleBackColor = true;
            // 
            // odustanibtn
            // 
            this.odustanibtn.Location = new System.Drawing.Point(488, 329);
            this.odustanibtn.Name = "odustanibtn";
            this.odustanibtn.Size = new System.Drawing.Size(75, 23);
            this.odustanibtn.TabIndex = 6;
            this.odustanibtn.Text = "odustani";
            this.odustanibtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odustanibtn);
            this.Controls.Add(this.prijavabtn);
            this.Controls.Add(this.lozinkatxt);
            this.Controls.Add(this.imetxt);
            this.Controls.Add(this.imelbl);
            this.Controls.Add(this.lozinkalbl);
            this.Controls.Add(this.naslovlbl);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslovlbl;
        private System.Windows.Forms.Label lozinkalbl;
        private System.Windows.Forms.Label imelbl;
        private System.Windows.Forms.TextBox imetxt;
        private System.Windows.Forms.TextBox lozinkatxt;
        private System.Windows.Forms.Button prijavabtn;
        private System.Windows.Forms.Button odustanibtn;
    }
}