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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FamilyDevices
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btnWhatDevice_Click(object sender, RoutedEventArgs e)
        {
            string whatFamily = Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily;

            if (whatFamily == "Windows.Mobile")
            {
                MessageDialog myMessage = new MessageDialog("I'm running in Mobile Device", "Family");
                await myMessage.ShowAsync();

                this.Frame.Navigate(typeof(DeviceFamily));
            }

            else if (whatFamily == "Windows.IoT")
            {
                MessageDialog myMessage = new MessageDialog("I'm running in an electronic device (IoT)", "Family");
                await myMessage.ShowAsync();
            }

            else if (whatFamily == "Windows.Xbox")
            {
                MessageDialog myMessage = new MessageDialog("I'm running in Xbox console", "Family");
                await myMessage.ShowAsync();
            }
            else if (whatFamily == "Windows.Desktop")
            {
                MessageDialog myMessage = new MessageDialog("I'm running in Desktop", "Family");
                await myMessage.ShowAsync();

                
            }

            else if (whatFamily == "Windows.Hololens")
            {
                MessageDialog myMessage = new MessageDialog("I'm running in Hololens glasses", "Family");
                await myMessage.ShowAsync();
            }
        }
    }
}
