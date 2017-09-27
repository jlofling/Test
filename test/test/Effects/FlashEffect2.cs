using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launchpad.NET.Effects;
using Launchpad.NET.Models;
using Launchpad.NET;

namespace test.Effects
{
    public class FlashEffect2 : ILaunchpadEffect
    {
        int row = 1;
        int col = 1;
        bool isGoingRight = true;
        bool moveDown = false;
        int currentPass = 1;
        LaunchpadButton lastButton;

        public string Name => throw new NotImplementedException();

        public IObservable<ILaunchpadEffect> WhenComplete => null; //throw new NotImplementedException();

        List<LaunchpadButton> gridButtons;

        public void Initiate(List<LaunchpadButton> gridButtons, List<LaunchpadButton> sideButtons, List<LaunchpadTopButton> topButtons, IObservable<ILaunchpadButton> whenButtonStateChanged)
        {
            this.gridButtons = gridButtons;

            whenButtonStateChanged
                .Subscribe(ProcessInput);
        }


        public void ProcessInput(ILaunchpadButton button)
        {
            switch (button)
            {
                case LaunchpadButton gridButton:
                    // Clear above
                    break;
            }
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            //System.Diagnostics.Debug.Write("------------------ \n Current Pass: " + currentPass + " \n" + "------------------ \n");
            System.Diagnostics.Debug.WriteLine("=====================================");
            System.Diagnostics.Debug.WriteLine("         Current Pass: " + currentPass);
            System.Diagnostics.Debug.WriteLine("=====================================");


            var button11 = gridButtons.First(button => button.Id == (byte)(int.Parse("1" + "1")));
            var button12 = gridButtons.First(button => button.Id == (byte)(int.Parse("1" + "2")));
            var button13 = gridButtons.First(button => button.Id == (byte)(int.Parse("1" + "3")));
            var button14 = gridButtons.First(button => button.Id == (byte)(int.Parse("1" + "4")));
            var button15 = gridButtons.First(button => button.Id == (byte)(int.Parse("1" + "5")));
            var button16 = gridButtons.First(button => button.Id == (byte)(int.Parse("1" + "6")));
            var button17 = gridButtons.First(button => button.Id == (byte)(int.Parse("1" + "7")));
            var button18 = gridButtons.First(button => button.Id == (byte)(int.Parse("1" + "8")));

            var button21 = gridButtons.First(button => button.Id == (byte)(int.Parse("2" + "1")));
            var button22 = gridButtons.First(button => button.Id == (byte)(int.Parse("2" + "2")));
            var button23 = gridButtons.First(button => button.Id == (byte)(int.Parse("2" + "3")));
            var button24 = gridButtons.First(button => button.Id == (byte)(int.Parse("2" + "4")));
            var button25 = gridButtons.First(button => button.Id == (byte)(int.Parse("2" + "5")));
            var button26 = gridButtons.First(button => button.Id == (byte)(int.Parse("2" + "6")));
            var button27 = gridButtons.First(button => button.Id == (byte)(int.Parse("2" + "7")));
            var button28 = gridButtons.First(button => button.Id == (byte)(int.Parse("2" + "8")));

            var button31 = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + "1")));
            var button32 = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + "2")));
            var button33 = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + "3")));
            var button34 = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + "4")));
            var button35 = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + "5")));
            var button36 = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + "6")));
            var button37 = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + "7")));
            var button38 = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + "8")));

            var button41 = gridButtons.First(button => button.Id == (byte)(int.Parse("4" + "1")));
            var button42 = gridButtons.First(button => button.Id == (byte)(int.Parse("4" + "2")));
            var button43 = gridButtons.First(button => button.Id == (byte)(int.Parse("4" + "3")));
            var button44 = gridButtons.First(button => button.Id == (byte)(int.Parse("4" + "4")));
            var button45 = gridButtons.First(button => button.Id == (byte)(int.Parse("4" + "5")));
            var button46 = gridButtons.First(button => button.Id == (byte)(int.Parse("4" + "6")));
            var button47 = gridButtons.First(button => button.Id == (byte)(int.Parse("4" + "7")));
            var button48 = gridButtons.First(button => button.Id == (byte)(int.Parse("4" + "8")));

            var button51 = gridButtons.First(button => button.Id == (byte)(int.Parse("5" + "1")));
            var button52 = gridButtons.First(button => button.Id == (byte)(int.Parse("5" + "2")));
            var button53 = gridButtons.First(button => button.Id == (byte)(int.Parse("5" + "3")));
            var button54 = gridButtons.First(button => button.Id == (byte)(int.Parse("5" + "4")));
            var button55 = gridButtons.First(button => button.Id == (byte)(int.Parse("5" + "5")));
            var button56 = gridButtons.First(button => button.Id == (byte)(int.Parse("5" + "6")));
            var button57 = gridButtons.First(button => button.Id == (byte)(int.Parse("5" + "7")));
            var button58 = gridButtons.First(button => button.Id == (byte)(int.Parse("5" + "8")));

            var button61 = gridButtons.First(button => button.Id == (byte)(int.Parse("6" + "1")));
            var button62 = gridButtons.First(button => button.Id == (byte)(int.Parse("6" + "2")));
            var button63 = gridButtons.First(button => button.Id == (byte)(int.Parse("6" + "3")));
            var button64 = gridButtons.First(button => button.Id == (byte)(int.Parse("6" + "4")));
            var button65 = gridButtons.First(button => button.Id == (byte)(int.Parse("6" + "5")));
            var button66 = gridButtons.First(button => button.Id == (byte)(int.Parse("6" + "6")));
            var button67 = gridButtons.First(button => button.Id == (byte)(int.Parse("6" + "7")));
            var button68 = gridButtons.First(button => button.Id == (byte)(int.Parse("6" + "8")));

            var button71 = gridButtons.First(button => button.Id == (byte)(int.Parse("7" + "1")));
            var button72 = gridButtons.First(button => button.Id == (byte)(int.Parse("7" + "2")));
            var button73 = gridButtons.First(button => button.Id == (byte)(int.Parse("7" + "3")));
            var button74 = gridButtons.First(button => button.Id == (byte)(int.Parse("7" + "4")));
            var button75 = gridButtons.First(button => button.Id == (byte)(int.Parse("7" + "5")));
            var button76 = gridButtons.First(button => button.Id == (byte)(int.Parse("7" + "6")));
            var button77 = gridButtons.First(button => button.Id == (byte)(int.Parse("7" + "7")));
            var button78 = gridButtons.First(button => button.Id == (byte)(int.Parse("7" + "8")));

            var button81 = gridButtons.First(button => button.Id == (byte)(int.Parse("8" + "1")));
            var button82 = gridButtons.First(button => button.Id == (byte)(int.Parse("8" + "2")));
            var button83 = gridButtons.First(button => button.Id == (byte)(int.Parse("8" + "3")));
            var button84 = gridButtons.First(button => button.Id == (byte)(int.Parse("8" + "4")));
            var button85 = gridButtons.First(button => button.Id == (byte)(int.Parse("8" + "5")));
            var button86 = gridButtons.First(button => button.Id == (byte)(int.Parse("8" + "6")));
            var button87 = gridButtons.First(button => button.Id == (byte)(int.Parse("8" + "7")));
            var button88 = gridButtons.First(button => button.Id == (byte)(int.Parse("8" + "8")));

            button11.Color = (byte)LaunchpadMK2Color.Green1;
            button12.Color = (byte)LaunchpadMK2Color.Green2;
            button13.Color = (byte)LaunchpadMK2Color.Green3;
            button14.Color = (byte)LaunchpadMK2Color.Blue1;
            button15.Color = (byte)LaunchpadMK2Color.DarkGreen;
            button16.Color = (byte)LaunchpadMK2Color.Orange;
            button17.Color = (byte)LaunchpadMK2Color.Salmon;
            button18.Color = (byte)LaunchpadMK2Color.Yellow2;

            button21.Color = (byte)LaunchpadMK2Color.Green1;
            button22.Color = (byte)LaunchpadMK2Color.Green2;
            button23.Color = (byte)LaunchpadMK2Color.Green3;
            button24.Color = (byte)LaunchpadMK2Color.Blue1;
            button25.Color = (byte)LaunchpadMK2Color.DarkGreen;
            button26.Color = (byte)LaunchpadMK2Color.Orange;
            button27.Color = (byte)LaunchpadMK2Color.Salmon;
            button28.Color = (byte)LaunchpadMK2Color.Yellow2;

            button31.Color = (byte)LaunchpadMK2Color.Green1;
            button32.Color = (byte)LaunchpadMK2Color.Green2;
            button33.Color = (byte)LaunchpadMK2Color.Green3;
            button34.Color = (byte)LaunchpadMK2Color.Blue1;
            button35.Color = (byte)LaunchpadMK2Color.DarkGreen;
            button36.Color = (byte)LaunchpadMK2Color.Orange;
            button37.Color = (byte)LaunchpadMK2Color.Salmon;
            button38.Color = (byte)LaunchpadMK2Color.Yellow2;

            button41.Color = (byte)LaunchpadMK2Color.Green1;
            button42.Color = (byte)LaunchpadMK2Color.Green2;
            button43.Color = (byte)LaunchpadMK2Color.Green3;
            button44.Color = (byte)LaunchpadMK2Color.Blue1;
            button45.Color = (byte)LaunchpadMK2Color.DarkGreen;
            button46.Color = (byte)LaunchpadMK2Color.Orange;
            button47.Color = (byte)LaunchpadMK2Color.Salmon;
            button48.Color = (byte)LaunchpadMK2Color.Yellow2;

            button51.Color = (byte)LaunchpadMK2Color.Green1;
            button52.Color = (byte)LaunchpadMK2Color.Green2;
            button53.Color = (byte)LaunchpadMK2Color.Green3;
            button54.Color = (byte)LaunchpadMK2Color.Blue1;
            button55.Color = (byte)LaunchpadMK2Color.DarkGreen;
            button56.Color = (byte)LaunchpadMK2Color.Orange;
            button57.Color = (byte)LaunchpadMK2Color.Salmon;
            button58.Color = (byte)LaunchpadMK2Color.Yellow2;

            button61.Color = (byte)LaunchpadMK2Color.Green1;
            button62.Color = (byte)LaunchpadMK2Color.Green2;
            button63.Color = (byte)LaunchpadMK2Color.Green3;
            button64.Color = (byte)LaunchpadMK2Color.Blue1;
            button65.Color = (byte)LaunchpadMK2Color.DarkGreen;
            button66.Color = (byte)LaunchpadMK2Color.Orange;
            button67.Color = (byte)LaunchpadMK2Color.Salmon;
            button68.Color = (byte)LaunchpadMK2Color.Yellow2;

            button71.Color = (byte)LaunchpadMK2Color.Green1;
            button72.Color = (byte)LaunchpadMK2Color.Green2;
            button73.Color = (byte)LaunchpadMK2Color.Green3;
            button74.Color = (byte)LaunchpadMK2Color.Blue1;
            button75.Color = (byte)LaunchpadMK2Color.DarkGreen;
            button76.Color = (byte)LaunchpadMK2Color.Orange;
            button77.Color = (byte)LaunchpadMK2Color.Salmon;
            button78.Color = (byte)LaunchpadMK2Color.Yellow2;

            button81.Color = (byte)LaunchpadMK2Color.Green1;
            button82.Color = (byte)LaunchpadMK2Color.Green2;
            button83.Color = (byte)LaunchpadMK2Color.Green3;
            button84.Color = (byte)LaunchpadMK2Color.Blue1;
            button85.Color = (byte)LaunchpadMK2Color.DarkGreen;
            button86.Color = (byte)LaunchpadMK2Color.Orange;
            button87.Color = (byte)LaunchpadMK2Color.Salmon;
            button88.Color = (byte)LaunchpadMK2Color.Yellow2;


            //button1.Color = (byte)LaunchpadMK2Color.Off;
            //button2.Color = (byte)LaunchpadMK2Color.Off;
            //button3.Color = (byte)LaunchpadMK2Color.Off;
            //button4.Color = (byte)LaunchpadMK2Color.Off;
            //button5.Color = (byte)LaunchpadMK2Color.Off;
            //button6.Color = (byte)LaunchpadMK2Color.Off;
            //button7.Color = (byte)LaunchpadMK2Color.Off;
            //button8.Color = (byte)LaunchpadMK2Color.Off;

            //if (currentPass == 1) {
            //    //for (var x = 1; x <= 8; x++)
            //    //{
            //    //    System.Diagnostics.Debug.Write("-----New Row----- \n");
            //    //    for (var y = 1; y <= 8; y++)
            //    //    {
            //    //        System.Diagnostics.Debug.Write(x + ", " + y + "\n");
            //    //        var nextButton = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + col.ToString())));
            //    //    }
            //    //}

            //    System.Diagnostics.Debug.Write(gridButtons + "\n ---------------------");
            //  }
            //if (currentPass == 9)
            //{
            //    return;
            //}

            //if (currentPass % 2 > 0)
            //{
            //    button1.Color = (byte)LaunchpadMK2Color.Green1;
            //    button2.Color = (byte)LaunchpadMK2Color.Green2;
            //    button3.Color = (byte)LaunchpadMK2Color.Green3;
            //    button4.Color = (byte)LaunchpadMK2Color.Blue1;
            //    button5.Color = (byte)LaunchpadMK2Color.DarkGreen;
            //    button6.Color = (byte)LaunchpadMK2Color.Orange;
            //    button7.Color = (byte)LaunchpadMK2Color.Salmon;
            //    button8.Color = (byte)LaunchpadMK2Color.Yellow2;
            //}
            //else
            //{
            //    button1.Color = (byte)LaunchpadMK2Color.Off;
            //    button2.Color = (byte)LaunchpadMK2Color.Off;
            //    button3.Color = (byte)LaunchpadMK2Color.Off;
            //    button4.Color = (byte)LaunchpadMK2Color.Off;
            //    button5.Color = (byte)LaunchpadMK2Color.Off;
            //    button6.Color = (byte)LaunchpadMK2Color.Off;
            //    button7.Color = (byte)LaunchpadMK2Color.Off;
            //    button8.Color = (byte)LaunchpadMK2Color.Off;
            //}


            if (currentPass == 144)
            {
                return;
            }


            var nextButton = gridButtons.First(button => button.Id == (byte)(int.Parse(row.ToString() + col.ToString())));

            nextButton.Color = (byte)LaunchpadMK2Color.Off;

            System.Diagnostics.Debug.Write("nexButton location: " + nextButton.Id + " \n");
            System.Diagnostics.Debug.Write("nexButton color: " + nextButton.Color + " \n");


            //if (lastButton != null)
            //{
            //    //lastButton.Color = (byte)LaunchpadMK2Color.Off;

            //    //lastButton = gridButtons.First(button => button.Id == (byte)(int.Parse(row.ToString() + (col - 1).ToString())));
            //    //lastButton.Color = (byte)LaunchpadMK2Color.Off;
            //    //lastButton.Color = (byte)LaunchpadMK2Color.Off;

            //    System.Diagnostics.Debug.Write("lastButton value: " + lastButton.Id + " \n");
            //    System.Diagnostics.Debug.Write("lastButton color: " + lastButton.Color + " \n");

            //}

            //lastButton = nextButton;

            if (isGoingRight)
            {
                col++;
            }
            else
            {
                col--;
            }
            if (col > 8)
            {
                if (moveDown == false)
                {
                    row++;
                }
                else if (moveDown == true)
                {
                    row--;
                }

                isGoingRight = false;
                col--;
            }
            if (col < 1)
            {

                //if (row >= 1)
                //{
                    if (moveDown == false)
                    {
                        row++;
                    }
                    else if (moveDown == true)
                    {
                        row--; // row becomes 0 when it reaches column 1 on its way down, moving to the left
                    }
                //}

                isGoingRight = true;
                col++;
            }
            if (row == 9)
            {
                moveDown = true;
                row--;
                //return;
            }
            if (row == 0)
            {
                moveDown = false;
                row++;
            }

            //lastButton = nextButton;

            //System.Diagnostics.Debug.Write("lastButton value: " + lastButton.Id + " \n");
            //System.Diagnostics.Debug.Write("lastButton color: " + lastButton.Color + " \n");

            //System.Diagnostics.Debug.Write("Row 1, Column 1 color: " + button11.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 1, Column 2 color: " + button12.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 1, Column 3 color: " + button13.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 1, Column 4 color: " + button14.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 1, Column 5 color: " + button15.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 1, Column 6 color: " + button16.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 1, Column 7 color: " + button17.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 1, Column 8 color: " + button18.Color + " \n");

            //System.Diagnostics.Debug.Write("Row 2, Column 1 color: " + button21.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 2, Column 2 color: " + button22.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 2, Column 3 color: " + button23.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 2, Column 4 color: " + button24.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 2, Column 5 color: " + button25.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 2, Column 6 color: " + button26.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 2, Column 7 color: " + button27.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 2, Column 8 color: " + button28.Color + " \n");

            //System.Diagnostics.Debug.Write("Row 3, Column 1 color: " + button31.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 3, Column 2 color: " + button32.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 3, Column 3 color: " + button33.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 3, Column 4 color: " + button34.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 3, Column 5 color: " + button35.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 3, Column 6 color: " + button36.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 3, Column 7 color: " + button37.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 3, Column 8 color: " + button38.Color + " \n");

            //System.Diagnostics.Debug.Write("Row 4, Column 1 color: " + button41.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 4, Column 2 color: " + button42.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 4, Column 3 color: " + button43.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 4, Column 4 color: " + button44.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 4, Column 5 color: " + button45.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 4, Column 6 color: " + button46.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 4, Column 7 color: " + button47.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 4, Column 8 color: " + button48.Color + " \n");

            //System.Diagnostics.Debug.Write("Row 5, Column 1 color: " + button51.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 5, Column 2 color: " + button52.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 5, Column 3 color: " + button53.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 5, Column 4 color: " + button54.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 5, Column 5 color: " + button55.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 5, Column 6 color: " + button56.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 5, Column 7 color: " + button57.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 5, Column 8 color: " + button58.Color + " \n");

            //System.Diagnostics.Debug.Write("Row 6, Column 1 color: " + button61.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 6, Column 2 color: " + button62.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 6, Column 3 color: " + button63.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 6, Column 4 color: " + button64.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 6, Column 5 color: " + button65.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 6, Column 6 color: " + button66.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 6, Column 7 color: " + button67.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 6, Column 8 color: " + button68.Color + " \n");

            //System.Diagnostics.Debug.Write("Row 7, Column 1 color: " + button71.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 7, Column 2 color: " + button72.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 7, Column 3 color: " + button73.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 7, Column 4 color: " + button74.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 7, Column 5 color: " + button75.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 7, Column 6 color: " + button76.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 7, Column 7 color: " + button77.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 7, Column 8 color: " + button78.Color + " \n");

            //System.Diagnostics.Debug.Write("Row 8, Column 1 color: " + button81.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 8, Column 2 color: " + button82.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 8, Column 3 color: " + button83.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 8, Column 4 color: " + button84.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 8, Column 5 color: " + button85.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 8, Column 6 color: " + button86.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 8, Column 7 color: " + button87.Color + " \n");
            //System.Diagnostics.Debug.Write("Row 8, Column 8 color: " + button88.Color + " \n");



            System.Diagnostics.Debug.WriteLine("isGoingRight = " + isGoingRight);
            System.Diagnostics.Debug.WriteLine("moveDown = " + moveDown);
            System.Diagnostics.Debug.WriteLine("row = " + row);
            System.Diagnostics.Debug.WriteLine("col = " + col);



            System.Diagnostics.Debug.WriteLine("=====================================");
            System.Diagnostics.Debug.WriteLine("             End Pass: " + currentPass);
            System.Diagnostics.Debug.WriteLine("=====================================");


            currentPass++;
        }
    }
}
