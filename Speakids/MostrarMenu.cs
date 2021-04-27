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
    public partial class Conocimiento_Ingles : Form
    {
        int seg;
        public Conocimiento_Ingles(int time)
        {
            InitializeComponent();
            seg = time;
        }

        public void MostrarMenu()
        {
            pb_ajustes_MouseEnter(null, null);
            pb_ajustes_MouseLeave(null, null);
            pb_salir_MouseEnter(null, null);
            pb_salir_MouseLeave(null, null);
            pb_salir_Click(null, null);
            pb_ajustes_Click(null, null);
        }

        public void Seleccionartopic()
        {
            pb_verbs_MouseEnter(null, null);
            pb_verbs_MouseLeave(null, null);
            pb_transport_MouseEnter(null, null);
            pb_transport_MouseLeave(null, null);
            pb_sports_MouseEnter(null, null);
            pb_sports_MouseLeave(null, null);
            pb_clothes_MouseEnter(null, null);
            pb_clothes_MouseLeave(null, null);
            pb_food_MouseEnter(null, null);
            pb_food_MouseLeave(null, null);
            pb_professions_MouseEnter(null, null);
            pb_professions_MouseLeave(null, null);
            pb_animals_MouseLeave(null, null);
            pb_animals_MouseLeave(null, null);
        }

            private void pb_ajustes_MouseEnter(object sender, EventArgs e)
        {
            pb_ajustes.Size = new System.Drawing.Size(134, 76);
            lbl_ajustes.Text = "AJUSTES";
        }
        private void pb_ajustes_MouseLeave(object sender, EventArgs e)
        {
            pb_ajustes.Size = new System.Drawing.Size(123, 67);
            lbl_ajustes.Text = "";
        }
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
            string formulario = "Mostrar Menu";
            Salir salir = new Salir(formulario, seg);
            salir.Show();
            this.Close();
        }

        private void pb_ajustes_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
            this.Close();
        }

        private void pb_verbs_MouseEnter(object sender, EventArgs e)
        {
            pb_verbs.Size = new System.Drawing.Size(131, 120);
        }

        private void pb_verbs_MouseLeave(object sender, EventArgs e)
        {
            pb_verbs.Size = new System.Drawing.Size(121, 110);
        }

        private void pb_transport_MouseEnter(object sender, EventArgs e)
        {
            pb_transport.Size = new System.Drawing.Size(172, 108);
        }

        private void pb_transport_MouseLeave(object sender, EventArgs e)
        {
            pb_transport.Size = new System.Drawing.Size(162, 98);
        }

        private void pb_sports_MouseEnter(object sender, EventArgs e)
        {
            pb_sports.Size = new System.Drawing.Size(138, 116);
        }

        private void pb_sports_MouseLeave(object sender, EventArgs e)
        {
            pb_sports.Size = new System.Drawing.Size(128, 106);
        }

        private void pb_clothes_MouseEnter(object sender, EventArgs e)
        {
            pb_clothes.Size = new System.Drawing.Size(153, 115);
        }

        private void pb_clothes_MouseLeave(object sender, EventArgs e)
        {
            pb_clothes.Size = new System.Drawing.Size(143, 105);
        }

        private void pb_food_MouseEnter(object sender, EventArgs e)
        {
            pb_food.Size = new System.Drawing.Size(199, 129);
        }

        private void pb_food_MouseLeave(object sender, EventArgs e)
        {
            pb_food.Size = new System.Drawing.Size(189, 119);
        }

        private void pb_professions_MouseEnter(object sender, EventArgs e)
        {
            pb_professions.Size = new System.Drawing.Size(198, 150);
        }

        private void pb_professions_MouseLeave(object sender, EventArgs e)
        {
            pb_professions.Size = new System.Drawing.Size(188, 140);
        }

        private void pb_animals_MouseEnter(object sender, EventArgs e)
        {
            pb_animals.Size = new System.Drawing.Size(187, 129);
        }

        private void pb_animals_MouseLeave(object sender, EventArgs e)
        {
            pb_animals.Size = new System.Drawing.Size(177, 119);
        }
        int num = 0;
        string seleccionado = "listening";
        private void pb_listening_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                pb_listening.Image = Properties.Resources.listening_select;
                num = 1;
            }
            else
            {
                pb_listening.Image = Properties.Resources.listening_select;
                pb_writing.Image = Properties.Resources.writing;
                pb_vocabulary.Image = Properties.Resources.vocabulary;
            }
            seleccionado = "listening";
        }

        private void pb_vocabulary_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                pb_vocabulary.Image = Properties.Resources.vocabulary_select;
                pb_listening.Image = Properties.Resources.listening;
                num = 1;
            }
            else
            {
                pb_vocabulary.Image = Properties.Resources.vocabulary_select;
                pb_writing.Image = Properties.Resources.writing;
                pb_listening.Image = Properties.Resources.listening;
            }
            seleccionado = "vocabulary";
        }

        private void pb_writing_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                pb_writing.Image = Properties.Resources.writing_select;
                pb_listening.Image = Properties.Resources.listening;
                num = 1;
            }
            else
            {
                pb_writing.Image = Properties.Resources.writing_select;
                pb_listening.Image = Properties.Resources.listening;
                pb_vocabulary.Image = Properties.Resources.vocabulary;
            }
            seleccionado = "writing";
        }
        
        private void pb_verbs_Click(object sender, EventArgs e)
        {
            string topic = "verbs";
            switch (seleccionado)
            {
                case "listening":
                    {
                        seleccionarListening listening = new seleccionarListening(topic,seg);
                        listening.Show();
                        this.Close();
                    }
                    break;
                case "vocabulary":
                    {
                        seleccionarVocabulary vocabulary = new seleccionarVocabulary(topic,seg);
                        vocabulary.Show();
                        this.Close();
                    }
                    break;
                case "writing":
                    {
                        seleccionarWriting writing = new seleccionarWriting(topic,seg);
                        writing.Show();
                        this.Close();
                    }
                    break;
            }
        }

        private void pb_transport_Click(object sender, EventArgs e)
        {
            string topic = "transport";
            switch (seleccionado)
            {
                case "listening":
                    {
                        seleccionarListening listening = new seleccionarListening(topic,seg);
                        listening.Show();
                        this.Close();
                    }
                    break;
                case "vocabulary":
                    {
                        seleccionarVocabulary vocabulary = new seleccionarVocabulary(topic,seg);
                        vocabulary.Show();
                        this.Close();
                    }
                    break;
                case "writing":
                    {
                        seleccionarWriting writing = new seleccionarWriting(topic,seg);
                        writing.Show();
                        this.Close();
                    }
                    break;
            }
        }

        private void pb_sports_Click(object sender, EventArgs e)
        {
            string topic = "sports";
            switch (seleccionado)
            {
                case "listening":
                    {
                        seleccionarListening listening = new seleccionarListening(topic,seg);
                        listening.Show();
                        this.Close();
                    }
                    break;
                case "vocabulary":
                    {
                        seleccionarVocabulary vocabulary = new seleccionarVocabulary(topic,seg);
                        vocabulary.Show();
                        this.Close();
                    }
                    break;
                case "writing":
                    {
                        seleccionarWriting writing = new seleccionarWriting(topic,seg);
                        writing.Show();
                        this.Close();
                    }
                    break;
            }

        }

        private void pb_clothes_Click(object sender, EventArgs e)
        {
            string topic = "clothes";
            switch (seleccionado)
            {
                case "listening":
                    {
                        seleccionarListening listening = new seleccionarListening(topic,seg);
                        listening.Show();
                        this.Close();
                    }
                    break;
                case "vocabulary":
                    {
                        seleccionarVocabulary vocabulary = new seleccionarVocabulary(topic,seg);
                        vocabulary.Show();
                        this.Close();
                    }
                    break;
                case "writing":
                    {
                        seleccionarWriting writing = new seleccionarWriting(topic,seg);
                        writing.Show();
                        this.Close();
                    }
                    break;
            }
        }

        private void pb_food_Click(object sender, EventArgs e)
        {
            string topic = "food";
            switch (seleccionado)
            {
                case "listening":
                    {
                        seleccionarListening listening = new seleccionarListening(topic,seg);
                        listening.Show();
                        this.Close();
                    }
                    break;
                case "vocabulary":
                    {
                        seleccionarVocabulary vocabulary = new seleccionarVocabulary(topic,seg);
                        vocabulary.Show();
                        this.Close();
                    }
                    break;
                case "writing":
                    {
                        seleccionarWriting writing = new seleccionarWriting(topic,seg);
                        writing.Show();
                        this.Close();
                    }
                    break;
            }
        }

        private void pb_professions_Click(object sender, EventArgs e)
        {
            string topic = "professions";
            switch (seleccionado)
            {
                case "listening":
                    {
                        seleccionarListening listening = new seleccionarListening(topic,seg);
                        listening.Show();
                        this.Close();
                    }
                    break;
                case "vocabulary":
                    {
                        seleccionarVocabulary vocabulary = new seleccionarVocabulary(topic,seg);
                        vocabulary.Show();
                        this.Close();
                    }
                    break;
                case "writing":
                    {
                        seleccionarWriting writing = new seleccionarWriting(topic,seg);
                        writing.Show();
                        this.Close();
                    }
                    break;
            }
        }

        private void pb_animals_Click(object sender, EventArgs e)
        {
            string topic = "animals";
            switch (seleccionado)
            {
                case "listening":
                    {
                        seleccionarListening listening = new seleccionarListening(topic,seg);
                        listening.Show();
                        this.Close();
                    }
                    break;
                case "vocabulary":
                    {
                        seleccionarVocabulary vocabulary = new seleccionarVocabulary(topic,seg);
                        vocabulary.Show();
                        this.Close();
                    }
                    break;
                case "writing":
                    {
                        seleccionarWriting writing = new seleccionarWriting(topic,seg);
                        writing.Show();
                        this.Close();
                    }
                    break;
            }
        }
    }

    
}
