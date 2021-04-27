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
    public partial class Salir : Form
    {
        string formulario;
        int seg;
        public Salir(string form, int time)
        {
            InitializeComponent();
            formulario = form;
            seg = time;
        }

        private void lbl_si_MouseEnter(object sender, EventArgs e)
        {
            lbl_si.Font = new Font("Bernard MT Condensed", 82F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lbl_si_MouseLeave(object sender, EventArgs e)
        {
            lbl_si.Font = new Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lbl_si_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_no_Click(object sender, EventArgs e)
        {
            if (formulario == "iniciar")
            {
                Proceso iniciarAplicattivo = new Proceso(seg);
                iniciarAplicattivo.Show();
                this.Close();
            }
            if (formulario == "Mostrar Menu")
            {
                Conocimiento_Ingles mostrarMenu = new Conocimiento_Ingles(seg);
                mostrarMenu.Show();
                this.Close();
            }
        }

        private void lbl_no_MouseEnter(object sender, EventArgs e)
        {
            lbl_no.Font = new Font("Bernard MT Condensed", 82F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lbl_no_MouseLeave(object sender, EventArgs e)
        {
            lbl_no.Font = new Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
