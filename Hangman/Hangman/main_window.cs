using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class main_window : Form
    {
        private play_window window;
        public main_window()
        {
            InitializeComponent();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            
            if (animals_radio_button.Checked)
            {
                window = new play_window(@"D:\Programy\Repozytorium\Hangman\Hangman\Hangman\animals.txt");
            }
            if (countries_radio_button.Checked)
            {
                window = new play_window(@"D:\Programy\Repozytorium\Hangman\Hangman\Hangman\countries.txt");
            }

            window.Show();
        }
    }
}
