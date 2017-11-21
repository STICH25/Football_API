using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XboxOneX_Frame_Rate_Counter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int frames;
        private double timepassed;
        private bool FALSE;
        private bool TRUE;
        private float fps;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             int frames = 0;
             double starttime = 0;
             bool first = TRUE;
             float fps = 0.0f;

            if (first)
            {
                frames = 0;
                starttime = timepassed;
                first = FALSE;
                return;
            }

            if (timepassed - starttime > 0.25 && frames > 10)
            {

                fps = frames / (int)(timepassed - starttime);
                starttime = timepassed;
                frames = 0;
       
            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ExitDisplayModeOnAccessKeyInvoked;
        }
    }
}
