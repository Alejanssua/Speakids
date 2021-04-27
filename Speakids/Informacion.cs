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
    public partial class Informacion : Form
    {
        int seg;
        public Informacion(int time)
        {
            InitializeComponent();
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
            Proceso mostrarInicio = new Proceso(seg);
            mostrarInicio.Show();
            this.Close();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            lbl_informacion.Text = "Speakids es una aplicacion que ayuda en el aprendizaje\ndel idioma Ingles mediate el uso de imagenes y audios,\n     fue desarrollada por estudiantes de la carrera de\nIngenieria de Software de la Universidad de las Fuerzas\n  Armadas ESPE. Lanzamiento Oficial: 27/Enero/2020";
        }
    }
}
