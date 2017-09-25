﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Launchpad.NET;
using Launchpad.NET.Effects;
using test.Effects;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
           this.InitializeComponent();
            init();

        }

        async void init()
        {
            
            var launchpad = await Novation.Launchpad("launchpad");
           // launchpad.SetButtonColor(3, 5, (byte)LaunchpadMK2Color.Orange);
            launchpad.RegisterEffect(new FlashEffect(), TimeSpan.FromMilliseconds(500));

        }

    }
}
