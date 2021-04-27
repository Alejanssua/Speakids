using System;
using System.Media;
using System.Windows.Forms;

namespace Speakids
{
    public partial class seleccionarListening : Form
    {
        string topics;
        int seg;
        public seleccionarListening(string topic, int time)
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
        Random aleatorio = new Random();
        int random = 0;
        SoundPlayer sonido = new SoundPlayer();
        int segundo;
        string palabra = "";

        private void seleccionarListening_Load(object sender, EventArgs e)
        {
            num1 = 0; num2 = 0; num3 = 0; num4 = 0; num5 = 0; num6 = 0; num7 = 0; num8 = 0; num9 = 0; num10 = 0;
            segundo = seg;
            timer1.Enabled = true;
            lbl_tiempo.Text = segundo.ToString();
            random = aleatorio.Next(1, 11);
            switch (topics)
            {
                case "verbs":
                    {
                        pb_topic.Image = Properties.Resources.verbs;
                        switch (random)
                        {
                            case 1:
                                num1 = 1;
                                pb_imagen1.Image = Properties.Resources.sleep1;
                                pb_imagen2.Image = Properties.Resources.sing1;
                                sonido.Stream = Properties.Resources.sleep;
                                sonido.Play();
                                palabra = "sleep";
                                seleccion = "correcto";
                                break;
                            case 2:
                                num2 = 1;
                                pb_imagen1.Image = Properties.Resources.swim1;
                                pb_imagen2.Image = Properties.Resources.cook1;
                                sonido.Stream = Properties.Resources.cook;
                                sonido.Play();
                                palabra = "cook";
                                seleccion = "incorrecto";
                                break;
                            case 3:
                                num3 = 1;
                                pb_imagen1.Image = Properties.Resources.cry1;
                                pb_imagen2.Image = Properties.Resources.sleep1;
                                sonido.Stream = Properties.Resources.cry;
                                sonido.Play();
                                palabra = "cry";
                                seleccion = "correcto";
                                break;
                            case 4:
                                num4 = 1;
                                pb_imagen1.Image = Properties.Resources.cook1;
                                pb_imagen2.Image = Properties.Resources.drive1;
                                sonido.Stream = Properties.Resources.drive;
                                sonido.Play();
                                palabra = "drive";
                                seleccion = "incorrecto";
                                break;
                            case 5:
                                num5 = 1;
                                pb_imagen1.Image = Properties.Resources.read1;
                                pb_imagen2.Image = Properties.Resources.cry1;
                                sonido.Stream = Properties.Resources.read;
                                sonido.Play();
                                palabra = "read";
                                seleccion = "correcto";
                                break;
                            case 6:
                                num6 = 1;
                                pb_imagen1.Image = Properties.Resources.drive1;
                                pb_imagen2.Image = Properties.Resources.call1;
                                sonido.Stream = Properties.Resources.call;
                                sonido.Play();
                                palabra = "call";
                                seleccion = "incorrecto";
                                break;
                            case 7:
                                num7 = 1;
                                pb_imagen1.Image = Properties.Resources.run1;
                                pb_imagen2.Image = Properties.Resources.read1;
                                sonido.Stream = Properties.Resources.run;
                                sonido.Play();
                                palabra = "run";
                                seleccion = "correcto";
                                break;
                            case 8:
                                num8 = 1;
                                pb_imagen1.Image = Properties.Resources.call1;
                                pb_imagen2.Image = Properties.Resources.jump1;
                                sonido.Stream = Properties.Resources.jump;
                                sonido.Play();
                                palabra = "jump";
                                seleccion = "incorrecto";
                                break;
                            case 9:
                                num9 = 1;
                                pb_imagen1.Image = Properties.Resources.sing1;
                                pb_imagen2.Image = Properties.Resources.run1;
                                sonido.Stream = Properties.Resources.sing;
                                sonido.Play();
                                palabra = "sing";
                                seleccion = "correcto";
                                break;
                            case 10:
                                num10 = 1;
                                pb_imagen1.Image = Properties.Resources.jump1;
                                pb_imagen2.Image = Properties.Resources.swim1;
                                sonido.Stream = Properties.Resources.swim;
                                sonido.Play();
                                palabra = "swim";
                                seleccion = "incorrecto";
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
                                num1 = 1;
                                pb_imagen1.Image = Properties.Resources.rocket1;
                                pb_imagen2.Image = Properties.Resources.car1;
                                sonido.Stream = Properties.Resources.rocket;
                                sonido.Play();
                                palabra = "rocket";
                                seleccion = "correcto";
                                break;
                            case 2:
                                num2 = 1; 
                                pb_imagen1.Image = Properties.Resources.taxi1;
                                pb_imagen2.Image = Properties.Resources.motorcycle1;
                                sonido.Stream = Properties.Resources.motorcycle;
                                sonido.Play();
                                palabra = "motorcycle";
                                seleccion = "incorrecto";
                                break;
                            case 3:
                                num3 = 1;
                                pb_imagen1.Image = Properties.Resources.bicycle1;
                                pb_imagen2.Image = Properties.Resources.rocket1;
                                sonido.Stream = Properties.Resources.bicycle;
                                sonido.Play();
                                palabra = "bicycle";
                                seleccion = "correcto";
                                break;
                            case 4:
                                num4 = 1;
                                pb_imagen1.Image = Properties.Resources.motorcycle1;
                                pb_imagen2.Image = Properties.Resources.ferry1;
                                sonido.Stream = Properties.Resources.ferry;
                                sonido.Play();
                                palabra = "ferry";
                                seleccion = "incorrecto";
                                break;
                            case 5:
                                num5 = 1;
                                pb_imagen1.Image = Properties.Resources.train1;
                                pb_imagen2.Image = Properties.Resources.bicycle1;
                                sonido.Stream = Properties.Resources.train;
                                sonido.Play();
                                palabra = "train";
                                seleccion = "correcto";
                                break;
                            case 6:
                                num6 = 1;
                                pb_imagen1.Image = Properties.Resources.ferry1;
                                pb_imagen2.Image = Properties.Resources.helicopter1;
                                sonido.Stream = Properties.Resources.helicopter;
                                sonido.Play();
                                palabra = "helicopter";
                                seleccion = "incorrecto";
                                break;
                            case 7:
                                num7 = 1;
                                pb_imagen1.Image = Properties.Resources.bus1;
                                pb_imagen2.Image = Properties.Resources.train1;
                                sonido.Stream = Properties.Resources.bus;
                                sonido.Play();
                                palabra = "bus";
                                seleccion = "correcto";
                                break;
                            case 8:
                                num8 = 1;
                                pb_imagen1.Image = Properties.Resources.helicopter1;
                                pb_imagen2.Image = Properties.Resources.airplane1;
                                sonido.Stream = Properties.Resources.airplane;
                                sonido.Play();
                                palabra = "airplane";
                                seleccion = "incorrecto";
                                break;
                            case 9:
                                num9 = 1;
                                pb_imagen1.Image = Properties.Resources.car1;
                                pb_imagen2.Image = Properties.Resources.bus1;
                                sonido.Stream = Properties.Resources.car;
                                sonido.Play();
                                palabra = "car";
                                seleccion = "correcto";
                                break;
                            case 10:
                                num10 = 1;
                                pb_imagen1.Image = Properties.Resources.airplane1;
                                pb_imagen2.Image = Properties.Resources.taxi1;
                                sonido.Stream = Properties.Resources.taxi;
                                sonido.Play();
                                palabra = "taxi";
                                seleccion = "incorrecto";
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
                                num1 = 1;
                                pb_imagen1.Image = Properties.Resources.soccer1;
                                pb_imagen2.Image = Properties.Resources.running1;
                                sonido.Stream = Properties.Resources.soccer;
                                sonido.Play();
                                palabra = "soccer";
                                seleccion = "correcto";
                                break;
                            case 2:
                                num2 = 1;
                                pb_imagen1.Image = Properties.Resources.golf1;
                                pb_imagen2.Image = Properties.Resources.baseball1;
                                sonido.Stream = Properties.Resources.baseball;
                                sonido.Play();
                                palabra = "baseball";
                                seleccion = "incorrecto";
                                break;
                            case 3:
                                num3 = 1;
                                pb_imagen1.Image = Properties.Resources.volleyball1;
                                pb_imagen2.Image = Properties.Resources.soccer1;
                                sonido.Stream = Properties.Resources.volleyball;
                                sonido.Play();
                                palabra = "volleyball";
                                seleccion = "correcto";
                                break;
                            case 4:
                                num4 = 1;
                                pb_imagen1.Image = Properties.Resources.baseball1;
                                pb_imagen2.Image = Properties.Resources.basketball1;
                                sonido.Stream = Properties.Resources.basketball;
                                sonido.Play();
                                palabra = "basketball";
                                seleccion = "incorrecto";
                                break;
                            case 5:
                                num5 = 1;
                                pb_imagen1.Image = Properties.Resources.tennis1;
                                pb_imagen2.Image = Properties.Resources.volleyball1;
                                sonido.Stream = Properties.Resources.tennis;
                                sonido.Play();
                                palabra = "tennis";
                                seleccion = "correcto";
                                break;
                            case 6:
                                num6 = 1;
                                pb_imagen1.Image = Properties.Resources.basketball1;
                                pb_imagen2.Image = Properties.Resources.cycling1;
                                sonido.Stream = Properties.Resources.cycling;
                                sonido.Play();
                                palabra = "cycling";
                                seleccion = "incorrecto";
                                break;
                            case 7:
                                num7 = 1;
                                pb_imagen1.Image = Properties.Resources.boxing1;
                                pb_imagen2.Image = Properties.Resources.tennis1;
                                sonido.Stream = Properties.Resources.boxing;
                                sonido.Play();
                                palabra = "boxing";
                                seleccion = "correcto";
                                break;
                            case 8:
                                num8 = 1;
                                pb_imagen1.Image = Properties.Resources.cycling1;
                                pb_imagen2.Image = Properties.Resources.surfing1;
                                sonido.Stream = Properties.Resources.surfing;
                                sonido.Play();
                                palabra = "surfing";
                                seleccion = "incorrecto";
                                break;
                            case 9:
                                num9 = 1;
                                pb_imagen1.Image = Properties.Resources.running1;
                                pb_imagen2.Image = Properties.Resources.boxing1;
                                sonido.Stream = Properties.Resources.running;
                                sonido.Play();
                                palabra = "running";
                                seleccion = "correcto";
                                break;
                            case 10:
                                num10 = 1;
                                pb_imagen1.Image = Properties.Resources.surfing1;
                                pb_imagen2.Image = Properties.Resources.golf1;
                                sonido.Stream = Properties.Resources.golf;
                                sonido.Play();
                                palabra = "golf";
                                seleccion = "incorrecto";
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
                                num1 = 1;
                                pb_imagen1.Image = Properties.Resources.sweater1;
                                pb_imagen2.Image = Properties.Resources.shoes1;
                                sonido.Stream = Properties.Resources.sweater;
                                sonido.Play();
                                palabra = "sweater";
                                seleccion = "correcto";
                                break;
                            case 2:
                                num2 = 1;
                                pb_imagen1.Image = Properties.Resources.coat1;
                                pb_imagen2.Image = Properties.Resources.tshirt1;
                                sonido.Stream = Properties.Resources.tshirt;
                                sonido.Play();
                                palabra = "tshirt";
                                seleccion = "incorrecto";
                                break;
                            case 3:
                                num3 = 1;
                                pb_imagen1.Image = Properties.Resources.shirt1;
                                pb_imagen2.Image = Properties.Resources.sweater1;
                                sonido.Stream = Properties.Resources.shirt;
                                sonido.Play();
                                palabra = "shirt";
                                seleccion = "correcto";
                                break;
                            case 4:
                                num4 = 1;
                                pb_imagen1.Image = Properties.Resources.tshirt1;
                                pb_imagen2.Image = Properties.Resources.shorts1;
                                sonido.Stream = Properties.Resources.shorts;
                                sonido.Play();
                                palabra = "shorts";
                                seleccion = "incorrecto";
                                break;
                            case 5:
                                num5 = 1;
                                pb_imagen1.Image = Properties.Resources.skirt1;
                                pb_imagen2.Image = Properties.Resources.shirt1;
                                sonido.Stream = Properties.Resources.skirt;
                                sonido.Play();
                                palabra = "skirt";
                                seleccion = "correcto";
                                break;
                            case 6:
                                num6 = 1;
                                pb_imagen1.Image = Properties.Resources.shorts1;
                                pb_imagen2.Image = Properties.Resources.hat1;
                                sonido.Stream = Properties.Resources.hat;
                                sonido.Play();
                                palabra = "hat";
                                seleccion = "incorrecto";
                                break;
                            case 7:
                                num7 = 1;
                                pb_imagen1.Image = Properties.Resources.pants1;
                                pb_imagen2.Image = Properties.Resources.skirt1;
                                sonido.Stream = Properties.Resources.pants;
                                sonido.Play();
                                palabra = "pants";
                                seleccion = "correcto";
                                break;
                            case 8:
                                num8 = 1;
                                pb_imagen1.Image = Properties.Resources.hat1;
                                pb_imagen2.Image = Properties.Resources.socks1;
                                sonido.Stream = Properties.Resources.socks;
                                sonido.Play();
                                palabra = "socks";
                                seleccion = "incorrecto";
                                break;
                            case 9:
                                num9 = 1;
                                pb_imagen1.Image = Properties.Resources.shoes1;
                                pb_imagen2.Image = Properties.Resources.pants1;
                                sonido.Stream = Properties.Resources.shoes;
                                sonido.Play();
                                palabra = "shoes";
                                seleccion = "correcto";
                                break;
                            case 10:
                                num10 = 1;
                                pb_imagen1.Image = Properties.Resources.socks1;
                                pb_imagen2.Image = Properties.Resources.coat1;
                                sonido.Stream = Properties.Resources.coat;
                                sonido.Play();
                                palabra = "coat";
                                seleccion = "incorrecto";
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
                                num1 = 1;
                                pb_imagen1.Image = Properties.Resources.rice1;
                                pb_imagen2.Image = Properties.Resources.soup1;
                                sonido.Stream = Properties.Resources.rice;
                                sonido.Play();
                                palabra = "rice";
                                seleccion = "correcto";
                                break;
                            case 2:
                                num2 = 1;
                                pb_imagen1.Image = Properties.Resources.eggs1;
                                pb_imagen2.Image = Properties.Resources.grapes1;
                                sonido.Stream = Properties.Resources.grapes;
                                sonido.Play();
                                palabra = "grapes";
                                seleccion = "incorrecto";
                                break;
                            case 3:
                                num3 = 1;
                                pb_imagen1.Image = Properties.Resources.peas1;
                                pb_imagen2.Image = Properties.Resources.rice1;
                                sonido.Stream = Properties.Resources.peas;
                                sonido.Play();
                                palabra = "peas";
                                seleccion = "correcto";
                                break;
                            case 4:
                                num4 = 1;
                                pb_imagen1.Image = Properties.Resources.grapes1;
                                pb_imagen2.Image = Properties.Resources.corn1;
                                sonido.Stream = Properties.Resources.corn;
                                sonido.Play();
                                palabra = "corn";
                                seleccion = "incorrecto";
                                break;
                            case 5:
                                num5 = 1;
                                pb_imagen1.Image = Properties.Resources.onions1;
                                pb_imagen2.Image = Properties.Resources.peas1;
                                sonido.Stream = Properties.Resources.onions;
                                sonido.Play();
                                palabra = "onions";
                                seleccion = "correcto";
                                break;
                            case 6:
                                num6 = 1;
                                pb_imagen1.Image = Properties.Resources.corn1;
                                pb_imagen2.Image = Properties.Resources.carrots1;
                                sonido.Stream = Properties.Resources.carrots;
                                sonido.Play();
                                palabra = "carrots";
                                seleccion = "incorrecto";
                                break;
                            case 7:
                                num7 = 1;
                                pb_imagen1.Image = Properties.Resources.chips1;
                                pb_imagen2.Image = Properties.Resources.onions1;
                                sonido.Stream = Properties.Resources.chips;
                                sonido.Play();
                                palabra = "chips";
                                seleccion = "correcto";
                                break;
                            case 8:
                                num8 = 1;
                                pb_imagen1.Image = Properties.Resources.carrots1;
                                pb_imagen2.Image = Properties.Resources.potatoes1;
                                sonido.Stream = Properties.Resources.potatoes;
                                sonido.Play();
                                palabra = "potatoes";
                                seleccion = "incorrecto";
                                break;
                            case 9:
                                num9 = 1;
                                pb_imagen1.Image = Properties.Resources.soup1;
                                pb_imagen2.Image = Properties.Resources.chips1;
                                sonido.Stream = Properties.Resources.soup;
                                sonido.Play();
                                palabra = "soup";
                                seleccion = "correcto";
                                break;
                            case 10:
                                num10 = 1;
                                pb_imagen1.Image = Properties.Resources.potatoes1;
                                pb_imagen2.Image = Properties.Resources.eggs1;
                                sonido.Stream = Properties.Resources.eggs;
                                sonido.Play();
                                palabra = "eggs";
                                seleccion = "incorrecto";
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
                                num1 = 1;
                                pb_imagen1.Image = Properties.Resources.builder1;
                                pb_imagen2.Image = Properties.Resources.fireman1;
                                sonido.Stream = Properties.Resources.builder;
                                sonido.Play();
                                palabra = "builder";
                                seleccion = "correcto";
                                break;
                            case 2:
                                num2 = 1;
                                pb_imagen1.Image = Properties.Resources.police1;
                                pb_imagen2.Image = Properties.Resources.reporter1;
                                sonido.Stream = Properties.Resources.reporter;
                                sonido.Play();
                                palabra = "reporter";
                                seleccion = "incorrecto";
                                break;
                            case 3:
                                num3 = 1;
                                pb_imagen1.Image = Properties.Resources.vet1;
                                pb_imagen2.Image = Properties.Resources.builder1;
                                sonido.Stream = Properties.Resources.vet;
                                sonido.Play();
                                palabra = "vet";
                                seleccion = "correcto";
                                break;
                            case 4:
                                num4 = 1;
                                pb_imagen1.Image = Properties.Resources.reporter1;
                                pb_imagen2.Image = Properties.Resources.singer1;
                                sonido.Stream = Properties.Resources.singer;
                                sonido.Play();
                                palabra = "singer";
                                seleccion = "incorrecto";
                                break;
                            case 5:
                                num5 = 1;
                                pb_imagen1.Image = Properties.Resources.engineer1;
                                pb_imagen2.Image = Properties.Resources.vet1;
                                sonido.Stream = Properties.Resources.engineer;
                                sonido.Play();
                                palabra = "engineer";
                                seleccion = "correcto";
                                break;
                            case 6:
                                num6 = 1;
                                pb_imagen1.Image = Properties.Resources.singer1;
                                pb_imagen2.Image = Properties.Resources.waiter1;
                                sonido.Stream = Properties.Resources.waiter;
                                sonido.Play();
                                palabra = "waiter";
                                seleccion = "incorrecto";
                                break;
                            case 7:
                                num7 = 1;
                                pb_imagen1.Image = Properties.Resources.dentist1;
                                pb_imagen2.Image = Properties.Resources.engineer1;
                                sonido.Stream = Properties.Resources.dentist;
                                sonido.Play();
                                palabra = "dentist";
                                seleccion = "correcto";
                                break;
                            case 8:
                                num8 = 1;
                                pb_imagen1.Image = Properties.Resources.waiter1;
                                pb_imagen2.Image = Properties.Resources.doctor1;
                                sonido.Stream = Properties.Resources.doctor;
                                sonido.Play();
                                palabra = "doctor";
                                seleccion = "incorrecto";
                                break;
                            case 9:
                                num9 = 1;
                                pb_imagen1.Image = Properties.Resources.fireman1;
                                pb_imagen2.Image = Properties.Resources.dentist1;
                                sonido.Stream = Properties.Resources.fireman;
                                sonido.Play();
                                palabra = "fireman";
                                seleccion = "correcto";
                                break;
                            case 10:
                                num10 = 1;
                                pb_imagen1.Image = Properties.Resources.doctor1;
                                pb_imagen2.Image = Properties.Resources.police1;
                                sonido.Stream = Properties.Resources.police;
                                sonido.Play();
                                palabra = "police";
                                seleccion = "incorrecto";
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
                                num1 = 1;
                                pb_imagen1.Image = Properties.Resources.dog1;
                                pb_imagen2.Image = Properties.Resources.hamster1;
                                sonido.Stream = Properties.Resources.dog;
                                sonido.Play();
                                palabra = "dog";
                                seleccion = "correcto";
                                break;
                            case 2:
                                num2 = 1;
                                pb_imagen1.Image = Properties.Resources.rabbit1;
                                pb_imagen2.Image = Properties.Resources.cow1;
                                sonido.Stream = Properties.Resources.cow;
                                sonido.Play();
                                palabra = "cow";
                                seleccion = "incorrecto";
                                break;
                            case 3:
                                num3 = 1;
                                pb_imagen1.Image = Properties.Resources.sheep1;
                                pb_imagen2.Image = Properties.Resources.dog1;
                                sonido.Stream = Properties.Resources.sheep;
                                sonido.Play();
                                palabra = "sheep";
                                seleccion = "correcto";
                                break;
                            case 4:
                                num4 = 1;
                                pb_imagen1.Image = Properties.Resources.cow1;
                                pb_imagen2.Image = Properties.Resources.pig1;
                                sonido.Stream = Properties.Resources.pig;
                                sonido.Play();
                                palabra = "pig";
                                seleccion = "incorrecto";
                                break;
                            case 5:
                                num5 = 1;
                                pb_imagen1.Image = Properties.Resources.frog1;
                                pb_imagen2.Image = Properties.Resources.sheep1;
                                sonido.Stream = Properties.Resources.frog;
                                sonido.Play();
                                palabra = "frog";
                                seleccion = "correcto";
                                break;
                            case 6:
                                num6 = 1;
                                pb_imagen1.Image = Properties.Resources.pig1;
                                pb_imagen2.Image = Properties.Resources.lizard1;
                                sonido.Stream = Properties.Resources.lizard;
                                sonido.Play();
                                palabra = "lizard";
                                seleccion = "incorrecto";
                                break;
                            case 7:
                                num7 = 1;
                                pb_imagen1.Image = Properties.Resources.spider1;
                                pb_imagen2.Image = Properties.Resources.frog1;
                                sonido.Stream = Properties.Resources.spider;
                                sonido.Play();
                                palabra = "spider";
                                seleccion = "correcto";
                                break;
                            case 8:
                                num8 = 1;
                                pb_imagen1.Image = Properties.Resources.lizard1;
                                pb_imagen2.Image = Properties.Resources.snake1;
                                sonido.Stream = Properties.Resources.snake;
                                sonido.Play();
                                palabra = "snake";
                                seleccion = "incorrecto";
                                break;
                            case 9:
                                num9 = 1;
                                pb_imagen1.Image = Properties.Resources.hamster1;
                                pb_imagen2.Image = Properties.Resources.spider1;
                                sonido.Stream = Properties.Resources.hamster;
                                sonido.Play();
                                palabra = "hamster";
                                seleccion = "correcto";
                                break;
                            case 10:
                                num10 = 1;
                                pb_imagen1.Image = Properties.Resources.snake1;
                                pb_imagen2.Image = Properties.Resources.rabbit1;
                                sonido.Stream = Properties.Resources.rabbit;
                                sonido.Play();
                                palabra = "rabbit";
                                seleccion = "incorrecto";
                                break;
                        }
                    }
                    break;
            }
            
        }


