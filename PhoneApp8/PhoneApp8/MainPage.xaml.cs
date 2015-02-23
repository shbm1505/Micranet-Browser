using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone;
using System.Threading;
using Microsoft.Phone.Tasks;
using System.Device.Location;
namespace PhoneApp8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Thread.Sleep(3000);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/browse.xaml?msg="+ micrasurf.Text,UriKind.Relative));

        }

        private void micrasurf_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void email_Click(object sender, System.EventArgs e)
        {
            Microsoft.Phone.Tasks.EmailComposeTask ect = new Microsoft.Phone.Tasks.EmailComposeTask();
            ect.To = "micrasurf@gmail.com";
            ect.Subject = "your precious Suggestions";
            ect.Body = "Hope you like it!!!";
            ect.Show();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void call_us_Click(object sender, System.EventArgs e)
        {
            Microsoft.Phone.Tasks.PhoneCallTask pct = new Microsoft.Phone.Tasks.PhoneCallTask();
            pct.DisplayName = "micra";
            pct.PhoneNumber = "+919990357056";
            pct.Show();
            
        }

        private void like_us_on_facebook_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/browser.xaml?msg=" + "https://www.facebook.com", UriKind.RelativeOrAbsolute));

        }

        private void rate_us_Click(object sender, System.EventArgs e)
        {
            MarketplaceReviewTask mpr = new MarketplaceReviewTask();
            mpr.Show();
        }

        private void appli_click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.RelativeOrAbsolute));
        }

       
		
		private void binmap_Click(object sender, System.EventArgs e)
        {
            BingMapsTask bmt = new BingMapsTask();
            bmt.ZoomLevel = 2;
            bmt.SearchTerm = "coffee";
            bmt.Show();
        }

        private void about_us(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
        }

        

    }
}