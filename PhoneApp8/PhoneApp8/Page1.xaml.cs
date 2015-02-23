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


namespace PhoneApp8
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }
	
			private void facebook_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	//mcs.Navigate(new Uri("https://www.facebook.com",Urikind.Absolute));
        }

			private void twitter_Click(object sender, System.Windows.RoutedEventArgs e)
			{
                NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.RelativeOrAbsolute));
                //mcs.Navigate(new Uri("www.twitter.com", UriKind.RelativeOrAbsolute));
             
			}

			private void facebook1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
			{
				// TODO: Add event handler implementation here.
			}

			private void facebook1_ImageFailed(object sender, System.Windows.ExceptionRoutedEventArgs e)
			{
				// TODO: Add event handler implementation here.
			}

            private void driveout_Click(object sender, System.Windows.RoutedEventArgs e)
            {
                myturnstile.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
				NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.RelativeOrAbsolute));
            }

			private void bing_Click(object sender, System.Windows.RoutedEventArgs e)
			{
		
			}

            private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
            {

            }

           
        
    }
    
}