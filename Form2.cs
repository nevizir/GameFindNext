using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameFindNext.Form1;

namespace GameFindNext
{
    public partial class Form2 : Form
    {
        public Complexity Complexity { get; set; } = Complexity.unknown;
        public int timerInitialValue = 0; 
        public int wastedTime = 0;
        public int currentIndex = 0;

        public Form2()
        {
            InitializeComponent();
            GameTimer = new System.Windows.Forms.Timer();
            GameTimer.Interval = 1000;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
            Timerlbl.Text = timerInitialValue.ToString();
            Load += new EventHandler(Form2_Load);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameTimer.Start();

            Random random = new Random();
            int[] numbers = new int[12];
            int index = 0;
            while (index < 12)
            {
                int randomNumber = random.Next(1, 13);
                if (!numbers.Contains(randomNumber))
                {
                    numbers[index] = randomNumber;
                    index++;
                }
            }
            index = 0;
            foreach (Button button in Controls.OfType<Button>())
            {
                if (button.Name.StartsWith("button"))
                {
                    button.Text = numbers[index].ToString();
                    index++;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Complexity == Complexity.easy)
                timerInitialValue = 30;
            else if (Complexity == Complexity.medium)
                timerInitialValue = 20;
            else if (Complexity == Complexity.hard)
                timerInitialValue = 10;

            Timerlbl.Text = timerInitialValue.ToString();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timerInitialValue--;
            wastedTime++;
            if (timerInitialValue == 0)
            {
                MessageBox.Show("You lose");
                Close();
            }
            else
            {
                Timerlbl.Text = timerInitialValue.ToString();
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonNumber = int.Parse(clickedButton.Text);
            if (buttonNumber == currentIndex + 1)
            {
                clickedButton.BackColor = Color.Green;
                currentIndex++;
                clickedButton.Enabled = false;
                if (currentIndex == 12)
                {
                    GameTimer.Stop();
                    MessageBox.Show($"You win!\n" +
                                    $"Wasted time: {wastedTime} seconds", "Victory");
                    Close();
                }
            }
            else
            {
                clickedButton.BackColor = Color.Red;
            }
        }
    }
}
