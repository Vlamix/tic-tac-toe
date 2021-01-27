
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        (int x, int y) mouseClickCoords = (x: 0, y: 0);

        public Form1()
        {
            InitializeComponent();
            Game.form = this;
            Game.buttons = new List<(Button button, int row, int col)>
            {
                (top_left, 0, 0), (top_center, 0, 1), (top_right, 0, 2),
                (middle_left, 1, 0), (middle_center, 1, 1), (middle_right, 1, 2),
                (bottom_left, 2, 0), (bottom_center, 2, 1), (bottom_right, 2, 2),
            };
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseClickCoords = (e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(
                    Form1.MousePosition.X - this.mouseClickCoords.x,
                    Form1.MousePosition.Y - this.mouseClickCoords.y
                );
        }
        private void GameButton_MouseClick(object sender, MouseEventArgs e)
        {
            Game.ClickEvent((Button)sender);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Game.buttons.ForEach(d => d.button.Text = "");
            Game.step = 1;
            Game.score = (0, 0);
            StepInfo.Text = "X";
            score1.Text = "0";
            score2.Text = "0";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
