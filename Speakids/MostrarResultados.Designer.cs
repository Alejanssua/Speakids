namespace Speakids
{
    partial class MostrarResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarResultados));
            this.pb_regresar = new System.Windows.Forms.PictureBox();
            this.pb_topic = new System.Windows.Forms.PictureBox();
            this.lbl_regresar = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.pb_mano = new System.Windows.Forms.PictureBox();
            this.pb_puntaje = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_topic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_puntaje)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_regresar
            // 
            this.pb_regresar.BackColor = System.Drawing.Color.Transparent;
            this.pb_regresar.Image = ((System.Drawing.Image)(resources.GetObject("pb_regresar.Image")));
            this.pb_regresar.Location = new System.Drawing.Point(182, 112);
            this.pb_regresar.Name = "pb_regresar";
            this.pb_regresar.Size = new System.Drawing.Size(85, 71);
            this.pb_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_regresar.TabIndex = 16;
            this.pb_regresar.TabStop = false;
            this.pb_regresar.Click += new System.EventHandler(this.pb_regresar_Click);
            this.pb_regresar.MouseEnter += new System.EventHandler(this.pb_regresar_MouseEnter);
            this.pb_regresar.MouseLeave += new System.EventHandler(this.pb_regresar_MouseLeave);
            // 
            // pb_topic
            // 
            this.pb_topic.BackColor = System.Drawing.Color.Transparent;
            this.pb_topic.Image = ((System.Drawing.Image)(resources.GetObject("pb_topic.Image")));
            this.pb_topic.Location = new System.Drawing.Point(303, 74);
            this.pb_topic.Name = "pb_topic";
            this.pb_topic.Size = new System.Drawing.Size(567, 136);
            this.pb_topic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_topic.TabIndex = 17;
            this.pb_topic.TabStop = false;
            // 
            // lbl_regresar
            // 
            this.lbl_regresar.AutoSize = true;
            this.lbl_regresar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regresar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_regresar.Location = new System.Drawing.Point(178, 187);
            this.lbl_regresar.Name = "lbl_regresar";
            this.lbl_regresar.Size = new System.Drawing.Size(0, 22);
            this.lbl_regresar.TabIndex = 19;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_descripcion.Location = new System.Drawing.Point(391, 512);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(465, 57);
            this.lbl_descripcion.TabIndex = 20;
            this.lbl_descripcion.Text = "Buen trabajo! Sigue así.";
            // 
            // pb_mano
            // 
            this.pb_mano.BackColor = System.Drawing.Color.Transparent;
            this.pb_mano.Image = global::Speakids.Properties.Resources.good;
            this.pb_mano.Location = new System.Drawing.Point(151, 209);
            this.pb_mano.Name = "pb_mano";
            this.pb_mano.Size = new System.Drawing.Size(508, 286);
            this.pb_mano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_mano.TabIndex = 22;
            this.pb_mano.TabStop = false;
            // 
            // pb_puntaje
            // 
            this.pb_puntaje.BackColor = System.Drawing.Color.Transparent;
            this.pb_puntaje.Image = ((System.Drawing.Image)(resources.GetObject("pb_puntaje.Image")));
            this.pb_puntaje.Location = new System.Drawing.Point(708, 232);
            this.pb_puntaje.Name = "pb_puntaje";
            this.pb_puntaje.Size = new System.Drawing.Size(251, 243);
            this.pb_puntaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_puntaje.TabIndex = 23;
            this.pb_puntaje.TabStop = false;
            // 
            // MostrarResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1180, 721);
            this.Controls.Add(this.pb_puntaje);
            this.Controls.Add(this.pb_mano);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_regresar);
            this.Controls.Add(this.pb_topic);
            this.Controls.Add(this.pb_regresar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarResultados";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.MostrarResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_topic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_puntaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_regresar;
        private System.Windows.Forms.PictureBox pb_topic;
        private System.Windows.Forms.Label lbl_regresar;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.PictureBox pb_mano;
        private System.Windows.Forms.PictureBox pb_puntaje;
    }
}