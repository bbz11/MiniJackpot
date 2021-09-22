using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniJackpot
{
    //TODO
    //kad se prede preko button za odabrat highlightat te 3 kocke koje cemo uzet
    //slike arrowa na button umjesto ovih ruznih
    //neka pozadina, uredit malo izgled opcenito da nije samo sivo sve
    //prosirit app tako da je ovo samo jedan dio, a kredit se prenosi medusobno, pamti kredit i nakon izlaska iz aplikacije

    public partial class Form1 : Form
    {
        //varijable
        int[] listaBrojeva;
        int brojpokusaja = 3;
        private int zbroj;
        int stanje = 2500;
        public int Zbroj { get => zbroj; set => zbroj = value; }

        //funkcije
        private void RandomizirajBrojeve()
        {
            IEnumerable<int> randomBrojevi = Enumerable.Range(1, 9);
            listaBrojeva = randomBrojevi.ToArray();
            var rng = new Random();
            rng.Shuffle(listaBrojeva);
        }
        private void SmanjiBrojPokusaja()
        {

            brojpokusaja--;
            if (brojpokusaja == 0)
            {
                //zamrzni buttone za brojeve i odmrzni buttone za selectat
                PromjeniButtoneEnabled();

            }
        }
        private void PromjeniButtoneEnabled()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
        }
        private void Resetajbuttone()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button1.Text = "?";
            button2.Text = "?";
            button3.Text = "?";
            button4.Text = "?";
            button5.Text = "?";
            button6.Text = "?";
            button7.Text = "?";
            button8.Text = "?";
            button9.Text = "?";
            button1.BackColor = SystemColors.Control;
            button1.UseVisualStyleBackColor = true;
            button2.BackColor = SystemColors.Control;
            button2.UseVisualStyleBackColor = true;
            button3.BackColor = SystemColors.Control;
            button3.UseVisualStyleBackColor = true;
            button4.BackColor = SystemColors.Control;
            button4.UseVisualStyleBackColor = true;
            button5.BackColor = SystemColors.Control;
            button5.UseVisualStyleBackColor = true;
            button6.BackColor = SystemColors.Control;
            button6.UseVisualStyleBackColor = true;
            button7.BackColor = SystemColors.Control;
            button7.UseVisualStyleBackColor = true;
            button8.BackColor = SystemColors.Control;
            button8.UseVisualStyleBackColor = true;
            button9.BackColor = SystemColors.Control;
            button9.UseVisualStyleBackColor = true;

        }
        private void IzracunajZbroj(int zbroj)
        {
            label3.Text = "Zadnji broj: " + zbroj.ToString();
            switch (zbroj)
            {
                case 6:
                    stanje += 10000;
                    break;
                case 7:
                    stanje += 100;
                    break;
                case 8:
                    stanje += 50;
                    break;
                case 9:
                    stanje += 900;
                    break;
                case 10:
                    stanje += 4200;
                    break;
                case 11:
                    stanje += 200;
                    break;
                case 12:
                    stanje += 150;
                    break;
                case 13:
                    stanje += 50;
                    break;
                case 14:
                    stanje += 2500;
                    break;
                case 15:
                    stanje += 150;
                    break;
                case 16:
                    stanje += 0;
                    break;
                case 17:
                    stanje += 100;
                    break;
                case 18:
                    stanje += 550;
                    break;
                case 19:
                    stanje += 300;
                    break;
                case 20:
                    stanje += 550;
                    break;
                case 21:
                    stanje += 700;
                    break;
                case 22:
                    stanje += 450;
                    break;
                case 23:
                    stanje += 1800;
                    break;
                case 24:
                    stanje += 3600;
                    break;
            }
            UpdateStanje();
        }
        private void ZakljucajButtone()
        {
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button1.Text = listaBrojeva[0].ToString();
            button2.Text = listaBrojeva[1].ToString();
            button3.Text = listaBrojeva[2].ToString();
            button4.Text = listaBrojeva[3].ToString();
            button5.Text = listaBrojeva[4].ToString();
            button6.Text = listaBrojeva[5].ToString();
            button7.Text = listaBrojeva[6].ToString();
            button8.Text = listaBrojeva[7].ToString();
            button9.Text = listaBrojeva[8].ToString();
        }
        private void OtkrijPrviBroj()
        {
            if (brojpokusaja == 3)
            {
                Random rnd = new Random();
                int rndPrvi = rnd.Next(1, 10);
                switch (rndPrvi)
                {
                    case 1:
                        button1.Text = listaBrojeva[0].ToString();
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = listaBrojeva[1].ToString();
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = listaBrojeva[2].ToString();
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = listaBrojeva[3].ToString();
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = listaBrojeva[4].ToString();
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = listaBrojeva[5].ToString();
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = listaBrojeva[6].ToString();
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = listaBrojeva[7].ToString();
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = listaBrojeva[8].ToString();
                        button9.Enabled = false;
                        break;
                }
            }

        }
        public Form1()
        {
            InitializeComponent();

            button1.Font = new Font("Microsoft Sans Serif", 25);
            button2.Font = new Font("Microsoft Sans Serif", 25);
            button3.Font = new Font("Microsoft Sans Serif", 25);
            button4.Font = new Font("Microsoft Sans Serif", 25);
            button5.Font = new Font("Microsoft Sans Serif", 25);
            button6.Font = new Font("Microsoft Sans Serif", 25);
            button7.Font = new Font("Microsoft Sans Serif", 25);
            button8.Font = new Font("Microsoft Sans Serif", 25);
            button9.Font = new Font("Microsoft Sans Serif", 25);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CheckStanje();
            OtkrijPrviBroj();
        }
        private void UpdateStanje()
        {
            label2.Text = stanje.ToString() + " kredita.";
        }
        private void CheckStanje()
        {
            if (stanje >= 500)
            {
                RandomizirajBrojeve();
                Resetajbuttone();
                brojpokusaja = 3;
                stanje -= 500;
                UpdateStanje();
            }
            else { MessageBox.Show("Nemate dovoljno kredita, minimalan iznos za igru je 500."); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckStanje();
            OtkrijPrviBroj();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izaći iz aplikacije?", "Izlaz", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Text = listaBrojeva[2].ToString();
            SmanjiBrojPokusaja();
            button3.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = listaBrojeva[0].ToString();
            SmanjiBrojPokusaja();
            button1.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Text = listaBrojeva[1].ToString();
            SmanjiBrojPokusaja();
            button2.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = listaBrojeva[3].ToString();
            SmanjiBrojPokusaja();
            button4.Enabled = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Text = listaBrojeva[4].ToString();
            SmanjiBrojPokusaja();
            button5.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button6.Text = listaBrojeva[5].ToString();
            SmanjiBrojPokusaja();
            button6.Enabled = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button7.Text = listaBrojeva[6].ToString();
            SmanjiBrojPokusaja();
            button7.Enabled = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button8.Text = listaBrojeva[7].ToString();
            SmanjiBrojPokusaja();
            button8.Enabled = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button9.Text = listaBrojeva[8].ToString();
            SmanjiBrojPokusaja();
            button9.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            IzracunajZbroj(Zbroj = listaBrojeva[0] + listaBrojeva[1] + listaBrojeva[2]);
            ZakljucajButtone();
            button1.BackColor = Color.Aquamarine;
            button2.BackColor = Color.Aquamarine;
            button3.BackColor = Color.Aquamarine;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            IzracunajZbroj(Zbroj = listaBrojeva[3] + listaBrojeva[4] + listaBrojeva[5]);
            ZakljucajButtone();
            button4.BackColor = Color.Aquamarine;
            button5.BackColor = Color.Aquamarine;
            button6.BackColor = Color.Aquamarine;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            IzracunajZbroj(Zbroj = listaBrojeva[6] + listaBrojeva[7] + listaBrojeva[8]);
            ZakljucajButtone();
            button7.BackColor = Color.Aquamarine;
            button8.BackColor = Color.Aquamarine;
            button9.BackColor = Color.Aquamarine;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            IzracunajZbroj(Zbroj = listaBrojeva[0] + listaBrojeva[4] + listaBrojeva[8]);
            ZakljucajButtone();
            button1.BackColor = Color.Aquamarine;
            button5.BackColor = Color.Aquamarine;
            button9.BackColor = Color.Aquamarine;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IzracunajZbroj(Zbroj = listaBrojeva[0] + listaBrojeva[3] + listaBrojeva[6]);
            ZakljucajButtone();
            button1.BackColor = Color.Aquamarine;
            button4.BackColor = Color.Aquamarine;
            button7.BackColor = Color.Aquamarine;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            IzracunajZbroj(Zbroj = listaBrojeva[1] + listaBrojeva[4] + listaBrojeva[7]);
            ZakljucajButtone();
            button2.BackColor = Color.Aquamarine;
            button5.BackColor = Color.Aquamarine;
            button8.BackColor = Color.Aquamarine;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IzracunajZbroj(Zbroj = listaBrojeva[2] + listaBrojeva[5] + listaBrojeva[8]);
            ZakljucajButtone();
            button3.BackColor = Color.Aquamarine;
            button6.BackColor = Color.Aquamarine;
            button9.BackColor = Color.Aquamarine;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            IzracunajZbroj(Zbroj = listaBrojeva[2] + listaBrojeva[4] + listaBrojeva[6]);
            ZakljucajButtone();
            button3.BackColor = Color.Aquamarine;
            button5.BackColor = Color.Aquamarine;
            button7.BackColor = Color.Aquamarine;
        }

        private void btnUpute_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cilj igre je osvojiti što više kredita. U poljima se nalaze brojevi od 1 do 9 koji su nasumično poredani i ne ponavljaju se. \n\n\n" +
                "Na početku igre će se otvoriti jedan broj, a zatim će igrač odabrati još 3 polja kojima će otkriti vrijednosti. \n\n\nNakon toga igrač bira jedan red, stupac " +
                "ili dijagonalu, a zbroj njihovih vrijednosti će mu ostvariti dobitat koji je naveden u tablici.\n\n\n" +
                "Na primjer: Ako je igrač odabrao prvi redak, gdje su bile vrijednosti '1', '2' i '7', " +
                "igrač će osvojiti kredit koji odgovara broju '10' u tablici, a to je '4200'. \n\n\nOtkrivenost polja ne utječe na mogućnost " +
                "izbora igrača. Za svaku igru je potrebno 500 kredita. ", "Upute za igru", MessageBoxButtons.OK);
        }
    }
    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }

}
