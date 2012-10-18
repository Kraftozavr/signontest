using System;
using System.Linq;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Security.Authentication.Web;
using Microsoft.Live;
using Microsoft.Live.Controls;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace signontest
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
       
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
           /* string CLIENT_ID = "00000000440D7600";
            string REDIRECT_URL = "http://kickwinlabs.com";
            string MYURI = "https://login.live.com/oauth20_authorize.srf?client_id=CLIENT_ID&scope=wl.signin&response_type=RESPONSE_TYPE&redirect_uri=REDIRECT_URL";
            System.Uri startUri = new Uri(MYURI);
            System.Uri endUri = new Uri(REDIRECT_URL);
            WebAuthenticationResult WebAuthenticationResult = await WebAuthenticationBroker.AuthenticateAsync(
                                                        WebAuthenticationOptions.None,
                                                       startUri,
                                                        endUri);
            * */
        }

        private async void btnLogin_SessionChanged_1(object sender, Microsoft.Live.Controls.LiveConnectSessionChangedEventArgs e)
        {
            if (e.Status == LiveConnectSessionStatus.Connected)
            {
                LiveConnectClient client = new LiveConnectClient(e.Session);
                LiveOperationResult operationResult = await client.GetAsync("me");
                try
                {
                    dynamic meResult = operationResult.Result;
                    this.infoTextBlock.Text = "Hello, " + meResult.name + "!";
                }
                catch (LiveConnectException exception)
                {
                    this.infoTextBlock.Text = "Error: " + exception.Message;
                }
            }

        }

      
       
    }


}
