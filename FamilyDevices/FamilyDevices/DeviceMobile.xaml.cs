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


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FamilyDevices
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeviceFamily : Page
    {
        public DeviceFamily()
        {
            this.InitializeComponent();
        }

        private void btnSeeCamera_Click(object sender, RoutedEventArgs e)
        {
            Windows.Phone.UI.Input.HardwareButtons.CameraPressed += HardwareButtons_CameraPressed;
        }

        private async void HardwareButtons_CameraPressed(object sender, Windows.Phone.UI.Input.CameraEventArgs e)
        {
            MessageDialog myMessage = new MessageDialog("You pressed the camera!");
            await myMessage.ShowAsync();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private async void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            MessageDialog myMessage = new MessageDialog("You pressed back button!");
            await myMessage.ShowAsync();
        }

        private void btnReleaseCamera_Click(object sender, RoutedEventArgs e)
        {
            Windows.Phone.UI.Input.HardwareButtons.CameraReleased += HardwareButtons_CameraReleased;
        }

        private async void HardwareButtons_CameraReleased(object sender, Windows.Phone.UI.Input.CameraEventArgs e)
        {
            MessageDialog myMessage = new MessageDialog("Camera released!");
            await myMessage.ShowAsync();
        }
    }
}
