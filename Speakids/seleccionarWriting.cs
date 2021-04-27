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
    public partial class seleccionarWriting : Form
    {
        string topics = "";
        int seg;
        public seleccionarWriting(string topic, int time)
        {
            InitializeComponent();
            topics = topic;
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
            sonido.Stop();
            Conocimiento_Ingles mostrarMenu = new Conocimiento_Ingles(seg);
            mostrarMenu.Show();
            this.Close();
        }

        Random aleatorio = new Random();
        int random = 0;
        string palabra = "";
        int segundo;
        SoundPlayer sonido = new SoundPlayer();
        private void seleccionarWriting_Load(object sender, EventArgs e)
        {
            sonido.Stream = Properties.Resources.temporizador;
            sonido.Play();
            segundo = seg;
            timer1.Enabled = true;
            lbl_tiempo.Text = segundo.ToString();
            pb_siguiente.Image = Properties.Resources.siguiente;
            random = aleatorio.Next(1, 11);
            switch (topics)
            {
                case "verbs":
                    {
                        pb_topic.Image = Properties.Resources.verbs;
                        switch (random) {
                            case 1:
                                pb_imagen.Image = Properties.Resources.sleep1;
                                num1 = 1;
                                palabra = "sleep";
                                break;
                            case 2:
                                pb_imagen.Image = Properties.Resources.cook1;
                                num2 = 1;
                                palabra = "cook";
                                break;
                            case 3:
                                pb_imagen.Image = Properties.Resources.cry1;
                                num3 = 1;
                                palabra = "cry";
                                break;
                            case 4:
                                pb_imagen.Image = Properties.Resources.drive1;
                                num4 = 1;
                                palabra = "drive";
                                break;
                            case 5:
                                pb_imagen.Image = Properties.Resources.read1;
                                num5 = 1;
                                palabra = "read";
                                break;
                            case 6:
                                pb_imagen.Image = Properties.Resources.call1;
                                num6 = 1;
                                palabra = "call";
                                break;
                            case 7:
                                pb_imagen.Image = Properties.Resources.run1;
                                num7 = 1;
                                palabra = "run";
                                break;
                            case 8:
                                pb_imagen.Image = Properties.Resources.jump1;
                                num8 = 1;
                                palabra = "jump";
                                break;
                            case 9:
                                pb_imagen.Image = Properties.Resources.sing1;
                                num9 = 1;
                                palabra = "sing";
                                break;
                            case 10:
                                pb_imagen.Image = Properties.Resources.swim1;
                                num10 = 1;
                                palabra = "swim";
                                break;
                        }
                    }
                    break;
                case "transport":
                    {
                        pb_topic.Image = Properties.Resources.transport;
                        switch (random)
                        {
                            case 1:
                                pb_imagen.Image = Properties.Resources.train1;
                                num1 = 1;
                                palabra = "train";
                                break;
                            case 2:
                                pb_imagen.Image = Properties.Resources.car1;
                                num2 = 1;
                                palabra = "car";
                                break;
                            case 3:
                                pb_imagen.Image = Properties.Resources.bus1;
                                num3 = 1;
                                palabra = "bus";
                                break;
                            case 4:
                                pb_imagen.Image = Properties.Resources.motorcycle1;
                                num4 = 1;
                                palabra = "motorcycle";
                                break;
                            case 5:
                                pb_imagen.Image = Properties.Resources.ferry1;
                                num5 = 1;
                                palabra = "ferry";
                                break;
                            case 6:
                                pb_imagen.Image = Properties.Resources.taxi1;
                                num6 = 1;
                                palabra = "taxi";
                                break;
                            case 7:
                                pb_imagen.Image = Properties.Resources.airplane1;
                                num7 = 1;
                                palabra = "airplane";
                                break;
                            case 8:
                                pb_imagen.Image = Properties.Resources.helicopter1;
                                num8 = 1;
                                palabra = "helicopter";
                                break;
                            case 9:
                                pb_imagen.Image = Properties.Resources.rocket1;
                                num9 = 1;
                                palabra = "rocket";
                                break;
                            case 10:
                                pb_imagen.Image = Properties.Resources.bicycle1;
                                num10 = 1;
                                palabra = "bicycle";
                                break;
                        }
                    }
                    break;
                case "sports":
                    {
                        pb_topic.Image = Properties.Resources.sports;
                        switch (random)
                        {
                            case 1:
                                pb_imagen.Image = Properties.Resources.soccer1;
                                num1 = 1;
                                palabra = "soccer";
                                break;
                            case 2:
                                pb_imagen.Image = Properties.Resources.baseball1;
                                num2 = 1;
                                palabra = "baseball";
                                break;
                            case 3:
                                pb_imagen.Image = Properties.Resources.volleyball1;
                                num3 = 1;
                                palabra = "volleyball";
                                break;
                            case 4:
                                pb_imagen.Image = Properties.Resources.basketball1;
                                num4 = 1;
                                palabra = "basketball";
                                break;
                            case 5:
                                pb_imagen.Image = Properties.Resources.tennis1;
                                num5 = 1;
                                palabra = "tennis";
                                break;
                            case 6:
                                pb_imagen.Image = Properties.Resources.cycling1;
                                num6 = 1;
                                palabra = "cycling";
                                break;
                            case 7:
                                pb_imagen.Image = Properties.Resources.boxing1;
                                num7 = 1;
                                palabra = "boxing";
                                break;
                            case 8:
                                pb_imagen.Image = Properties.Resources.surfing1;
                                num8 = 1;
                                palabra = "surfing";
                                break;
                            case 9:
                                pb_imagen.Image = Properties.Resources.running1;
                                num9 = 1;
                                palabra = "runnnig";
                                break;
                            case 10:
                                pb_imagen.Image = Properties.Resources.golf1;
                                num10 = 1;
                                palabra = "golf";
                                break;
                        }
                    }
                    break;
                case "clothes":
                    {
                        pb_topic.Image = Properties.Resources.clothes;
                        switch (random)
                        {
                            case 1:
                                pb_imagen.Image = Properties.Resources.coat1;
                                num1 = 1;
                                palabra = "coat";
                                break;
                            case 2:
                                pb_imagen.Image = Properties.Resources.shoes1;
                                num2 = 1;
                                palabra = "shoes";
                                break;
                            case 3:
                                pb_imagen.Image = Properties.Resources.socks1;
                                num3 = 1;
                                palabra = "socks";
                                break;
                            case 4:
                                pb_imagen.Image = Properties.Resources.pants1;
                                num4 = 1;
                                palabra = "pants";
                                break;
                            case 5:
                                pb_imagen.Image = Properties.Resources.hat1;
                                num5 = 1;
                                palabra = "hat";
                                break;
                            case 6:
                                pb_imagen.Image = Properties.Resources.skirt1;
                                num6 = 1;
                                palabra = "skirt";
                                break;
                            case 7:
                                pb_imagen.Image = Properties.Resources.shorts1;
                                num7 = 1;
                                palabra = "shorts";
                                break;
                            case 8:
                                pb_imagen.Image = Properties.Resources.shirt1;
                                num8 = 1;
                                palabra = "shirt";
                                break;
                            case 9:
                                pb_imagen.Image = Properties.Resources.tshirt1;
                                num9 = 1;
                                palabra = "tshirt";
                                break;
                            case 10:
                                pb_imagen.Image = Properties.Resources.sweater1;
                                num10 = 1;
                                palabra = "sweater";
                                break;
                        }
                    }
                    break;
                case "food":
                    {
                        pb_topic.Image = Properties.Resources.food;
                        switch (random)
                        {
                            case 1:
                                pb_imagen.Image = Properties.Resources.eggs1;
                                num1 = 1;
                                palabra = "eggs";
                                break;
                            case 2:
                                pb_imagen.Image = Properties.Resources.soup1;
                                num2 = 1;
                                palabra = "soup";
                                break;
                            case 3:
                                pb_imagen.Image = Properties.Resources.potatoes1;
                                num3 = 1;
                                palabra = "potatoes";
                                break;
                            case 4:
                                pb_imagen.Image = Properties.Resources.chips1;
                                num4 = 1;
                                palabra = "chips";
                                break;
                            case 5:
                                pb_imagen.Image = Properties.Resources.carrots1;
                                num5 = 1;
                                palabra = "carrots";
                                break;
                            case 6:
                                pb_imagen.Image = Properties.Resources.onions1;
                                num6 = 1;
                                palabra = "onions";
                                break;
                            case 7:
                                pb_imagen.Image = Properties.Resources.corn1;
                                num7 = 1;
                                palabra = "corn";
                                break;
                            case 8:
                                pb_imagen.Image = Properties.Resources.peas1;
                                num8 = 1;
                                palabra = "peas";
                                break;
                            case 9:
                                pb_imagen.Image = Properties.Resources.grapes1;
                                num9 = 1;
                                palabra = "grapes";
                                break;
                            case 10:
                                pb_imagen.Image = Properties.Resources.rice1;
                                num10 = 1;
                                palabra = "rice";
                                break;
                        }
                    }
                    break;
                case "professions":
                    {
                        pb_topic.Image = Properties.Resources.professions;
                        switch (random)
                        {
                            case 1:
                                pb_imagen.Image = Properties.Resources.police1;
                                num1 = 1;
                                palabra = "police";
                                break;
                            case 2:
                                pb_imagen.Image = Properties.Resources.fireman1;
                                num2 = 1;
                                palabra = "fireman";
                                break;
                            case 3:
                                pb_imagen.Image = Properties.Resources.doctor1;
                                num3 = 1;
                                palabra = "doctor";
                                break;
                            case 4:
                                pb_imagen.Image = Properties.Resources.dentist1;
                                num4 = 1;
                                palabra = "dentist";
                                break;
                            case 5:
                                pb_imagen.Image = Properties.Resources.waiter1;
                                num5 = 1;
                                palabra = "waiter";
                                break;
                            case 6:
                                pb_imagen.Image = Properties.Resources.engineer1;
                                num6 = 1;
                                palabra = "engineer";
                                break;
                            case 7:
                                pb_imagen.Image = Properties.Resources.singer1;
                                num7 = 1;
                                palabra = "singer";
                                break;
                            case 8:
                                pb_imagen.Image = Properties.Resources.vet1;
                                num8 = 1;
                                palabra = "vet";
                                break;
                            case 9:
                                pb_imagen.Image = Properties.Resources.reporter1;
                                num9 = 1;
                                palabra = "reporter";
                                break;
                            case 10:
                                pb_imagen.Image = Properties.Resources.builder1;
                                num10 = 1;
                                palabra = "builder";
                                break;
                        }
                    }
                    break;
                case "animals":
                    {
                        pb_topic.Image = Properties.Resources.animals;
                        switch (random)
                        {
                            case 1:
                                pb_imagen.Image = Properties.Resources.rabbit1;
                                num1 = 1;
                                palabra = "rabbit";
                                break;
                            case 2:
                                pb_imagen.Image = Properties.Resources.hamster1;
                                num2 = 1;
                                palabra = "hamster";
                                break;
                            case 3:
                                pb_imagen.Image = Properties.Resources.snake1;
                                num3 = 1;
                                palabra = "snake";
                                break;
                            case 4:
                                pb_imagen.Image = Properties.Resources.spider1;
                                num4 = 1;
                                palabra = "spider";
                                break;
                            case 5:
                                pb_imagen.Image = Properties.Resources.lizard1;
                                num5 = 1;
                                palabra = "lizard";
                                break;
                            case 6:
                                pb_imagen.Image = Properties.Resources.frog1;
                                num6 = 1;
                                palabra = "frog";
                                break;
                            case 7:
                                pb_imagen.Image = Properties.Resources.pig1;
                                num7 = 1;
                                palabra = "pig";
                                break;
                            case 8:
                                pb_imagen.Image = Properties.Resources.sheep1;
                                num8 = 1;
                                palabra = "sheep";
                                break;
                            case 9:
                                pb_imagen.Image = Properties.Resources.cow1;
                                num9 = 1;
                                palabra = "cow";
                                break;
                            case 10:
                                pb_imagen.Image = Properties.Resources.dog1;
                                num10 = 1;
                                palabra = "dog";
                                break;
                        }
                    }
                    break;
            }
        }

        private void pb_siguiente_MouseEnter(object sender, EventArgs e)
        {
            pb_siguiente.Size = new System.Drawing.Size(192, 66);
        }

        private void pb_siguiente_MouseLeave(object sender, EventArgs e)
        {
            pb_siguiente.Size = new System.Drawing.Size(182, 56);
        }

        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;
        int num7 = 0;
        int num8 = 0;
        int num9 = 0;
        int num10 = 0;
        int cont = 0;
        

        private void pb_siguiente_Click(object sender, EventArgs e)
        {
            if (tb_texto.Text == "")
            {
                sonido.Stream = Properties.Resources.incorrecto;
                sonido.PlaySync();
                tb_texto.BackColor = Color.Red;
                sonido.Stream = Properties.Resources.temporizador;
                sonido.Play();
                return;
            }
            entra = false;
            sonido.Stop();
            sonido.Stream = Properties.Resources.temporizador;
            sonido.Play();
            segundo = seg;
            timer1.Enabled = true;
            lbl_tiempo.Text = segundo.ToString();

            if (num1 == 1 && num2 == 1 && num3 == 1 && num4 == 1 && num5 == 1 && num6 == 1 && num7 == 1 && num8 == 1 && num9 == 1 && num10 == 1)
            {
                MostrarResultados resultados = new MostrarResultados(cont,seg);
                resultados.Show();
                this.Close();
            }
            else
            {
                switch (topics)
                {
                    case "verbs":
                        {
                            switch (aleatorio.Next(1, 11))
                            {
                                case 1:
                                    if (random == 1)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.sleep1;
                                            num1 = 1;
                                            palabra = "sleep";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.cook1;
                                            num2 = 1;
                                            palabra = "cook";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.cry1;
                                            num3 = 1;
                                            palabra = "cry";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.drive1;
                                            num4 = 1;
                                            palabra = "drive";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.read1;
                                            num5 = 1;
                                            palabra = "read";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.call1;
                                            num6 = 1;
                                            palabra = "call";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.run1;
                                            num7 = 1;
                                            palabra = "run";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.jump1;
                                            num8 = 1;
                                            palabra = "jump";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.sing1;
                                            num9 = 1;
                                            palabra = "sing";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.swim1;
                                            num10 = 1;
                                            palabra = "swim";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "transport":
                        {
                            switch (aleatorio.Next(1, 11))
                            {
                                case 1:
                                    if (random == 1)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.train1;
                                            num1 = 1;
                                            palabra = "train";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.car1;
                                            num2 = 1;
                                            palabra = "car";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.bus1;
                                            num3 = 1;
                                            palabra = "bus";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.motorcycle1;
                                            num4 = 1;
                                            palabra = "motorcycle";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.ferry1;
                                            num5 = 1;
                                            palabra = "ferry";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.taxi1;
                                            num6 = 1;
                                            palabra = "taxi";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.airplane1;
                                            num7 = 1;
                                            palabra = "airplane";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.helicopter1;
                                            num8 = 1;
                                            palabra = "helicopter";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.rocket1;
                                            num9 = 1;
                                            palabra = "rocket";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.bicycle1;
                                            num10 = 1;
                                            palabra = "bicycle";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "sports":
                        {
                            switch (aleatorio.Next(1, 11))
                            {
                                case 1:
                                    if (random == 1)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.soccer1;
                                            num1 = 1;
                                            palabra = "soccer";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.baseball1;
                                            num2 = 1;
                                            palabra = "baseball";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.volleyball1;
                                            num3 = 1;
                                            palabra = "volleyball";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.basketball1;
                                            num4 = 1;
                                            palabra = "basketball";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.tennis1;
                                            num5 = 1;
                                            palabra = "tennis";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.cycling1;
                                            num6 = 1;
                                            palabra = "cycling";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.boxing1;
                                            num7 = 1;
                                            palabra = "boxing";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.surfing1;
                                            num8 = 1;
                                            palabra = "surfing";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.running1;
                                            num9 = 1;
                                            palabra = "running";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.golf1;
                                            num10 = 1;
                                            palabra = "golf";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "clothes":
                        {
                            switch (aleatorio.Next(1, 11))
                            {
                                case 1:
                                    if (random == 1)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.coat1;
                                            num1 = 1;
                                            palabra = "coat";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.shoes1;
                                            num2 = 1;
                                            palabra = "shoes";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.socks1;
                                            num3 = 1;
                                            palabra = "socks";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.pants1;
                                            num4 = 1;
                                            palabra = "pants";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.hat1;
                                            num5 = 1;
                                            palabra = "hat";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.skirt1;
                                            num6 = 1;
                                            palabra = "skirt";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.shorts1;
                                            num7 = 1;
                                            palabra = "shorts";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.shirt1;
                                            num8 = 1;
                                            palabra = "shirt";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.tshirt1;
                                            num9 = 1;
                                            palabra = "tshirt";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.sweater1;
                                            num10 = 1;
                                            palabra = "sweater";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "food":
                        {
                            switch (aleatorio.Next(1, 11))
                            {
                                case 1:
                                    if (random == 1)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.eggs1;
                                            num1 = 1;
                                            palabra = "eggs";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.soup1;
                                            num2 = 1;
                                            palabra = "soup";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.potatoes1;
                                            num3 = 1;
                                            palabra = "potatoes";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.chips1;
                                            num4 = 1;
                                            palabra = "chips";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.carrots1;
                                            num5 = 1;
                                            palabra = "carrots";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.onions1;
                                            num6 = 1;
                                            palabra = "onions";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.corn1;
                                            num7 = 1;
                                            palabra = "corn";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.peas1;
                                            num8 = 1;
                                            palabra = "peas";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.grapes1;
                                            num9 = 1;
                                            palabra = "grapes";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.rice1;
                                            num10 = 1;
                                            palabra = "rice";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "professions":
                        {
                            switch (aleatorio.Next(1, 11))
                            {
                                case 1:
                                    if (random == 1)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.police1;
                                            num1 = 1;
                                            palabra = "police";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.fireman1;
                                            num2 = 1;
                                            palabra = "fireman";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.doctor1;
                                            num3 = 1;
                                            palabra = "doctor";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.dentist1;
                                            num4 = 1;
                                            palabra = "dentist";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.waiter1;
                                            num5 = 1;
                                            palabra = "waiter";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.engineer1;
                                            num6 = 1;
                                            palabra = "engineer";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.singer1;
                                            num7 = 1;
                                            palabra = "singer";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.vet1;
                                            num8 = 1;
                                            palabra = "vet";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.reporter1;
                                            num9 = 1;
                                            palabra = "reporter";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.builder1;
                                            num10 = 1;
                                            palabra = "builder";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "animals":
                        {
                            switch (aleatorio.Next(1, 11))
                            {
                                case 1:
                                    if (random == 1)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.rabbit1;
                                            num1 = 1;
                                            palabra = "rabbit";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.hamster1;
                                            num2 = 1;
                                            palabra = "hamster";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.snake1;
                                            num3 = 1;
                                            palabra = "snake";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.spider1;
                                            num4 = 1;
                                            palabra = "spider";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.lizard1;
                                            num5 = 1;
                                            palabra = "lizard";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.frog1;
                                            num6 = 1;
                                            palabra = "frog";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.pig1;
                                            num7 = 1;
                                            palabra = "pig";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.sheep1;
                                            num8 = 1;
                                            palabra = "sheep";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.cow1;
                                            num9 = 1;
                                            palabra = "cow";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_siguiente_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            pb_imagen.Image = Properties.Resources.dog1;
                                            num10 = 1;
                                            palabra = "dog";
                                        }
                                        else
                                        {
                                            pb_siguiente_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
            tb_texto.Text = "";
        }

        private void tb_texto_MouseEnter(object sender, EventArgs e)
        {
            tb_texto.BackColor = Color.White;
        }
        Boolean entra=false; 
        private void tb_texto_TextChanged(object sender, EventArgs e)
        {
            if (tb_texto.BackColor==Color.Red)
            {
                tb_texto.BackColor = Color.White;
            }

            switch (topics)
            {
                case "verbs":
                    {
                        switch (palabra)
                        {
                            case "sleep":
                                if (tb_texto.Text == "sleep" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "cook":
                                if (tb_texto.Text == "cook" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "cry":
                                if (tb_texto.Text == "cry" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "drive":
                                if (tb_texto.Text == "drive" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "read":
                                if (tb_texto.Text == "read" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "call":
                                if (tb_texto.Text == "call" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "run":
                                if (tb_texto.Text == "run" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "jump":
                                if (tb_texto.Text == "jump" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "sing":
                                if (tb_texto.Text == "sing" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "swim":
                                if (tb_texto.Text == "swim" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                        }
                        break;
                    }
                case "transport":
                    {
                        switch (palabra)
                        {
                            case "train":
                                if (tb_texto.Text == "train" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "car":
                                if (tb_texto.Text == "car" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "bus":
                                if (tb_texto.Text == "bus" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "motorcycle":
                                if (tb_texto.Text == "motorcycle" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "ferry":
                                if (tb_texto.Text == "ferry" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "taxi":
                                if (tb_texto.Text == "taxi" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "airplane":
                                if (tb_texto.Text == "airplane" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "helicopter":
                                if (tb_texto.Text == "helicopter" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "rocket":
                                if (tb_texto.Text == "rocket" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "bicycle":
                                if (tb_texto.Text == "bicycle" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                        }
                        break;
                    }
                case "sports":
                    {
                        switch (palabra)
                        {
                            case "soccer":
                                if (tb_texto.Text == "soccer" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "baseball":
                                if (tb_texto.Text == "baseball" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "volleyball":
                                if (tb_texto.Text == "volleyball" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "basketball":
                                if (tb_texto.Text == "basketball" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "tennis":
                                if (tb_texto.Text == "tennis" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "cycling":
                                if (tb_texto.Text == "cycling" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "boxing":
                                if (tb_texto.Text == "boxing" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "surfing":
                                if (tb_texto.Text == "surfing" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "running":
                                if (tb_texto.Text == "running" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "golf":
                                if (tb_texto.Text == "golf" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                        }
                        break;
                    }
                case "clothes":
                    {
                        switch (palabra)
                        {
                            case "coat":
                                if (tb_texto.Text == "coat" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "shoes":
                                if (tb_texto.Text == "shoes" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "socks":
                                if (tb_texto.Text == "socks" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "pants":
                                if (tb_texto.Text == "pants" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "hat":
                                if (tb_texto.Text == "hat" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "skirt":
                                if (tb_texto.Text == "skirt" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "shorts":
                                if (tb_texto.Text == "shorts" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "shirt":
                                if (tb_texto.Text == "shirt" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "tshirt":
                                if ((tb_texto.Text == "tshirt" || tb_texto.Text == "t-shirt" || tb_texto.Text == "t shirt") && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "sweater":
                                if (tb_texto.Text == "sweater" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                        }
                        break;
                    }
                case "food":
                    {
                        switch (palabra)
                        {
                            case "eggs":
                                if (tb_texto.Text == "eggs" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "soup":
                                if (tb_texto.Text == "soup" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "potatoes":
                                if (tb_texto.Text == "potatoes" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "chips":
                                if (tb_texto.Text == "chips" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "carrots":
                                if (tb_texto.Text == "carrots" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "onions":
                                if (tb_texto.Text == "onions" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "corn":
                                if (tb_texto.Text == "corn" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "peas":
                                if (tb_texto.Text == "peas" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "grapes":
                                if (tb_texto.Text == "grapes" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "rice":
                                if (tb_texto.Text == "rice" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                        }
                        break;
                    }
                case "professions":
                    {
                        switch (palabra)
                        {
                            case "police":
                                if (tb_texto.Text == "police" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "fireman":
                                if (tb_texto.Text == "fireman" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "doctor":
                                if (tb_texto.Text == "doctor" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "dentist":
                                if (tb_texto.Text == "dentist" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "waiter":
                                if (tb_texto.Text == "waiter" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "engineer":
                                if (tb_texto.Text == "engineer" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "singer":
                                if (tb_texto.Text == "singer" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "vet":
                                if (tb_texto.Text == "vet" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "reporter":
                                if (tb_texto.Text == "reporter" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "builder":
                                if (tb_texto.Text == "builder" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                        }
                        break;
                    }
                case "animals":
                    {
                        switch (palabra)
                        {
                            case "rabbit":
                                if (tb_texto.Text == "rabbit" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "hamster":
                                if (tb_texto.Text == "hamster" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "snake":
                                if (tb_texto.Text == "snake" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "spider":
                                if (tb_texto.Text == "spider" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "lizard":
                                if (tb_texto.Text == "lizard" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "frog":
                                if (tb_texto.Text == "frog" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "pig":
                                if (tb_texto.Text == "pig" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "sheep":
                                if (tb_texto.Text == "sheep" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "cow":
                                if (tb_texto.Text == "cow" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                            case "dog":
                                if (tb_texto.Text == "dog" && entra == false)
                                {
                                    entra = true;
                                    cont++;
                                }
                                break;
                        }
                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            lbl_tiempo.Text = segundo.ToString();
            if (segundo == 0)
            {
                timer1.Enabled = false;
                tb_texto.Text = "  ";
                sonido.Stream = Properties.Resources.incorrecto;
                sonido.PlaySync();
                pb_siguiente_Click(sender, e);
            }
        }

        private void tb_texto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                pb_siguiente_Click(sender, e);
            }
        }
    }
}
