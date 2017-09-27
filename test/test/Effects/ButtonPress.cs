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
    class ButtonPress : ILaunchpadEffect
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
            if (currentPass == 9)
            {
                return;
            }

            System.Diagnostics.Debug.WriteLine("=====================================");
            System.Diagnostics.Debug.WriteLine("         Current Pass: " + currentPass);
            System.Diagnostics.Debug.WriteLine("=====================================");





            System.Diagnostics.Debug.WriteLine("=====================================");
            System.Diagnostics.Debug.WriteLine("             End Pass: " + currentPass);
            System.Diagnostics.Debug.WriteLine("=====================================");


            currentPass++;
        }
    }
}
