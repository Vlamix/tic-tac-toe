using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Game
    {
        static public (int p1, int p2) score = (0, 0);
        static public List<(Button button, int row, int col)> buttons;
        static public int step = 1;
        static public Form1 form;
        static public List<string> buttonValues = new List<string> { "", "X", "O" };

        static public void ClickEvent(Button button)
        {
            (Button button, int row, int col) buttonData = Game.buttons.Find(d => d.button == button);
            if (buttonData.button.Text == "")
            {
                buttonData.button.Text = Game.buttonValues[Game.step];
                Game.step = Game.step == 1 ? 2 : 1;
                Game.form.StepInfo.Text = Game.buttonValues[Game.step];
                Game.CheckEndOfTheGame();
            }
        }
        static public bool CheckEndOfTheGame()
        {
            foreach (string buttonValue in Game.buttonValues)
            {
                if (buttonValue == "") continue;

                for (int i = 0; i < 3; i++)
                {
                    if (Game.buttons.Where(d => d.row == i).All(d => d.button.Text == buttonValue))
                        return Game.GameOver(buttonValue);
                    if (Game.buttons.Where(d => d.col == i).All(d => d.button.Text == buttonValue))
                        return Game.GameOver(buttonValue);
                }
                if (Game.buttons.Where(d => d.row == d.col).All(d => d.button.Text == buttonValue))
                    return Game.GameOver(buttonValue);
                if (Game.buttons.Where(d => d.row == 2 - d.col).All(d => d.button.Text == buttonValue))
                    return Game.GameOver(buttonValue);
                if (Game.buttons.All(d => d.button.Text != ""))
                    return Game.GameOver("");
            }
            return true;
        }
        static public bool GameOver(string buttonValue)
        {
            if (buttonValue == "X")
            {
                Game.score.p1 += 1;
                Game.form.score1.Text = $"{Game.score.p1}";
            }
            else if (buttonValue == "O")
            {
                Game.score.p2 += 1;
                Game.form.score2.Text = $"{Game.score.p2}";
            }
            Game.buttons.ForEach(d => d.button.Text = "");
            return true;
        }
    }
}
