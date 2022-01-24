using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        bool merkki = false;
        bool valmis = false;
        bool plus = false;
        bool miinus = false;
        bool kerto = false;
        bool jako = false;
        bool ekakerta = true;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(Form1_KeyPress);
            textBox1.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // -
            miinus = true;
            kerto = false;
            plus = false;
            jako = false;
            textBox2.Text = textBox1.Text;
            StringBuilder builderi = new StringBuilder(textBox2.Text, 50);
            builderi.Insert(builderi.Length, " -");
            textBox2.Text = builderi.ToString();
            merkki = true;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            // Numero 1
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 1);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 1);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0,1);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if(ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 1);
                textBox1.Text = builderi.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Numero 2

            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 2);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 2);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 2);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 2);
                textBox1.Text = builderi.ToString();
            }
            //int laskin = Int32.Parse(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Numero 4
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 4);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 4);
                textBox1.Text = builderi.ToString();
            }

            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 4);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 4);
                textBox1.Text = builderi.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Numero 3
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 3);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 3);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 3);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 3);
                textBox1.Text = builderi.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // +
            miinus = false;
            kerto = false;
            plus = true;
            jako = false;
            textBox2.Text = textBox1.Text;
            StringBuilder builderi = new StringBuilder(textBox2.Text, 50);
            builderi.Insert(builderi.Length, " +");
            textBox2.Text = builderi.ToString();
            merkki = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // *
            miinus = false;
            kerto = true;
            plus = false;
            jako = false;
            textBox2.Text = textBox1.Text;
            StringBuilder builderi = new StringBuilder(textBox2.Text, 50);
            builderi.Insert(builderi.Length, " *");
            textBox2.Text = builderi.ToString();
            merkki = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // =

            if(!merkki)
            {
                return;
            }

            StringBuilder builderi = new StringBuilder(textBox2.Text, 50);
            builderi.Remove(builderi.Length - 2, 2);
            //if(builderi.Length >= 5)
            //{
            //    builderi.Remove(2, 3);
            //}
            //else
            //{
            //    builderi.Remove(1, 2);
            //}
            //textBox2.Text = builderi.ToString();
            //string lause = textBox2.Text + textBox1.Text;
            float numero1 = float.Parse(textBox1.Text);
            float numero2 = float.Parse(builderi.ToString());
            float vastaus = 0;
            if(plus)
            {
                vastaus = numero1 + numero2;

                textBox2.Text = numero2 + " + " + numero1;

            }
            if(miinus)
            {
                vastaus = numero2 - numero1;

                textBox2.Text = numero2 + " - " + numero1;
            }
            if(kerto)
            {
                vastaus = numero1 * numero2;

                textBox2.Text = numero2 + " * " + numero1;

            }
            if(jako)
            {
                vastaus = numero2 / numero1;

                if (numero1 == 0)
                {
                    textBox1.Text = "ERR";
                }

                textBox2.Text = numero2 + " / " + numero1;
            }

            if(vastaus < 99999999)
            {
                vastaus = (float)Math.Round(vastaus, 3);
                textBox1.Text = vastaus.ToString();
            }
            else
            {
                textBox1.Text = "ERR";
            }
            builderi.Remove(0, builderi.Length);
            //textBox2.Text = builderi.ToString();

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);


            merkki = false;
            valmis = true;
            ekakerta = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);
            if(textBox1.Text.Length != 0)
            {
                builderi.Remove(builderi.Length - 1, 1);
                textBox1.Text = builderi.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            miinus = false;
            kerto = false;
            plus = false;
            jako = true;
            textBox2.Text = textBox1.Text;
            StringBuilder builderi = new StringBuilder(textBox2.Text, 50);
            builderi.Insert(builderi.Length, " /");
            textBox2.Text = builderi.ToString();
            merkki = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                //MessageBox.Show("Form.KeyPress: '" +
                //    e.KeyChar.ToString() + "' pressed.");

                //switch (e.KeyChar)
                //{
                //    case (char)49:
                //    case (char)52:
                //    case (char)55:
                //        MessageBox.Show("Form.KeyPress: '" +
                //            e.KeyChar.ToString() + "' consumed.");
                //        e.Handled = true;
                //        break;
                //}
                int a = 1;
                int b = 2;
                int c = 3;
                int d = 4;
                if (e.KeyChar.ToString() == a.ToString())
                {
                    button4.PerformClick();
                }
                if (e.KeyChar.ToString() == b.ToString())
                {
                    button5.PerformClick();
                }
                if (e.KeyChar.ToString() == c.ToString())
                {
                    button6.PerformClick();
                }
                if (e.KeyChar.ToString() == d.ToString())
                {
                    button7.PerformClick();
                }
                if (e.KeyChar.ToString() == 5.ToString())
                {
                    button13.PerformClick();
                }
                if (e.KeyChar.ToString() == 6.ToString())
                {
                    button14.PerformClick();
                }
                if (e.KeyChar.ToString() == 7.ToString())
                {
                    button15.PerformClick();
                }
                if (e.KeyChar.ToString() == 8.ToString())
                {
                    button16.PerformClick();
                }
                if (e.KeyChar.ToString() == 9.ToString())
                {
                    button17.PerformClick();
                }
                if (e.KeyChar.ToString() == 0.ToString())
                {
                    button19.PerformClick();
                }
            }
            if(e.KeyChar == '+')
            {
                char z = '+';
                if (e.KeyChar.ToString() == z.ToString())
                {
                    button1.PerformClick();
                }
            }
            if(e.KeyChar == (char)8)
            {
                Console.WriteLine("Enter");
                button10.PerformClick();
            }
            if (e.KeyChar == '-')
            {
                Console.WriteLine("Miinus");
                button2.PerformClick();
            }
            if(e.KeyChar == (char)42)
            {
                button3.PerformClick();
            }
            if (e.KeyChar == (char)47)
            {
                button11.PerformClick();
            }
            if (e.KeyChar == (char)44)
            {
                button20.PerformClick();
            }
        }

        void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button8.PerformClick();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 5);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 5);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 5);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 5);
                textBox1.Text = builderi.ToString();
            }
        }

    private void button14_Click(object sender, EventArgs e)
        {
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 6);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 6);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 6);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 6);
                textBox1.Text = builderi.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 7);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 7);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 7);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 7);
                textBox1.Text = builderi.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 8);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 8);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 8);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 8);
                textBox1.Text = builderi.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 9);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 9);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 9);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 9);
                textBox1.Text = builderi.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                builderi.Insert(builderi.Length, 0);
                textBox1.Text = builderi.ToString();
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, 0);
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                builderi.Remove(0, builderi.Length);
                builderi.Insert(0, 0);
                textBox1.Text = builderi.ToString();
                valmis = false;
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, 0);
                textBox1.Text = builderi.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                float result = float.Parse(textBox1.Text);
                result = result * -1;
                textBox1.Text = result.ToString();
            }
            else
            {
                return;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            foreach(char c in textBox1.Text)
            {
                if(c == 44)
                {
                    return;
                }
            }

            StringBuilder builderi = new StringBuilder(textBox1.Text, 50);

            if (textBox1.Text != "0" && merkki == false)
            {
                if (textBox1.Text != String.Empty)
                {
                    builderi.Insert(builderi.Length, ",");
                    textBox1.Text = builderi.ToString();
                }
            }
            if (textBox1.Text == "0" && merkki == false)
            {
                //builderi.Remove(0, builderi.Length);
                builderi.Insert(builderi.Length, ",");
                textBox1.Text = builderi.ToString();
            }
            if (valmis == true)
            {
                if (textBox1.Text != String.Empty)
                {
                    builderi.Remove(0, builderi.Length);
                    builderi.Insert(0, ",");
                    textBox1.Text = builderi.ToString();
                    valmis = false;
                }
            }
            if (merkki == true)
            {
                if (ekakerta)
                {
                    builderi.Remove(0, builderi.Length);
                    ekakerta = false;
                }
                builderi.Insert(builderi.Length, ",");
                textBox1.Text = builderi.ToString();
            }
        }
    }
}
