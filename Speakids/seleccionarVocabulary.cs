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
    public partial class seleccionarVocabulary : Form
    {
        string topics = "";
        int seg;
        public seleccionarVocabulary(string topic, int time)
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
            Conocimiento_Ingles mostrarMenu = new Conocimiento_Ingles(seg);
            mostrarMenu.Show();
            this.Close();
        }
        private void pb_imagen1_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen1.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto1.Text = "    SLEEP";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto1.Text = "   TRAIN";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto1.Text = "   SOCCER";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto1.Text = "    COAT";
                    }
                    break;
                case "food":
                    {
                        lbl_texto1.Text = "    EGGS";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto1.Text = "   POLICE";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto1.Text = "    RABBIT";
                    }
                    break;
            }
        }

        private void pb_imagen1_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen1.Size = new System.Drawing.Size(126, 115);
            lbl_texto1.Text = "";
        }

        private void pb_imagen2_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen2.Size = new System.Drawing.Size(136, 125); switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto2.Text = "    COOK";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto2.Text = "     CAR";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto2.Text = "  BASEBALL";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto2.Text = "   SHOES";
                    }
                    break;
                case "food":
                    {
                        lbl_texto2.Text = "   SOUP";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto2.Text = "  FIREMAN";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto2.Text = " HAMSTER";
                    }
                    break;
            }
        }

        private void pb_imagen2_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen2.Size = new System.Drawing.Size(126, 115);
            lbl_texto2.Text = "";
        }

        private void pb_imagen3_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen3.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto3.Text = "     CRY";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto3.Text = "     BUS";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto3.Text = "VOLLEYBALL";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto3.Text = "   SOCKS";
                    }
                    break;
                case "food":
                    {
                        lbl_texto3.Text = "POTATOES";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto3.Text = "   DOCTOR";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto3.Text = "   SNAKE";
                    }
                    break;
            }
        }

        private void pb_imagen3_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen3.Size = new System.Drawing.Size(126, 115);
            lbl_texto3.Text = "";
        }

        private void pb_imagen4_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen4.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto4.Text = "     DRIVE";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto4.Text = "MOTORCYCLE";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto4.Text = "BASKETBALL";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto4.Text = "     PANTS";
                    }
                    break;
                case "food":
                    {
                        lbl_texto4.Text = "     CHIPS";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto4.Text = "    DENTIST";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto4.Text = "     SPIDER";
                    }
                    break;
            }
        }

        private void pb_imagen4_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen4.Size = new System.Drawing.Size(126, 115);
            lbl_texto4.Text = "";
        }

        private void pb_imagen5_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen5.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto5.Text = "    READ";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto5.Text = "   FERRY";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto5.Text = "   TENNIS";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto5.Text = "     HAT";
                    }
                    break;
                case "food":
                    {
                        lbl_texto5.Text = "  CARROTS";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto5.Text = " WAITER";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto5.Text = "  LIZARD";
                    }
                    break;
            }
        }

        private void pb_imagen5_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen5.Size = new System.Drawing.Size(126, 115);
            lbl_texto5.Text = "";
        }

        private void pb_imagen6_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen6.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto6.Text = "      CALL";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto6.Text = "    TAXI";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto6.Text = "    CYCLING";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto6.Text = "    SKIRT";
                    }
                    break;
                case "food":
                    {
                        lbl_texto6.Text = "  ONIONS";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto6.Text = " ENGINEER";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto6.Text = "     FROG";
                    }
                    break;
            }
        }

        private void pb_imagen6_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen6.Size = new System.Drawing.Size(126, 115);
            lbl_texto6.Text = "";
        }

        private void pb_imagen7_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen7.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto7.Text = "     RUN";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto7.Text = " AIRPLANE";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto7.Text = "   BOXING";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto7.Text = "  SHORTS";
                    }
                    break;
                case "food":
                    {
                        lbl_texto7.Text = "     CORN";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto7.Text = "   SINGER";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto7.Text = "     PIG";
                    }
                    break;
            }
        }
        
        private void pb_imagen7_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen7.Size = new System.Drawing.Size(126, 115);
            lbl_texto7.Text = "";
        }

        private void pb_imagen8_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen8.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto8.Text = "     JUMP";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto8.Text = "HELICOPTER";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto8.Text = "   SURFING";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto8.Text = "     SHIRT";
                    }
                    break;
                case "food":
                    {
                        lbl_texto8.Text = "      PEAS";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto8.Text = "        VET";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto8.Text = "     SHEEP";
                    }
                    break;
            }
        }

        private void pb_imagen8_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen8.Size = new System.Drawing.Size(126, 115);
            lbl_texto8.Text = "";
        }

        private void pb_imagen9_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen9.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto9.Text = "    SING";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto9.Text = "  ROCKET";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto9.Text = " RUNNING";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto9.Text = "  T-SHIRT";
                    }
                    break;
                case "food":
                    {
                        lbl_texto9.Text = " GRAPES";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto9.Text = "REPORTER";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto9.Text = "    COW";
                    }
                    break;
            }
        }

        private void pb_imagen9_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen9.Size = new System.Drawing.Size(126, 115);
            lbl_texto9.Text = "";
        }

        private void pb_imagen10_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen10.Size = new System.Drawing.Size(136, 125);
            switch (topics)
            {
                case "verbs":
                    {
                        lbl_texto10.Text = "    SWIM";
                    }
                    break;
                case "transport":
                    {
                        lbl_texto10.Text = " BICLYCLE";
                    }
                    break;
                case "sports":
                    {
                        lbl_texto10.Text = "     GOLF";
                    }
                    break;
                case "clothes":
                    {
                        lbl_texto10.Text = " SWEATER";
                    }
                    break;
                case "food":
                    {
                        lbl_texto10.Text = "  RICE";
                    }
                    break;
                case "professions":
                    {
                        lbl_texto10.Text = "  BUILDER";
                    }
                    break;
                case "animals":
                    {
                        lbl_texto10.Text = "     DOG";
                    }
                    break;
            }
        }

        private void pb_imagen10_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen10.Size = new System.Drawing.Size(126, 115);
            lbl_texto10.Text = "";
        }

        private void seleccionarVocabulary_Load(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        pb_topic.Image = Properties.Resources.verbs;
                        pb_imagen1.Image = Properties.Resources.sleep1;
                        pb_imagen2.Image = Properties.Resources.cook1;
                        pb_imagen3.Image = Properties.Resources.cry1;
                        pb_imagen4.Image = Properties.Resources.drive1;
                        pb_imagen5.Image = Properties.Resources.read1;
                        pb_imagen6.Image = Properties.Resources.call1;
                        pb_imagen7.Image = Properties.Resources.run1;
                        pb_imagen8.Image = Properties.Resources.jump1;
                        pb_imagen9.Image = Properties.Resources.sing1;
                        pb_imagen10.Image = Properties.Resources.swim1;

                    }
                    break;
                case "transport":
                    {
                        pb_topic.Image = Properties.Resources.transport;
                        pb_imagen1.Image = Properties.Resources.train1;
                        pb_imagen2.Image = Properties.Resources.car1;
                        pb_imagen3.Image = Properties.Resources.bus1;
                        pb_imagen4.Image = Properties.Resources.motorcycle1;
                        pb_imagen5.Image = Properties.Resources.ferry1;
                        pb_imagen6.Image = Properties.Resources.taxi1;
                        pb_imagen7.Image = Properties.Resources.airplane1;
                        pb_imagen8.Image = Properties.Resources.helicopter1;
                        pb_imagen9.Image = Properties.Resources.rocket1;
                        pb_imagen10.Image = Properties.Resources.bicycle1;
                    }
                    break;
                case "sports":
                    {
                        pb_topic.Image = Properties.Resources.sports;
                        pb_imagen1.Image = Properties.Resources.soccer1;
                        pb_imagen2.Image = Properties.Resources.baseball1;
                        pb_imagen3.Image = Properties.Resources.volleyball1;
                        pb_imagen4.Image = Properties.Resources.basketball1;
                        pb_imagen5.Image = Properties.Resources.tennis1;
                        pb_imagen6.Image = Properties.Resources.cycling1;
                        pb_imagen7.Image = Properties.Resources.boxing1;
                        pb_imagen8.Image = Properties.Resources.surfing1;
                        pb_imagen9.Image = Properties.Resources.running1;
                        pb_imagen10.Image = Properties.Resources.golf1;
                    }
                    break;
                case "clothes":
                    {
                        pb_topic.Image = Properties.Resources.clothes;
                        pb_imagen1.Image = Properties.Resources.coat1;
                        pb_imagen2.Image = Properties.Resources.shoes1;
                        pb_imagen3.Image = Properties.Resources.socks1;
                        pb_imagen4.Image = Properties.Resources.pants1;
                        pb_imagen5.Image = Properties.Resources.hat1;
                        pb_imagen6.Image = Properties.Resources.skirt1;
                        pb_imagen7.Image = Properties.Resources.shorts1;
                        pb_imagen8.Image = Properties.Resources.shirt1;
                        pb_imagen9.Image = Properties.Resources.tshirt1;
                        pb_imagen10.Image = Properties.Resources.sweater1;
                    }
                    break;
                case "food":
                    {
                        pb_topic.Image = Properties.Resources.food;
                        pb_imagen1.Image = Properties.Resources.eggs1;
                        pb_imagen2.Image = Properties.Resources.soup1;
                        pb_imagen3.Image = Properties.Resources.potatoes1;
                        pb_imagen4.Image = Properties.Resources.chips1;
                        pb_imagen5.Image = Properties.Resources.carrots1;
                        pb_imagen6.Image = Properties.Resources.onions1;
                        pb_imagen7.Image = Properties.Resources.corn1;
                        pb_imagen8.Image = Properties.Resources.peas1;
                        pb_imagen9.Image = Properties.Resources.grapes1;
                        pb_imagen10.Image = Properties.Resources.rice1;
                    }
                    break;
                case "professions":
                    {
                        pb_topic.Image = Properties.Resources.professions;
                        pb_imagen1.Image = Properties.Resources.police1;
                        pb_imagen2.Image = Properties.Resources.fireman1;
                        pb_imagen3.Image = Properties.Resources.doctor1;
                        pb_imagen4.Image = Properties.Resources.dentist1;
                        pb_imagen5.Image = Properties.Resources.waiter1;
                        pb_imagen6.Image = Properties.Resources.engineer1;
                        pb_imagen7.Image = Properties.Resources.singer1;
                        pb_imagen8.Image = Properties.Resources.vet1;
                        pb_imagen9.Image = Properties.Resources.reporter1;
                        pb_imagen10.Image = Properties.Resources.builder1;
                    }
                    break;
                case "animals":
                    {
                        pb_topic.Image = Properties.Resources.animals;
                        pb_imagen1.Image = Properties.Resources.rabbit1;
                        pb_imagen2.Image = Properties.Resources.hamster1;
                        pb_imagen3.Image = Properties.Resources.snake1;
                        pb_imagen4.Image = Properties.Resources.spider1;
                        pb_imagen5.Image = Properties.Resources.lizard1;
                        pb_imagen6.Image = Properties.Resources.frog1;
                        pb_imagen7.Image = Properties.Resources.pig1;
                        pb_imagen8.Image = Properties.Resources.sheep1;
                        pb_imagen9.Image = Properties.Resources.cow1;
                        pb_imagen10.Image = Properties.Resources.dog1;
                    }
                    break;
            }
        }
        SoundPlayer sonido = new SoundPlayer();
        private void pb_imagen1_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.sleep;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.train;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.soccer;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.coat;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.eggs;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.police;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.rabbit;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen2_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.cook;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.car;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.baseball;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.shoes;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.soup;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.fireman;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.hamster;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen3_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.cry;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.bus;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.volleyball;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.socks;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.potatoes;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.doctor;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.snake;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen4_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.drive;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.motorcycle;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.basketball;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.pants;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.chips;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.dentist;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.spider;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen5_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.read;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.ferry;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.tennis;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.hat;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.carrots;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.waiter;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.lizard;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen6_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.call;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.taxi;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.cycling;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.skirt;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.onions;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.engineer;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.frog;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen7_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.run;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.airplane;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.boxing;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.shorts;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.corn;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.singer;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.pig;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen8_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.jump;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.helicopter;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.surfing;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.shirt;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.peas;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.vet;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.sheep;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen9_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.sing;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.rocket;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.running;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.tshirt;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.grapes;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.reporter;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.cow;
                        sonido.Play();
                    }
                    break;
            }
        }

        private void pb_imagen10_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        sonido.Stream = Properties.Resources.swim;
                        sonido.Play();
                    }
                    break;
                case "transport":
                    {
                        sonido.Stream = Properties.Resources.bicycle;
                        sonido.Play();
                    }
                    break;
                case "sports":
                    {
                        sonido.Stream = Properties.Resources.golf;
                        sonido.Play();
                    }
                    break;
                case "clothes":
                    {
                        sonido.Stream = Properties.Resources.sweater;
                        sonido.Play();
                    }
                    break;
                case "food":
                    {
                        sonido.Stream = Properties.Resources.rice;
                        sonido.Play();
                    }
                    break;
                case "professions":
                    {
                        sonido.Stream = Properties.Resources.builder;
                        sonido.Play();
                    }
                    break;
                case "animals":
                    {
                        sonido.Stream = Properties.Resources.dog;
                        sonido.Play();
                    }
                    break;
            }
        }
    }
}
