namespace Speakids
{
    partial class Proceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso));
            this.pb_iniciar = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pb_info = new System.Windows.Forms.PictureBox();
            this.pb_salir = new System.Windows.Forms.PictureBox();
            this.lbl_ajustes = new System.Windows.Forms.Label();
            this.lbl_salir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_iniciar
            // 
            this.pb_iniciar.BackColor = System.Drawing.Color.Transparent;
            this.pb_iniciar.Image = global::Speakids.Properties.Resources.play;
            this.pb_iniciar.Location = new System.Drawing.Point(526, 428);
            this.pb_iniciar.Name = "pb_iniciar";
            this.pb_iniciar.Size = new System.Drawing.Size(122, 100);
            this.pb_iniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_iniciar.TabIndex = 0;
            this.pb_iniciar.TabStop = false;
            this.pb_iniciar.Click += new System.EventHandler(this.pb_iniciar_Click);
            this.pb_iniciar.MouseEnter += new System.EventHandler(this.pb_iniciar_MouseEnter);
            this.pb_iniciar.MouseLeave += new System.EventHandler(this.pb_iniciar_MouseLeave);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(357, 104);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(462, 297);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // pb_info
            // 
            this.pb_info.BackColor = System.Drawing.Color.Transparent;
            this.pb_info.Image = global::Speakids.Properties.Resources.info;
            this.pb_info.Location = new System.Drawing.Point(898, 94);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(96, 94);
            this.pb_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_info.TabIndex = 2;
            this.pb_info.TabStop = false;
            this.pb_info.Click += new System.EventHandler(this.pb_info_Click);
            this.pb_info.MouseEnter += new System.EventHandler(this.pb_info_MouseEnter);
            this.pb_info.MouseLeave += new System.EventHandler(this.pb_info_MouseLeave);
            // 
            // pb_salir
            // 
            this.pb_salir.BackColor = System.Drawing.Color.Transparent;
            this.pb_salir.Image = ((System.Drawing.Image)(resources.GetObject("pb_salir.Image")));
            this.pb_salir.Location = new System.Drawing.Point(152, 104);
            this.pb_salir.Name = "pb_salir";
            this.pb_salir.Size = new System.Drawing.Size(129, 81);
            this.pb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_salir.TabIndex = 3;
            this.pb_salir.TabStop = false;
            this.pb_salir.Click += new System.EventHandler(this.pb_salir_Click);
            this.pb_salir.MouseEnter += new System.EventHandler(this.pb_salir_MouseEnter);
            this.pb_salir.MouseLeave += new System.EventHandler(this.pb_salir_MouseLeave);
            // 
            // lbl_ajustes
            // 
            this.lbl_ajustes.AutoSize = true;
            this.lbl_ajustes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ajustes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajustes.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ajustes.Location = new System.Drawing.Point(922, 190);
            this.lbl_ajustes.Name = "lbl_ajustes";
            this.lbl_ajustes.Size = new System.Drawing.Size(0, 22);
            this.lbl_ajustes.TabIndex = 5;
            // 
            // lbl_salir
            // 
            this.lbl_salir.AutoSize = true;
            this.lbl_salir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salir.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_salir.Location = new System.Drawing.Point(186, 190);
            this.lbl_salir.Name = "lbl_salir";
            this.lbl_salir.Size = new System.Drawing.Size(0, 22);
            this.lbl_salir.TabIndex = 4;
            // 
            // Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1180, 721);
            this.Controls.Add(this.lbl_ajustes);
            this.Controls.Add(this.pb_iniciar);
            this.Controls.Add(this.lbl_salir);
            this.Controls.Add(this.pb_salir);
            this.Controls.Add(this.pb_info);
            this.Controls.Add(this.pb_logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.pb_iniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_iniciar;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.PictureBox pb_info;
        private System.Windows.Forms.PictureBox pb_salir;
        private System.Windows.Forms.Label lbl_ajustes;
        private System.Windows.Forms.Label lbl_salir;
    }
}