        private void pb_sonido_Click(object sender, EventArgs e)
        {
            switch (topics)
            {
                case "verbs":
                    {
                        switch (palabra)
                        {
                            case "sleep":
                                {
                                    sonido.Stream = Properties.Resources.sleep;
                                    sonido.Play();
                                }
                                break;
                            case "cook":
                                {
                                    sonido.Stream = Properties.Resources.cook;
                                    sonido.Play();
                                }
                                break;
                            case "cry":
                                {
                                    sonido.Stream = Properties.Resources.cry;
                                    sonido.Play();
                                }
                                break;
                            case "read":
                                {
                                    sonido.Stream = Properties.Resources.read;
                                    sonido.Play();
                                }
                                break;
                            case "drive":
                                {
                                    sonido.Stream = Properties.Resources.drive;
                                    sonido.Play();
                                }
                                break;
                            case "call":
                                {
                                    sonido.Stream = Properties.Resources.call;
                                    sonido.Play();
                                }
                                break;
                            case "swim":
                                {
                                    sonido.Stream = Properties.Resources.swim;
                                    sonido.Play();
                                }
                                break;
                            case "run":
                                {
                                    sonido.Stream = Properties.Resources.run;
                                    sonido.Play();
                                }
                                break;
                            case "jump":
                                {
                                    sonido.Stream = Properties.Resources.jump;
                                    sonido.Play();
                                }
                                break;
                            case "sing":
                                {
                                    sonido.Stream = Properties.Resources.sing;
                                    sonido.Play();
                                }
                                break;
                        }
                    }
                    break;
                case "transport":
                    {
                        switch (palabra)
                        {
                            case "rocket":
                                {
                                    sonido.Stream = Properties.Resources.rocket;
                                    sonido.Play();
                                }
                                break;
                            case "motorcycle":
                                {
                                    sonido.Stream = Properties.Resources.motorcycle;
                                    sonido.Play();
                                }
                                break;
                            case "bicycle":
                                {
                                    sonido.Stream = Properties.Resources.bicycle;
                                    sonido.Play();
                                }
                                break;
                            case "ferry":
                                {
                                    sonido.Stream = Properties.Resources.ferry;
                                    sonido.Play();
                                }
                                break;
                            case "train":
                                {
                                    sonido.Stream = Properties.Resources.train;
                                    sonido.Play();
                                }
                                break;
                            case "helicopter":
                                {
                                    sonido.Stream = Properties.Resources.helicopter;
                                    sonido.Play();
                                }
                                break;
                            case "bus":
                                {
                                    sonido.Stream = Properties.Resources.bus;
                                    sonido.Play();
                                }
                                break;
                            case "airplane":
                                {
                                    sonido.Stream = Properties.Resources.airplane;
                                    sonido.Play();
                                }
                                break;
                            case "car":
                                {
                                    sonido.Stream = Properties.Resources.car;
                                    sonido.Play();
                                }
                                break;
                            case "taxi":
                                {
                                    sonido.Stream = Properties.Resources.taxi;
                                    sonido.Play();
                                }
                                break;
                        }
                    }
                    break;
                case "sports":
                    {
                        switch (palabra)
                        {
                            case "soccer":
                                {
                                    sonido.Stream = Properties.Resources.soccer;
                                    sonido.Play();
                                }
                                break;
                            case "baseball":
                                {
                                    sonido.Stream = Properties.Resources.baseball;
                                    sonido.Play();
                                }
                                break;
                            case "volleyball":
                                {
                                    sonido.Stream = Properties.Resources.volleyball;
                                    sonido.Play();
                                }
                                break;
                            case "basketball":
                                {
                                    sonido.Stream = Properties.Resources.basketball;
                                    sonido.Play();
                                }
                                break;
                            case "tennis":
                                {
                                    sonido.Stream = Properties.Resources.tennis;
                                    sonido.Play();
                                }
                                break;
                            case "cycling":
                                {
                                    sonido.Stream = Properties.Resources.cycling;
                                    sonido.Play();
                                }
                                break;
                            case "boxing":
                                {
                                    sonido.Stream = Properties.Resources.boxing;
                                    sonido.Play();
                                }
                                break;
                            case "surfing":
                                {
                                    sonido.Stream = Properties.Resources.surfing;
                                    sonido.Play();
                                }
                                break;
                            case "running":
                                {
                                    sonido.Stream = Properties.Resources.running;
                                    sonido.Play();
                                }
                                break;
                            case "golf":
                                {
                                    sonido.Stream = Properties.Resources.golf;
                                    sonido.Play();
                                }
                                break;
                        }
                    }
                    break;
                case "clothes":
                    {
                        switch (palabra)
                        {
                            case "sweater":
                                {
                                    sonido.Stream = Properties.Resources.sweater;
                                    sonido.Play();
                                }
                                break;
                            case "tshirt":
                                {
                                    sonido.Stream = Properties.Resources.tshirt;
                                    sonido.Play();
                                }
                                break;
                            case "shirt":
                                {
                                    sonido.Stream = Properties.Resources.shirt;
                                    sonido.Play();
                                }
                                break;
                            case "shorts":
                                {
                                    sonido.Stream = Properties.Resources.shorts;
                                    sonido.Play();
                                }
                                break;
                            case "skirt":
                                {
                                    sonido.Stream = Properties.Resources.skirt;
                                    sonido.Play();
                                }
                                break;
                            case "hat":
                                {
                                    sonido.Stream = Properties.Resources.hat;
                                    sonido.Play();
                                }
                                break;
                            case "pants":
                                {
                                    sonido.Stream = Properties.Resources.pants;
                                    sonido.Play();
                                }
                                break;
                            case "socks":
                                {
                                    sonido.Stream = Properties.Resources.socks;
                                    sonido.Play();
                                }
                                break;
                            case "shoes":
                                {
                                    sonido.Stream = Properties.Resources.shoes;
                                    sonido.Play();
                                }
                                break;
                            case "coat":
                                {
                                    sonido.Stream = Properties.Resources.coat;
                                    sonido.Play();
                                }
                                break;
                        }
                    }
                    break;
                case "food":
                    {
                        switch (palabra)
                        {
                            case "rice":
                                {
                                    sonido.Stream = Properties.Resources.rice;
                                    sonido.Play();
                                }
                                break;
                            case "grapes":
                                {
                                    sonido.Stream = Properties.Resources.grapes;
                                    sonido.Play();
                                }
                                break;
                            case "peas":
                                {
                                    sonido.Stream = Properties.Resources.peas;
                                    sonido.Play();
                                }
                                break;
                            case "corn":
                                {
                                    sonido.Stream = Properties.Resources.corn;
                                    sonido.Play();
                                }
                                break;
                            case "onions":
                                {
                                    sonido.Stream = Properties.Resources.onions;
                                    sonido.Play();
                                }
                                break;
                            case "carrots":
                                {
                                    sonido.Stream = Properties.Resources.carrots;
                                    sonido.Play();
                                }
                                break;
                            case "chips":
                                {
                                    sonido.Stream = Properties.Resources.chips;
                                    sonido.Play();
                                }
                                break;
                            case "potatoes":
                                {
                                    sonido.Stream = Properties.Resources.potatoes;
                                    sonido.Play();
                                }
                                break;
                            case "soup":
                                {
                                    sonido.Stream = Properties.Resources.soup;
                                    sonido.Play();
                                }
                                break;
                            case "eggs":
                                {
                                    sonido.Stream = Properties.Resources.eggs;
                                    sonido.Play();
                                }
                                break;
                        }
                    }
                    break;
                case "professions":
                    {
                        switch (palabra)
                        {
                            case "builder":
                                {
                                    sonido.Stream = Properties.Resources.builder;
                                    sonido.Play();
                                }
                                break;
                            case "reporter":
                                {
                                    sonido.Stream = Properties.Resources.reporter;
                                    sonido.Play();
                                }
                                break;
                            case "vet":
                                {
                                    sonido.Stream = Properties.Resources.vet;
                                    sonido.Play();
                                }
                                break;
                            case "singer":
                                {
                                    sonido.Stream = Properties.Resources.singer;
                                    sonido.Play();
                                }
                                break;
                            case "engineer":
                                {
                                    sonido.Stream = Properties.Resources.engineer;
                                    sonido.Play();
                                }
                                break;
                            case "waiter":
                                {
                                    sonido.Stream = Properties.Resources.waiter;
                                    sonido.Play();
                                }
                                break;
                            case "dentist":
                                {
                                    sonido.Stream = Properties.Resources.dentist;
                                    sonido.Play();
                                }
                                break;
                            case "doctor":
                                {
                                    sonido.Stream = Properties.Resources.doctor;
                                    sonido.Play();
                                }
                                break;
                            case "fireman":
                                {
                                    sonido.Stream = Properties.Resources.fireman;
                                    sonido.Play();
                                }
                                break;
                            case "police":
                                {
                                    sonido.Stream = Properties.Resources.police;
                                    sonido.Play();
                                }
                                break;
                        }
                    }
                    break;
                case "animals":
                    {
                        switch (palabra)
                        {
                            case "dog":
                                {
                                    sonido.Stream = Properties.Resources.dog;
                                    sonido.Play();
                                }
                                break;
                            case "cow":
                                {
                                    sonido.Stream = Properties.Resources.cow;
                                    sonido.Play();
                                }
                                break;
                            case "sheep":
                                {
                                    sonido.Stream = Properties.Resources.sheep;
                                    sonido.Play();
                                }
                                break;
                            case "pig":
                                {
                                    sonido.Stream = Properties.Resources.pig;
                                    sonido.Play();
                                }
                                break;
                            case "frog":
                                {
                                    sonido.Stream = Properties.Resources.frog;
                                    sonido.Play();
                                }
                                break;
                            case "lizard":
                                {
                                    sonido.Stream = Properties.Resources.lizard;
                                    sonido.Play();
                                }
                                break;
                            case "spider":
                                {
                                    sonido.Stream = Properties.Resources.spider;
                                    sonido.Play();
                                }
                                break;
                            case "snake":
                                {
                                    sonido.Stream = Properties.Resources.snake;
                                    sonido.Play();
                                }
                                break;
                            case "hamster":
                                {
                                    sonido.Stream = Properties.Resources.hamster;
                                    sonido.Play();
                                }
                                break;
                            case "rabbit":
                                {
                                    sonido.Stream = Properties.Resources.rabbit;
                                    sonido.Play();
                                }
                                break;
                        }
                    }
                    break;
            }
        }

