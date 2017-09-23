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
    public class FlashEffect : ILaunchpadEffect
    {

        int x = 1;
        bool isGoingRight = true;
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
            if (lastButton != null)
                lastButton.Color = (byte)LaunchpadMK2Color.Pink;

            if(isGoingRight)
            {
                x++;
            }
            else
            {
                x--;
            }
            if(x > 7)
            {
                isGoingRight = false;
            }
            if(x == 1)
            {
                isGoingRight = true;
            }
            var nextButton = gridButtons.First(button => button.Id == (byte)(int.Parse("3" + x.ToString())));
            nextButton.Color = (byte)LaunchpadMK2Color.Off;
            lastButton = nextButton;
        }
    }
}
