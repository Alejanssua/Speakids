namespace Speakids
{
    partial class Informacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_regresar = new System.Windows.Forms.Label();
            this.pb_regresar = new System.Windows.Forms.PictureBox();
            this.lbl_informacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Speakids.Properties.Resources.informacion;
            this.pictureBox1.Location = new System.Drawing.Point(356, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_regresar
            // 
            this.lbl_regresar.AutoSize = true;
            this.lbl_regresar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regresar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_regresar.Location = new System.Drawing.Point(180, 175);
            this.lbl_regresar.Name = "lbl_regresar";
            this.lbl_regresar.Size = new System.Drawing.Size(0, 22);
            this.lbl_regresar.TabIndex = 8;
            // 
            // pb_regresar
            // 
            this.pb_regresar.BackColor = System.Drawing.Color.Transparent;
            this.pb_regresar.Image = ((System.Drawing.Image)(resources.GetObject("pb_regresar.Image")));
            this.pb_regresar.Location = new System.Drawing.Point(184, 96);
            this.pb_regresar.Name = "pb_regresar";
            this.pb_regresar.Size = new System.Drawing.Size(85, 71);
            this.pb_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_regresar.TabIndex = 7;
            this.pb_regresar.TabStop = false;
            this.pb_regresar.Click += new System.EventHandler(this.pb_regresar_Click);
            this.pb_regresar.MouseEnter += new System.EventHandler(this.pb_regresar_MouseEnter);
            this.pb_regresar.MouseLeave += new System.EventHandler(this.pb_regresar_MouseLeave);
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.AutoSize = true;
            this.lbl_informacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_informacion.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacion.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_informacion.Location = new System.Drawing.Point(190, 230);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(27, 41);
            this.lbl_informacion.TabIndex = 25;
            this.lbl_informacion.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(472, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 41);
            this.label1.TabIndex = 26;
            this.label1.Text = "Speakids v1.0.0";
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Speakids.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1164, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_informacion);
            this.Controls.Add(this.lbl_regresar);
            this.Controls.Add(this.pb_regresar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "informacion";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_regresar;
        private System.Windows.Forms.PictureBox pb_regresar;
        private System.Windows.Forms.Label lbl_informacion;
        private System.Windows.Forms.Label label1;
    }
}