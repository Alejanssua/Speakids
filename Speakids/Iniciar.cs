using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Speakids
{
    public partial class Proceso : Form
    {
        int seg;
        public Proceso(int time)
        {
            InitializeComponent();
            seg = time;
        }

        public void Iniciar()
        {
            pb_iniciar_Click(null, null);
            pb_iniciar_MouseEnter(null, null);
            pb_iniciar_MouseLeave(null, null);
        }

        public void Ajustes()
        {
            pb_info_Click(null, null);
            pb_info_MouseEnter(null, null);
            pb_info_MouseLeave(null, null);
        }

        public void Salir()
        {
            pb_salir_Click(null, null);
            pb_salir_MouseEnter(null, null);
            pb_salir_MouseLeave(null, null);
        }

        //---------------------Inciar()--------------------------------------------
        SoundPlayer sonido = new SoundPlayer();
        private void pb_iniciar_Click(object sender, EventArgs e)
        {
            sonido.Stream = Properties.Resources.welcome;
            sonido.Play();
            Conocimiento_Ingles mostrarMenu = new Conocimiento_Ingles(seg);
            mostrarMenu.Show();
            this.Close();
        }
        private void pb_iniciar_MouseEnter(object sender, EventArgs e)
        {
            pb_iniciar.Size = new System.Drawing.Size(132, 110);
        }

        private void pb_iniciar_MouseLeave(object sender, EventArgs e)
        {
            pb_iniciar.Size = new System.Drawing.Size(122, 100);
        }
        //---------------------Ajustes()--------------------------------------------
        private void pb_info_MouseEnter(object sender, EventArgs e)
        {
            pb_info.Size = new System.Drawing.Size(104, 98);
            lbl_ajustes.Text = "INFO";
        }
        private void pb_info_MouseLeave(object sender, EventArgs e)
        {
            pb_info.Size = new System.Drawing.Size(94, 88);
            lbl_ajustes.Text = "";
        }
        private void pb_info_Click(object sender, EventArgs e)
        {
            Informacion informacion = new Informacion(seg);
            informacion.Show();
            this.Close();
        }
        //---------------------Salir()--------------------------------------------
        private void pb_salir_MouseEnter(object sender, EventArgs e)
        {
            pb_salir.Size = new System.Drawing.Size(140, 90);
            lbl_salir.Text = "SALIR";
        }

        private void pb_salir_MouseLeave(object sender, EventArgs e)
        {
            pb_salir.Size = new System.Drawing.Size(129, 81);
            lbl_salir.Text = "";
        }


        private void pb_salir_Click(object sender, EventArgs e)
        {
            string formulario = "iniciar";
            Salir salir = new Salir(formulario, seg);
            salir.Show();
            this.Close();
        }
    }
}