        private void pb_sonido_MouseEnter(object sender, EventArgs e)
        {
            pb_sonido.Size = new System.Drawing.Size(94, 87);
        }

        private void pb_sonido_MouseLeave(object sender, EventArgs e)
        {
            pb_sonido.Size = new System.Drawing.Size(84, 77);
        }

        private void pb_imagen1_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen1.Size = new System.Drawing.Size(210, 191);
        }

        private void pb_imagen1_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen1.Size = new System.Drawing.Size(200, 181);
        }
        private void pb_imagen2_MouseEnter(object sender, EventArgs e)
        {
            pb_imagen2.Size = new System.Drawing.Size(210, 191);
        }

        private void pb_imagen2_MouseLeave(object sender, EventArgs e)
        {
            pb_imagen2.Size = new System.Drawing.Size(200, 181);
        }

        int imagen;
        string seleccion;

        private void pb_imagen1_Click(object sender, EventArgs e)
        {
            imagen = 1;
            if (num1 == 1 && num2 == 1 && num3 == 1 && num4 == 1 && num5 == 1 && num6 == 1 && num7 == 1 && num8 == 1 && num9 == 1 && num10 == 1)
            {
                puntos(imagen, seleccion);
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
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.sleep1;
                                            pb_imagen2.Image = Properties.Resources.sing1;
                                            num1 = 1;
                                            palabra = "sleep";
                                            sonido.Stream = Properties.Resources.sleep;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {

                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.swim1;
                                            pb_imagen2.Image = Properties.Resources.cook1;
                                            num2 = 1;
                                            palabra = "cook";
                                            sonido.Stream = Properties.Resources.cook;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.cry1;
                                            pb_imagen2.Image = Properties.Resources.sleep1;
                                            num3 = 1;
                                            palabra = "cry";
                                            sonido.Stream = Properties.Resources.cry;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.cook1;
                                            pb_imagen2.Image = Properties.Resources.drive1;
                                            num4 = 1;
                                            palabra = "drive";
                                            sonido.Stream = Properties.Resources.drive;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.read1;
                                            pb_imagen2.Image = Properties.Resources.cry1;
                                            num5 = 1;
                                            palabra = "read";
                                            sonido.Stream = Properties.Resources.read;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.drive1;
                                            pb_imagen2.Image = Properties.Resources.call1;
                                            num6 = 1;
                                            palabra = "call";
                                            sonido.Stream = Properties.Resources.call;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.run1;
                                            pb_imagen2.Image = Properties.Resources.read1;
                                            num7 = 1;
                                            palabra = "run";
                                            sonido.Stream = Properties.Resources.run;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.call1;
                                            pb_imagen2.Image = Properties.Resources.jump1;
                                            num8 = 1;
                                            palabra = "jump";
                                            sonido.Stream = Properties.Resources.jump;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.sing1;
                                            pb_imagen2.Image = Properties.Resources.run1;
                                            num9 = 1;
                                            palabra = "sing";
                                            sonido.Stream = Properties.Resources.sing;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.jump1;
                                            pb_imagen2.Image = Properties.Resources.swim1;
                                            num10 = 1;
                                            palabra = "swim";
                                            sonido.Stream = Properties.Resources.swim;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
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
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.rocket1;
                                            pb_imagen2.Image = Properties.Resources.car1;
                                            sonido.Stream = Properties.Resources.rocket;
                                            sonido.Play();
                                            palabra = "rocket";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.taxi1;
                                            pb_imagen2.Image = Properties.Resources.motorcycle1;
                                            sonido.Stream = Properties.Resources.motorcycle;
                                            sonido.Play();
                                            palabra = "motorcycle";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.bicycle1;
                                            pb_imagen2.Image = Properties.Resources.rocket1;
                                            sonido.Stream = Properties.Resources.bicycle;
                                            sonido.Play();
                                            palabra = "bicycle";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.motorcycle1;
                                            pb_imagen2.Image = Properties.Resources.ferry1;
                                            sonido.Stream = Properties.Resources.ferry;
                                            sonido.Play();
                                            palabra = "ferry";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.train1;
                                            pb_imagen2.Image = Properties.Resources.bicycle1;
                                            sonido.Stream = Properties.Resources.train;
                                            sonido.Play();
                                            palabra = "train";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.ferry1;
                                            pb_imagen2.Image = Properties.Resources.helicopter1;
                                            sonido.Stream = Properties.Resources.helicopter;
                                            sonido.Play();
                                            palabra = "helicopter";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.bus1;
                                            pb_imagen2.Image = Properties.Resources.train1;
                                            sonido.Stream = Properties.Resources.bus;
                                            sonido.Play();
                                            palabra = "bus";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.helicopter1;
                                            pb_imagen2.Image = Properties.Resources.airplane1;
                                            sonido.Stream = Properties.Resources.airplane;
                                            sonido.Play();
                                            palabra = "airplane";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.car1;
                                            pb_imagen2.Image = Properties.Resources.bus1;
                                            sonido.Stream = Properties.Resources.car;
                                            sonido.Play();
                                            palabra = "car";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.airplane1;
                                            pb_imagen2.Image = Properties.Resources.taxi1;
                                            sonido.Stream = Properties.Resources.taxi;
                                            sonido.Play();
                                            palabra = "taxi";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
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
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.soccer1;
                                            pb_imagen2.Image = Properties.Resources.running1;
                                            sonido.Stream = Properties.Resources.soccer;
                                            sonido.Play();
                                            palabra = "soccer";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.golf1;
                                            pb_imagen2.Image = Properties.Resources.baseball1;
                                            sonido.Stream = Properties.Resources.baseball;
                                            sonido.Play();
                                            palabra = "baseball";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.volleyball1;
                                            pb_imagen2.Image = Properties.Resources.soccer1;
                                            sonido.Stream = Properties.Resources.volleyball;
                                            sonido.Play();
                                            palabra = "volleyball";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.baseball1;
                                            pb_imagen2.Image = Properties.Resources.basketball1;
                                            sonido.Stream = Properties.Resources.basketball;
                                            sonido.Play();
                                            palabra = "basketball";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.tennis1;
                                            pb_imagen2.Image = Properties.Resources.volleyball1;
                                            sonido.Stream = Properties.Resources.tennis;
                                            sonido.Play();
                                            palabra = "tennis";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.basketball1;
                                            pb_imagen2.Image = Properties.Resources.cycling1;
                                            sonido.Stream = Properties.Resources.cycling;
                                            sonido.Play();
                                            palabra = "cycling";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.boxing1;
                                            pb_imagen2.Image = Properties.Resources.tennis1;
                                            sonido.Stream = Properties.Resources.boxing;
                                            sonido.Play();
                                            palabra = "boxing";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.cycling1;
                                            pb_imagen2.Image = Properties.Resources.surfing1;
                                            sonido.Stream = Properties.Resources.surfing;
                                            sonido.Play();
                                            palabra = "surfing";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.running1;
                                            pb_imagen2.Image = Properties.Resources.boxing1;
                                            sonido.Stream = Properties.Resources.running;
                                            sonido.Play();
                                            palabra = "running";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.surfing1;
                                            pb_imagen2.Image = Properties.Resources.golf1;
                                            sonido.Stream = Properties.Resources.golf;
                                            sonido.Play();
                                            palabra = "golf";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
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
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.sweater1;
                                            pb_imagen2.Image = Properties.Resources.shoes1;
                                            sonido.Stream = Properties.Resources.sweater;
                                            sonido.Play();
                                            palabra = "sweater";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {

                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.coat1;
                                            pb_imagen2.Image = Properties.Resources.tshirt1;
                                            sonido.Stream = Properties.Resources.tshirt;
                                            sonido.Play();
                                            palabra = "tshirt";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.shirt1;
                                            pb_imagen2.Image = Properties.Resources.sweater1;
                                            sonido.Stream = Properties.Resources.shirt;
                                            sonido.Play();
                                            palabra = "shirt";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.tshirt1;
                                            pb_imagen2.Image = Properties.Resources.shorts1;
                                            sonido.Stream = Properties.Resources.shorts;
                                            sonido.Play();
                                            palabra = "shorts";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.skirt1;
                                            pb_imagen2.Image = Properties.Resources.shirt1;
                                            sonido.Stream = Properties.Resources.skirt;
                                            sonido.Play();
                                            palabra = "skirt";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.shorts1;
                                            pb_imagen2.Image = Properties.Resources.hat1;
                                            sonido.Stream = Properties.Resources.hat;
                                            sonido.Play();
                                            palabra = "hat";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.pants1;
                                            pb_imagen2.Image = Properties.Resources.skirt1;
                                            sonido.Stream = Properties.Resources.pants;
                                            sonido.Play();
                                            palabra = "pants";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.hat1;
                                            pb_imagen2.Image = Properties.Resources.socks1;
                                            sonido.Stream = Properties.Resources.socks;
                                            sonido.Play();
                                            palabra = "socks";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.shoes1;
                                            pb_imagen2.Image = Properties.Resources.pants1;
                                            sonido.Stream = Properties.Resources.shoes;
                                            sonido.Play();
                                            palabra = "shoes";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.socks1;
                                            pb_imagen2.Image = Properties.Resources.coat1;
                                            sonido.Stream = Properties.Resources.coat;
                                            sonido.Play();
                                            palabra = "coat";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
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
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.rice1;
                                            pb_imagen2.Image = Properties.Resources.soup1;
                                            sonido.Stream = Properties.Resources.rice;
                                            sonido.Play();
                                            palabra = "rice";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {

                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.eggs1;
                                            pb_imagen2.Image = Properties.Resources.grapes1;
                                            sonido.Stream = Properties.Resources.grapes;
                                            sonido.Play();
                                            palabra = "grapes";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.peas1;
                                            pb_imagen2.Image = Properties.Resources.rice1;
                                            sonido.Stream = Properties.Resources.peas;
                                            sonido.Play();
                                            palabra = "peas";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.grapes1;
                                            pb_imagen2.Image = Properties.Resources.corn1;
                                            sonido.Stream = Properties.Resources.corn;
                                            sonido.Play();
                                            palabra = "corn";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.onions1;
                                            pb_imagen2.Image = Properties.Resources.peas1;
                                            sonido.Stream = Properties.Resources.onions;
                                            sonido.Play();
                                            palabra = "onions";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.corn1;
                                            pb_imagen2.Image = Properties.Resources.carrots1;
                                            sonido.Stream = Properties.Resources.carrots;
                                            sonido.Play();
                                            palabra = "carrots";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.chips1;
                                            pb_imagen2.Image = Properties.Resources.onions1;
                                            sonido.Stream = Properties.Resources.chips;
                                            sonido.Play();
                                            palabra = "chips";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.carrots1;
                                            pb_imagen2.Image = Properties.Resources.potatoes1;
                                            sonido.Stream = Properties.Resources.potatoes;
                                            sonido.Play();
                                            palabra = "potatoes";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.soup1;
                                            pb_imagen2.Image = Properties.Resources.chips1;
                                            sonido.Stream = Properties.Resources.soup;
                                            sonido.Play();
                                            palabra = "soup";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.potatoes1;
                                            pb_imagen2.Image = Properties.Resources.eggs1;
                                            sonido.Stream = Properties.Resources.eggs;
                                            sonido.Play();
                                            palabra = "eggs";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
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
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.builder1;
                                            pb_imagen2.Image = Properties.Resources.fireman1;
                                            sonido.Stream = Properties.Resources.builder;
                                            sonido.Play();
                                            palabra = "builder";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {

                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.police1;
                                            pb_imagen2.Image = Properties.Resources.reporter1;
                                            sonido.Stream = Properties.Resources.reporter;
                                            sonido.Play();
                                            palabra = "reporter";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.vet1;
                                            pb_imagen2.Image = Properties.Resources.builder1;
                                            sonido.Stream = Properties.Resources.vet;
                                            sonido.Play();
                                            palabra = "vet";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.reporter1;
                                            pb_imagen2.Image = Properties.Resources.singer1;
                                            sonido.Stream = Properties.Resources.singer;
                                            sonido.Play();
                                            palabra = "singer";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.engineer1;
                                            pb_imagen2.Image = Properties.Resources.vet1;
                                            sonido.Stream = Properties.Resources.engineer;
                                            sonido.Play();
                                            palabra = "engineer";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.singer1;
                                            pb_imagen2.Image = Properties.Resources.waiter1;
                                            sonido.Stream = Properties.Resources.waiter;
                                            sonido.Play();
                                            palabra = "waiter";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.dentist1;
                                            pb_imagen2.Image = Properties.Resources.engineer1;
                                            sonido.Stream = Properties.Resources.dentist;
                                            sonido.Play();
                                            palabra = "dentist";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.waiter1;
                                            pb_imagen2.Image = Properties.Resources.doctor1;
                                            sonido.Stream = Properties.Resources.doctor;
                                            sonido.Play();
                                            palabra = "doctor";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.fireman1;
                                            pb_imagen2.Image = Properties.Resources.dentist1;
                                            sonido.Stream = Properties.Resources.fireman;
                                            sonido.Play();
                                            palabra = "fireman";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.doctor1;
                                            pb_imagen2.Image = Properties.Resources.police1;
                                            sonido.Stream = Properties.Resources.police;
                                            sonido.Play();
                                            palabra = "police";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
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
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.dog1;
                                            pb_imagen2.Image = Properties.Resources.hamster1;
                                            sonido.Stream = Properties.Resources.dog;
                                            sonido.Play();
                                            palabra = "dog";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.rabbit1;
                                            pb_imagen2.Image = Properties.Resources.cow1;
                                            sonido.Stream = Properties.Resources.cow;
                                            sonido.Play();
                                            palabra = "cow";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.sheep1;
                                            pb_imagen2.Image = Properties.Resources.dog1;
                                            sonido.Stream = Properties.Resources.sheep;
                                            sonido.Play();
                                            palabra = "sheep";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.cow1;
                                            pb_imagen2.Image = Properties.Resources.pig1;
                                            sonido.Stream = Properties.Resources.pig;
                                            sonido.Play();
                                            palabra = "pig";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.frog1;
                                            pb_imagen2.Image = Properties.Resources.sheep1;
                                            sonido.Stream = Properties.Resources.frog;
                                            sonido.Play();
                                            palabra = "frog";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.pig1;
                                            pb_imagen2.Image = Properties.Resources.lizard1;
                                            sonido.Stream = Properties.Resources.lizard;
                                            sonido.Play();
                                            palabra = "lizard";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.spider1;
                                            pb_imagen2.Image = Properties.Resources.frog1;
                                            sonido.Stream = Properties.Resources.spider;
                                            sonido.Play();
                                            palabra = "spider";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.lizard1;
                                            pb_imagen2.Image = Properties.Resources.snake1;
                                            sonido.Stream = Properties.Resources.snake;
                                            sonido.Play();
                                            palabra = "snake";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.hamster1;
                                            pb_imagen2.Image = Properties.Resources.spider1;
                                            sonido.Stream = Properties.Resources.hamster;
                                            sonido.Play();
                                            palabra = "hamster";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen1_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.snake1;
                                            pb_imagen2.Image = Properties.Resources.rabbit1;
                                            sonido.Stream = Properties.Resources.rabbit;
                                            sonido.Play();
                                            palabra = "rabbit";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen1_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                }
                segundo = seg;
                timer1.Enabled = true;
                lbl_tiempo.Text = segundo.ToString();
            }


        }

        private void pb_imagen2_Click(object sender, EventArgs e)
        {
            imagen = 2;
            if (num1 == 1 && num2 == 1 && num3 == 1 && num4 == 1 && num5 == 1 && num6 == 1 && num7 == 1 && num8 == 1 && num9 == 1 && num10 == 1)
            {
                puntos(imagen, seleccion);
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
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.sleep1;
                                            pb_imagen2.Image = Properties.Resources.sing1;
                                            num1 = 1;
                                            palabra = "sleep";
                                            sonido.Stream = Properties.Resources.sleep;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {

                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.swim1;
                                            pb_imagen2.Image = Properties.Resources.cook1;
                                            num2 = 1;
                                            palabra = "cook";
                                            sonido.Stream = Properties.Resources.cook;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.cry1;
                                            pb_imagen2.Image = Properties.Resources.sleep1;
                                            num3 = 1;
                                            palabra = "cry";
                                            sonido.Stream = Properties.Resources.cry;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.cook1;
                                            pb_imagen2.Image = Properties.Resources.drive1;
                                            num4 = 1;
                                            palabra = "drive";
                                            sonido.Stream = Properties.Resources.drive;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.read1;
                                            pb_imagen2.Image = Properties.Resources.cry1;
                                            num5 = 1;
                                            palabra = "read";
                                            sonido.Stream = Properties.Resources.read;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.drive1;
                                            pb_imagen2.Image = Properties.Resources.call1;
                                            num6 = 1;
                                            palabra = "call";
                                            sonido.Stream = Properties.Resources.call;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.run1;
                                            pb_imagen2.Image = Properties.Resources.read1;
                                            num7 = 1;
                                            palabra = "run";
                                            sonido.Stream = Properties.Resources.run;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.call1;
                                            pb_imagen2.Image = Properties.Resources.jump1;
                                            num8 = 1;
                                            palabra = "jump";
                                            sonido.Stream = Properties.Resources.jump;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.sing1;
                                            pb_imagen2.Image = Properties.Resources.run1;
                                            num9 = 1;
                                            palabra = "sing";
                                            sonido.Stream = Properties.Resources.sing;
                                            sonido.Play();
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            pb_imagen1.Image = Properties.Resources.jump1;
                                            pb_imagen2.Image = Properties.Resources.swim1;
                                            num10 = 1;
                                            palabra = "swim";
                                            sonido.Stream = Properties.Resources.swim;
                                            sonido.Play();
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
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
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.rocket1;
                                            pb_imagen2.Image = Properties.Resources.car1;
                                            sonido.Stream = Properties.Resources.rocket;
                                            sonido.Play();
                                            palabra = "rocket";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.taxi1;
                                            pb_imagen2.Image = Properties.Resources.motorcycle1;
                                            sonido.Stream = Properties.Resources.motorcycle;
                                            sonido.Play();
                                            palabra = "motorcycle";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.bicycle1;
                                            pb_imagen2.Image = Properties.Resources.rocket1;
                                            sonido.Stream = Properties.Resources.bicycle;
                                            sonido.Play();
                                            palabra = "bicycle";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.motorcycle1;
                                            pb_imagen2.Image = Properties.Resources.ferry1;
                                            sonido.Stream = Properties.Resources.ferry;
                                            sonido.Play();
                                            palabra = "ferry";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.train1;
                                            pb_imagen2.Image = Properties.Resources.bicycle1;
                                            sonido.Stream = Properties.Resources.train;
                                            sonido.Play();
                                            palabra = "train";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.ferry1;
                                            pb_imagen2.Image = Properties.Resources.helicopter1;
                                            sonido.Stream = Properties.Resources.helicopter;
                                            sonido.Play();
                                            palabra = "helicopter";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.bus1;
                                            pb_imagen2.Image = Properties.Resources.train1;
                                            sonido.Stream = Properties.Resources.bus;
                                            sonido.Play();
                                            palabra = "bus";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.helicopter1;
                                            pb_imagen2.Image = Properties.Resources.airplane1;
                                            sonido.Stream = Properties.Resources.airplane;
                                            sonido.Play();
                                            palabra = "airplane";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.car1;
                                            pb_imagen2.Image = Properties.Resources.bus1;
                                            sonido.Stream = Properties.Resources.car;
                                            sonido.Play();
                                            palabra = "car";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.airplane1;
                                            pb_imagen2.Image = Properties.Resources.taxi1;
                                            sonido.Stream = Properties.Resources.taxi;
                                            sonido.Play();
                                            palabra = "taxi";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
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
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.soccer1;
                                            pb_imagen2.Image = Properties.Resources.running1;
                                            sonido.Stream = Properties.Resources.soccer;
                                            sonido.Play();
                                            palabra = "soccer";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.golf1;
                                            pb_imagen2.Image = Properties.Resources.baseball1;
                                            sonido.Stream = Properties.Resources.baseball;
                                            sonido.Play();
                                            palabra = "baseball";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.volleyball1;
                                            pb_imagen2.Image = Properties.Resources.soccer1;
                                            sonido.Stream = Properties.Resources.volleyball;
                                            sonido.Play();
                                            palabra = "volleyball";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.baseball1;
                                            pb_imagen2.Image = Properties.Resources.basketball1;
                                            sonido.Stream = Properties.Resources.basketball;
                                            sonido.Play();
                                            palabra = "basketball";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.tennis1;
                                            pb_imagen2.Image = Properties.Resources.volleyball1;
                                            sonido.Stream = Properties.Resources.tennis;
                                            sonido.Play();
                                            palabra = "tennis";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.basketball1;
                                            pb_imagen2.Image = Properties.Resources.cycling1;
                                            sonido.Stream = Properties.Resources.cycling;
                                            sonido.Play();
                                            palabra = "cycling";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.boxing1;
                                            pb_imagen2.Image = Properties.Resources.tennis1;
                                            sonido.Stream = Properties.Resources.boxing;
                                            sonido.Play();
                                            palabra = "boxing";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.cycling1;
                                            pb_imagen2.Image = Properties.Resources.surfing1;
                                            sonido.Stream = Properties.Resources.surfing;
                                            sonido.Play();
                                            palabra = "surfing";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.running1;
                                            pb_imagen2.Image = Properties.Resources.boxing1;
                                            sonido.Stream = Properties.Resources.running;
                                            sonido.Play();
                                            palabra = "running";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.surfing1;
                                            pb_imagen2.Image = Properties.Resources.golf1;
                                            sonido.Stream = Properties.Resources.golf;
                                            sonido.Play();
                                            palabra = "golf";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
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
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.sweater1;
                                            pb_imagen2.Image = Properties.Resources.shoes1;
                                            sonido.Stream = Properties.Resources.sweater;
                                            sonido.Play();
                                            palabra = "sweater";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {

                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.coat1;
                                            pb_imagen2.Image = Properties.Resources.tshirt1;
                                            sonido.Stream = Properties.Resources.tshirt;
                                            sonido.Play();
                                            palabra = "tshirt";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.shirt1;
                                            pb_imagen2.Image = Properties.Resources.sweater1;
                                            sonido.Stream = Properties.Resources.shirt;
                                            sonido.Play();
                                            palabra = "shirt";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.tshirt1;
                                            pb_imagen2.Image = Properties.Resources.shorts1;
                                            sonido.Stream = Properties.Resources.shorts;
                                            sonido.Play();
                                            palabra = "shorts";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.skirt1;
                                            pb_imagen2.Image = Properties.Resources.shirt1;
                                            sonido.Stream = Properties.Resources.skirt;
                                            sonido.Play();
                                            palabra = "skirt";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.shorts1;
                                            pb_imagen2.Image = Properties.Resources.hat1;
                                            sonido.Stream = Properties.Resources.hat;
                                            sonido.Play();
                                            palabra = "hat";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.pants1;
                                            pb_imagen2.Image = Properties.Resources.skirt1;
                                            sonido.Stream = Properties.Resources.pants;
                                            sonido.Play();
                                            palabra = "pants";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.hat1;
                                            pb_imagen2.Image = Properties.Resources.socks1;
                                            sonido.Stream = Properties.Resources.socks;
                                            sonido.Play();
                                            palabra = "socks";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.shoes1;
                                            pb_imagen2.Image = Properties.Resources.pants1;
                                            sonido.Stream = Properties.Resources.shoes;
                                            sonido.Play();
                                            palabra = "shoes";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.socks1;
                                            pb_imagen2.Image = Properties.Resources.coat1;
                                            sonido.Stream = Properties.Resources.coat;
                                            sonido.Play();
                                            palabra = "coat";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
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
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.rice1;
                                            pb_imagen2.Image = Properties.Resources.soup1;
                                            sonido.Stream = Properties.Resources.rice;
                                            sonido.Play();
                                            palabra = "rice";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {

                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.eggs1;
                                            pb_imagen2.Image = Properties.Resources.grapes1;
                                            sonido.Stream = Properties.Resources.grapes;
                                            sonido.Play();
                                            palabra = "grapes";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.peas1;
                                            pb_imagen2.Image = Properties.Resources.rice1;
                                            sonido.Stream = Properties.Resources.peas;
                                            sonido.Play();
                                            palabra = "peas";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.grapes1;
                                            pb_imagen2.Image = Properties.Resources.corn1;
                                            sonido.Stream = Properties.Resources.corn;
                                            sonido.Play();
                                            palabra = "corn";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.onions1;
                                            pb_imagen2.Image = Properties.Resources.peas1;
                                            sonido.Stream = Properties.Resources.onions;
                                            sonido.Play();
                                            palabra = "onions";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.corn1;
                                            pb_imagen2.Image = Properties.Resources.carrots1;
                                            sonido.Stream = Properties.Resources.carrots;
                                            sonido.Play();
                                            palabra = "carrots";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.chips1;
                                            pb_imagen2.Image = Properties.Resources.onions1;
                                            sonido.Stream = Properties.Resources.chips;
                                            sonido.Play();
                                            palabra = "chips";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.carrots1;
                                            pb_imagen2.Image = Properties.Resources.potatoes1;
                                            sonido.Stream = Properties.Resources.potatoes;
                                            sonido.Play();
                                            palabra = "potatoes";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.soup1;
                                            pb_imagen2.Image = Properties.Resources.chips1;
                                            sonido.Stream = Properties.Resources.soup;
                                            sonido.Play();
                                            palabra = "soup";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.potatoes1;
                                            pb_imagen2.Image = Properties.Resources.eggs1;
                                            sonido.Stream = Properties.Resources.eggs;
                                            sonido.Play();
                                            palabra = "eggs";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
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
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.builder1;
                                            pb_imagen2.Image = Properties.Resources.fireman1;
                                            sonido.Stream = Properties.Resources.builder;
                                            sonido.Play();
                                            palabra = "builder";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {

                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.police1;
                                            pb_imagen2.Image = Properties.Resources.reporter1;
                                            sonido.Stream = Properties.Resources.reporter;
                                            sonido.Play();
                                            palabra = "reporter";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.vet1;
                                            pb_imagen2.Image = Properties.Resources.builder1;
                                            sonido.Stream = Properties.Resources.vet;
                                            sonido.Play();
                                            palabra = "vet";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.reporter1;
                                            pb_imagen2.Image = Properties.Resources.singer1;
                                            sonido.Stream = Properties.Resources.singer;
                                            sonido.Play();
                                            palabra = "singer";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.engineer1;
                                            pb_imagen2.Image = Properties.Resources.vet1;
                                            sonido.Stream = Properties.Resources.engineer;
                                            sonido.Play();
                                            palabra = "engineer";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.singer1;
                                            pb_imagen2.Image = Properties.Resources.waiter1;
                                            sonido.Stream = Properties.Resources.waiter;
                                            sonido.Play();
                                            palabra = "waiter";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.dentist1;
                                            pb_imagen2.Image = Properties.Resources.engineer1;
                                            sonido.Stream = Properties.Resources.dentist;
                                            sonido.Play();
                                            palabra = "dentist";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.waiter1;
                                            pb_imagen2.Image = Properties.Resources.doctor1;
                                            sonido.Stream = Properties.Resources.doctor;
                                            sonido.Play();
                                            palabra = "doctor";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.fireman1;
                                            pb_imagen2.Image = Properties.Resources.dentist1;
                                            sonido.Stream = Properties.Resources.fireman;
                                            sonido.Play();
                                            palabra = "fireman";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.doctor1;
                                            pb_imagen2.Image = Properties.Resources.police1;
                                            sonido.Stream = Properties.Resources.police;
                                            sonido.Play();
                                            palabra = "police";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
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
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num1 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num1 = 1;
                                            pb_imagen1.Image = Properties.Resources.dog1;
                                            pb_imagen2.Image = Properties.Resources.hamster1;
                                            sonido.Stream = Properties.Resources.dog;
                                            sonido.Play();
                                            palabra = "dog";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 2:
                                    if (random == 2)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num2 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num2 = 1;
                                            pb_imagen1.Image = Properties.Resources.rabbit1;
                                            pb_imagen2.Image = Properties.Resources.cow1;
                                            sonido.Stream = Properties.Resources.cow;
                                            sonido.Play();
                                            palabra = "cow";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 3:
                                    if (random == 3)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num3 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num3 = 1;
                                            pb_imagen1.Image = Properties.Resources.sheep1;
                                            pb_imagen2.Image = Properties.Resources.dog1;
                                            sonido.Stream = Properties.Resources.sheep;
                                            sonido.Play();
                                            palabra = "sheep";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 4:
                                    if (random == 4)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num4 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num4 = 1;
                                            pb_imagen1.Image = Properties.Resources.cow1;
                                            pb_imagen2.Image = Properties.Resources.pig1;
                                            sonido.Stream = Properties.Resources.pig;
                                            sonido.Play();
                                            palabra = "pig";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 5:
                                    if (random == 5)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num5 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num5 = 1;
                                            pb_imagen1.Image = Properties.Resources.frog1;
                                            pb_imagen2.Image = Properties.Resources.sheep1;
                                            sonido.Stream = Properties.Resources.frog;
                                            sonido.Play();
                                            palabra = "frog";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 6:
                                    if (random == 6)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num6 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num6 = 1;
                                            pb_imagen1.Image = Properties.Resources.pig1;
                                            pb_imagen2.Image = Properties.Resources.lizard1;
                                            sonido.Stream = Properties.Resources.lizard;
                                            sonido.Play();
                                            palabra = "lizard";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 7:
                                    if (random == 7)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num7 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num7 = 1;
                                            pb_imagen1.Image = Properties.Resources.spider1;
                                            pb_imagen2.Image = Properties.Resources.frog1;
                                            sonido.Stream = Properties.Resources.spider;
                                            sonido.Play();
                                            palabra = "spider";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 8:
                                    if (random == 8)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num8 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num8 = 1;
                                            pb_imagen1.Image = Properties.Resources.lizard1;
                                            pb_imagen2.Image = Properties.Resources.snake1;
                                            sonido.Stream = Properties.Resources.snake;
                                            sonido.Play();
                                            palabra = "snake";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 9:
                                    if (random == 9)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num9 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num9 = 1;
                                            pb_imagen1.Image = Properties.Resources.hamster1;
                                            pb_imagen2.Image = Properties.Resources.spider1;
                                            sonido.Stream = Properties.Resources.hamster;
                                            sonido.Play();
                                            palabra = "hamster";
                                            seleccion = "correcto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                                case 10:
                                    if (random == 10)
                                    {
                                        pb_imagen2_Click(sender, e);
                                    }
                                    else
                                    {
                                        if (num10 == 0)
                                        {
                                            puntos(imagen, seleccion);
                                            num10 = 1;
                                            pb_imagen1.Image = Properties.Resources.snake1;
                                            pb_imagen2.Image = Properties.Resources.rabbit1;
                                            sonido.Stream = Properties.Resources.rabbit;
                                            sonido.Play();
                                            palabra = "rabbit";
                                            seleccion = "incorrecto";
                                        }
                                        else
                                        {
                                            pb_imagen2_Click(sender, e);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                }
                segundo = seg;
                timer1.Enabled = true;
                lbl_tiempo.Text = segundo.ToString();
            }


        }

        private void puntos(int image, string selec)
        {
            if (image == 1 && selec == "correcto")
            {
                sonido.Stream = Properties.Resources.correcto;
                sonido.PlaySync();
                cont++;
            }
            if (image == 1 && selec == "incorrecto")
            {
                sonido.Stream = Properties.Resources.incorrecto;
                sonido.PlaySync();
            }
            if (image == 2 && selec == "correcto")
            {
                sonido.Stream = Properties.Resources.incorrecto;
                sonido.PlaySync();
            }
            if (image == 2 && selec == "incorrecto")
            {
                sonido.Stream = Properties.Resources.correcto;
                sonido.PlaySync();
                cont++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            lbl_tiempo.Text = segundo.ToString();
            if (segundo == 0)
            {
                timer1.Enabled = false;
                imagen = 1;
                seleccion = "incorrecto";
                pb_imagen1_Click(sender, e);

            }
        }
    }
}