using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcoPolo
{
    public partial class Form1 : Form
    {
        private string playerName = "";
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void MarcoPoloSend_Click(object sender, EventArgs e)
        {
            if (score == 0)
            {
                HandleChoice();
            }

            else
            {
                ValidateInput();
            }
        }

        private void HandleChoice()
        {
            if (MarcoPoloInput.Text == "Marco")
            {
                MarcoPoloText.Text = "Polo";
                MarcoPoloInput.ResetText();
                playerName = "Marco";
                score++;
            }

            else if (MarcoPoloInput.Text == "Polo")
            {
                MarcoPoloText.Text = "Marco";
                MarcoPoloInput.ResetText();
                playerName = "Polo";
                score++;
            }

            else
            {
                MessageBox.Show("YOU LOSE");
            }
        }

        private void ValidateInput()
        {
            if (playerName == "Marco" && MarcoPoloInput.Text == "Marco")
            {
                MarcoPoloText.Text = "Polo";
                MarcoPoloInput.ResetText();
                score++;
            }

            else if (playerName == "Polo" && MarcoPoloInput.Text == "Polo")
            {
                MarcoPoloText.Text = "Marco";
                MarcoPoloInput.ResetText();
                score++;
            }

            else
            {
                MessageBox.Show("YOU LOSE");
            }
        }
    }
}
