using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class play_window : Form
    {
        private static int how_much_letters;
        private string pattern;
        private string test;
        private Random random;
        private string[] t;
        Graphics g;
        Pen p;
        public play_window(string path)
        {
            InitializeComponent();
            pattern = "";
            random = new Random(Guid.NewGuid().GetHashCode());
            how_much_letters = 10;
            t = File.ReadAllLines(path);
            g = panel.CreateGraphics();
            p = new Pen(Color.Black, 6);

        }

        private void message_box(string message, string title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                how_much_letters = 10;
            }
            else
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

        }

        private void change_string_check_letter(string s)
        {
            string tekst_aktualny = textBox.Text;
            string gotowe = "";

            for (int i = 0; i<pattern.Length; i++)
            {
                if (tekst_aktualny[i] =='_')
                {
                    if (pattern[i].ToString().ToUpper() == s.ToUpper())
                    {
                        gotowe += s.ToUpper();
                    }
                    else
                    {
                        gotowe += "_";
                    }
                }
                else
                {
                    gotowe += tekst_aktualny[i];
                }
            }
            if(tekst_aktualny == gotowe)
            {
                draw(how_much_letters);

                --how_much_letters;
            }
            if (how_much_letters == 0)
            {
                message_box(" You lose! \n Play agian?", "Game state:");
            }
            else
            {
                letters_texbox.Text = "You have: " + how_much_letters.ToString() + " letters";
            }
            textBox.Text = gotowe;
            if (pattern.ToString().ToUpper() == gotowe.ToUpper())
            {
                message_box(" You win! \n Play agian?", "Game state:");
            }

        }


        private void play_window_Load(object sender, EventArgs e)
        {
            test = t[random.Next(0,t.Length)];
            letters_texbox.Text = "You have: " + how_much_letters.ToString() + " letters";
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != ' ')
                {
                    if (test[i] == '-')
                    {
                        textBox.Text += "- ";
                        pattern += "- ";
                    }
                    else
                    {
                        textBox.Text += "_ ";
                        pattern += test[i]+" ";
                    }
                }
                else
                {
                    textBox.Text += "   ";
                    pattern += "   ";
                }
            }
        }
        void draw(int r)
        {
            switch (r)
            {
                case 10:
                    g.DrawLine(p, new Point(380, 200), new Point(280, 200));
                    break;
                case 9:
                    g.DrawLine(p, new Point(330, 200), new Point(330, 10));
                    break;                    
                case 8:
                    g.DrawLine(p, new Point(333, 10), new Point(180, 10));
                    break;
                case 7:
                    g.DrawLine(p, new Point(183, 10), new Point(183, 60));
                    break;
                case 6:
                    g.DrawEllipse(p, 164, 60, 40, 40);
                    break;
                case 5:
                    //tułów
                    g.DrawLine(p, new Point(183, 100), new Point(183, 150));
                    break;
                case 4:
                    //nogi
                    g.DrawLine(p, new Point(183, 150), new Point(150, 185));
                    break;
                case 3:
                    g.DrawLine(p, new Point(183, 150), new Point(216, 185));
                    break;
                case 2:
                    //ręce
                    g.DrawLine(p, new Point(183, 120), new Point(150, 155));
                    break;
                case 1:
                    g.DrawLine(p, new Point(183, 120), new Point(216, 155));
                    break;
            }
        }
        private void button_click(object sender, EventArgs e)
        {
            change_string_check_letter((sender as Button).Text.ToString());
            (sender as Button).BackColor = Color.Blue;
        }

    }
}
