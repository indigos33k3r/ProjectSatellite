using NotificationsExtensions.Toasts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Toast_notifications
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

        

        private void Show(ToastContent content)
        {
            ToastNotificationManager.CreateToastNotifier().Show(new ToastNotification(content.GetXml()));
        }

        private void SatelliteNotification(object sender, RoutedEventArgs e) {
            Show(new ToastContent() {
                Visual = new ToastVisual() {
                    TitleText = new ToastText() { Text = "Genesys transfer issue" },
                    BodyTextLine1 = new ToastText() { Text = "Agents are currently unable to transfer calls in Genesys, this is being investigated by GSN." }
                },

                Launch = "394815",

                Scenario = ToastScenario.Alarm,

                Actions = new ToastActionsCustom() {
                    Buttons =
                    {
                        new ToastButtonDismiss("I'm not affected by this"),
                        new ToastButton("I'm affected by this", "https://helpme.myob.com")
                    }
                }
            });
        }
    }
}
