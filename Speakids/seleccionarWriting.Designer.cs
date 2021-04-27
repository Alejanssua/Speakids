namespace Speakids
{
    partial class seleccionarWriting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seleccionarWriting));
            this.lbl_regresar = new System.Windows.Forms.Label();
            this.pb_topic = new System.Windows.Forms.PictureBox();
            this.pb_regresar = new System.Windows.Forms.PictureBox();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.pb_siguiente = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_topic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_siguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_regresar
            // 
            this.lbl_regresar.AutoSize = true;
            this.lbl_regresar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regresar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_regresar.Location = new System.Drawing.Point(171, 191);
            this.lbl_regresar.Name = "lbl_regresar";
            this.lbl_regresar.Size = new System.Drawing.Size(0, 22);
            this.lbl_regresar.TabIndex = 9;
            // 
            // pb_topic
            // 
            this.pb_topic.BackColor = System.Drawing.Color.Transparent;
            this.pb_topic.Location = new System.Drawing.Point(291, 75);
            this.pb_topic.Name = "pb_topic";
            this.pb_topic.Size = new System.Drawing.Size(567, 136);
            this.pb_topic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_topic.TabIndex = 8;
            this.pb_topic.TabStop = false;
            // 
            // pb_regresar
            // 
            this.pb_regresar.BackColor = System.Drawing.Color.Transparent;
            this.pb_regresar.Image = ((System.Drawing.Image)(resources.GetObject("pb_regresar.Image")));
            this.pb_regresar.Location = new System.Drawing.Point(175, 112);
            this.pb_regresar.Name = "pb_regresar";
            this.pb_regresar.Size = new System.Drawing.Size(85, 71);
            this.pb_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_regresar.TabIndex = 7;
            this.pb_regresar.TabStop = false;
            this.pb_regresar.Click += new System.EventHandler(this.pb_regresar_Click);
            this.pb_regresar.MouseEnter += new System.EventHandler(this.pb_regresar_MouseEnter);
            this.pb_regresar.MouseLeave += new System.EventHandler(this.pb_regresar_MouseLeave);
            // 
            // pb_imagen
            // 
            this.pb_imagen.BackColor = System.Drawing.Color.Transparent;
            this.pb_imagen.Location = new System.Drawing.Point(484, 229);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(182, 169);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagen.TabIndex = 10;
            this.pb_imagen.TabStop = false;
            // 
            // tb_texto
            // 
            this.tb_texto.BackColor = System.Drawing.Color.White;
            this.tb_texto.Location = new System.Drawing.Point(484, 414);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(182, 20);
            this.tb_texto.TabIndex = 12;
            this.tb_texto.TextChanged += new System.EventHandler(this.tb_texto_TextChanged);
            this.tb_texto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_texto_KeyDown);
            this.tb_texto.MouseEnter += new System.EventHandler(this.tb_texto_MouseEnter);
            // 
            // pb_siguiente
            // 
            this.pb_siguiente.BackColor = System.Drawing.Color.Transparent;
            this.pb_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("pb_siguiente.Image")));
            this.pb_siguiente.Location = new System.Drawing.Point(482, 447);
            this.pb_siguiente.Name = "pb_siguiente";
            this.pb_siguiente.Size = new System.Drawing.Size(182, 56);
            this.pb_siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_siguiente.TabIndex = 13;
            this.pb_siguiente.TabStop = false;
            this.pb_siguiente.Click += new System.EventHandler(this.pb_siguiente_Click);
            this.pb_siguiente.MouseEnter += new System.EventHandler(this.pb_siguiente_MouseEnter);
            this.pb_siguiente.MouseLeave += new System.EventHandler(this.pb_siguiente_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tiempo.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo.ForeColor = System.Drawing.Color.White;
            this.lbl_tiempo.Location = new System.Drawing.Point(906, 515);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(35, 60);
            this.lbl_tiempo.TabIndex = 20;
            this.lbl_tiempo.Text = ".";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_time.Location = new System.Drawing.Point(746, 516);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(176, 57);
            this.lbl_time.TabIndex = 24;
            this.lbl_time.Text = "Tiempo:";
            // 
            // seleccionarWriting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1171, 719);
            this.Controls.Add(this.lbl_tiempo);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pb_siguiente);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.pb_imagen);
            this.Controls.Add(this.lbl_regresar);
            this.Controls.Add(this.pb_topic);
            this.Controls.Add(this.pb_regresar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seleccionarWriting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "seleccionarWriting";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.seleccionarWriting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_topic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_siguiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_regresar;
        private System.Windows.Forms.PictureBox pb_topic;
        private System.Windows.Forms.PictureBox pb_regresar;
        private System.Windows.Forms.PictureBox pb_imagen;
        private System.Windows.Forms.TextBox tb_texto;
        private System.Windows.Forms.PictureBox pb_siguiente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.Label lbl_time;
    }
}