namespace Speakids
{
    partial class Salir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salir));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_salir = new System.Windows.Forms.Label();
            this.lbl_si = new System.Windows.Forms.Label();
            this.lbl_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl1.Location = new System.Drawing.Point(201, 194);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 48);
            this.lbl1.TabIndex = 6;
            // 
            // lbl_salir
            // 
            this.lbl_salir.AutoSize = true;
            this.lbl_salir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salir.Font = new System.Drawing.Font("Bernard MT Condensed", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salir.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_salir.Location = new System.Drawing.Point(241, 181);
            this.lbl_salir.Name = "lbl_salir";
            this.lbl_salir.Size = new System.Drawing.Size(675, 64);
            this.lbl_salir.TabIndex = 21;
            this.lbl_salir.Text = "¿Estás seguro que quieres salir?";
            // 
            // lbl_si
            // 
            this.lbl_si.AutoSize = true;
            this.lbl_si.BackColor = System.Drawing.Color.Transparent;
            this.lbl_si.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_si.ForeColor = System.Drawing.Color.White;
            this.lbl_si.Location = new System.Drawing.Point(406, 329);
            this.lbl_si.Name = "lbl_si";
            this.lbl_si.Size = new System.Drawing.Size(112, 114);
            this.lbl_si.TabIndex = 22;
            this.lbl_si.Text = "SI";
            this.lbl_si.Click += new System.EventHandler(this.lbl_si_Click);
            this.lbl_si.MouseEnter += new System.EventHandler(this.lbl_si_MouseEnter);
            this.lbl_si.MouseLeave += new System.EventHandler(this.lbl_si_MouseLeave);
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.BackColor = System.Drawing.Color.Transparent;
            this.lbl_no.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no.ForeColor = System.Drawing.Color.White;
            this.lbl_no.Location = new System.Drawing.Point(616, 329);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(144, 114);
            this.lbl_no.TabIndex = 23;
            this.lbl_no.Text = "NO";
            this.lbl_no.Click += new System.EventHandler(this.lbl_no_Click);
            this.lbl_no.MouseEnter += new System.EventHandler(this.lbl_no_MouseEnter);
            this.lbl_no.MouseLeave += new System.EventHandler(this.lbl_no_MouseLeave);
            // 
            // Salir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1171, 719);
            this.Controls.Add(this.lbl_no);
            this.Controls.Add(this.lbl_si);
            this.Controls.Add(this.lbl_salir);
            this.Controls.Add(this.lbl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salir";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_salir;
        private System.Windows.Forms.Label lbl_si;
        private System.Windows.Forms.Label lbl_no;
    }
}