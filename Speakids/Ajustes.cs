using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speakids
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
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

        int seg;
        private void pb_regresar_Click(object sender, EventArgs e)
        {
            if (nud_tiempo.Value==0)
            {
                seg = 0;
            }
            else
            {
                seg = Convert.ToInt32(nud_tiempo.Value);
            }
            string formulario = "";
            Informacion informacion = new Informacion(seg);
            Proceso iniciar = new Proceso(seg);
            Salir salir = new Salir(formulario,seg);
            Conocimiento_Ingles mostrarMenu = new Conocimiento_Ingles(seg);
            mostrarMenu.Show();
            this.Close();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            lbl_descripcion1.Text = "El modo Listening tiene un\n  total de 10 puntos, para\n completarlo debes elegir\nla imagen que corresponde\n al audio, antes de que se\n        acabe el tiempo.";
            lbl_descripcion2.Text = "El modo Vocabulary no tiene\npuntos, en este modo puedes\n  ver todas las palabras del\n juego y te pueden ayudar a\n                estudiar";
            lbl_descripcion3.Text = "  El modo Writing tiene un\n   total de 10 puntos, para\n completarlo debes escribir\nla palabra que corresponde\n a la imagen, antes de que\n       se acabe el tiempo";
        }
    }
}
