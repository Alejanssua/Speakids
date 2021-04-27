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
    public partial class MostrarResultados : Form
    {
        int contador;
        int seg;
        public MostrarResultados(int cont, int time)
        {
            InitializeComponent();
            contador = cont;
            seg = time;
        }

        private void pb_regresar_MouseEnter(object sender, EventArgs e)
        {
            pb_regresar.Size = new System.Drawing.Size(96, 80);
            lbl_regresar.Text = "REGRESAR";
        }

        private void pb_regresar_MouseLeave(object sender, EventArgs e)
        {
            pb_regresar.Size = new System.Drawing.Size(85, 71);
            lbl_regresar.Text = "";
        }
        
        private void pb_regresar_Click(object sender, EventArgs e)
        {
            Conocimiento_Ingles mostrarMenu = new Conocimiento_Ingles(seg);
            mostrarMenu.Show();
            this.Close();
        }

        private void MostrarResultados_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer();
            switch (contador)
            {
                case 0:
                    sonido.Stream = Properties.Resources.losser;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.bad;
                    pb_puntaje.Image = Properties.Resources.estrella0;
                    lbl_descripcion.Text = "Deberias mejorar un poco más.";
                    break;
                case 1:
                    sonido.Stream = Properties.Resources.losser;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.bad;
                    pb_puntaje.Image = Properties.Resources.estrella1;
                    lbl_descripcion.Text = "Deberias mejorar un poco más.";
                    break;
                case 2:
                    sonido.Stream = Properties.Resources.losser;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.bad;
                    pb_puntaje.Image = Properties.Resources.estrella2;
                    lbl_descripcion.Text = "Deberias mejorar un poco más.";
                    break;
                case 3:
                    sonido.Stream = Properties.Resources.losser;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.bad;
                    pb_puntaje.Image = Properties.Resources.estrella3;
                    lbl_descripcion.Text = "Deberias mejorar un poco más.";
                    break;
                case 4:
                    sonido.Stream = Properties.Resources.losser;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.bad;
                    pb_puntaje.Image = Properties.Resources.estrella4;
                    lbl_descripcion.Text = "Deberias mejorar un poco más.";
                    break;
                case 5:
                    sonido.Stream = Properties.Resources.losser;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.bad;
                    pb_puntaje.Image = Properties.Resources.estrella5;
                    lbl_descripcion.Text = "Deberias mejorar un poco más.";
                    break;
                case 6:
                    sonido.Stream = Properties.Resources.losser;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.bad;
                    pb_puntaje.Image = Properties.Resources.estrella6;
                    lbl_descripcion.Text = "Deberias mejorar un poco más.";
                    break;
                case 7:
                    sonido.Stream = Properties.Resources.winner;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.good;
                    pb_puntaje.Image = Properties.Resources.estrella7;
                    lbl_descripcion.Text = "Buen trabajo! Sigue así.";
                    break;
                case 8:
                    sonido.Stream = Properties.Resources.winner;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.good;
                    pb_puntaje.Image = Properties.Resources.estrella8;
                    lbl_descripcion.Text = "Buen trabajo! Sigue así.";
                    break;
                case 9:
                    sonido.Stream = Properties.Resources.winner;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.good;
                    pb_puntaje.Image = Properties.Resources.estrella9;
                    lbl_descripcion.Text = "Buen trabajo! Sigue así.";
                    break;
                case 10:
                    sonido.Stream = Properties.Resources.winner;
                    sonido.Play();
                    pb_mano.Image = Properties.Resources.good;
                    pb_puntaje.Image = Properties.Resources.estrella10;
                    lbl_descripcion.Text = "Excelente! puntuación perfecta.";
                    break;
            }
        }
    }
}
