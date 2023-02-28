namespace GameFindNext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum Complexity
        {
            unknown,
            easy,
            medium,
            hard
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            Form2 findNextGame = new Form2();
            findNextGame.Complexity = Complexity.easy;
            findNextGame.Show();
        }

        private void MediumeButton_Click(object sender, EventArgs e)
        {
            Form2 findNextGame = new Form2();
            findNextGame.Complexity = Complexity.medium;
            findNextGame.Show();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            Form2 findNextGame = new Form2();
            findNextGame.Complexity = Complexity.hard;
            findNextGame.Show();
        }
    }
}