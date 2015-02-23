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

namespace PhoneApp8
{
    public partial class PanoramaPage1 : PhoneApplicationPage
    {
        public PanoramaPage1()
        {
            InitializeComponent();          
        }


        private void fb_Click(object sender, System.Windows.RoutedEventArgs e)
        {
		    _1.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.facebook.com",UriKind.RelativeOrAbsolute));
        }

        private void goog_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	_1.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.google.com",UriKind.RelativeOrAbsolute));
        }

        private void yahoo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	_1.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.yahoo.com",UriKind.RelativeOrAbsolute));
        }

        private void amazon_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	_1.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.amazon.com",UriKind.RelativeOrAbsolute));
        }

        private void ebay_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	_1.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.ebay.com",UriKind.RelativeOrAbsolute));
        }

        private void hotmail_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	_2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.hotmail.com",UriKind.RelativeOrAbsolute));
        }

        private void twitter_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			_2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.twitter.com",UriKind.RelativeOrAbsolute));
        }

        private void back2main_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	_1.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.FrontToBack);
            _2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/MainPage.xaml?",UriKind.RelativeOrAbsolute));
		}

        private void back2main2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.FrontToBack);
            _1.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.BackToFront);
        	NavigationService.Navigate(new Uri("/MainPage.xaml?",UriKind.RelativeOrAbsolute));
		}

        private void gmail_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.FrontToBack);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.gmail.com",UriKind.RelativeOrAbsolute));
        }

        private void jabong_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.FrontToBack);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.jabong.com",UriKind.RelativeOrAbsolute));
        }

        private void cricbuzz_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	_2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.FrontToBack);
            NavigationService.Navigate(new Uri("/linkbr.xaml?msg=" + "http://www.cricbuzz.com/", UriKind.RelativeOrAbsolute));
        }

        private void youtube_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.FrontToBack);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.youtube.com",UriKind.RelativeOrAbsolute));
        }
		
        private void bing_click(object sender, System.Windows.RoutedEventArgs e)
        {
        	_2.AnimateTiles(VirtualDreams.Turnstile.EnterMode.Exit, VirtualDreams.Turnstile.YDirection.TopToBottom, VirtualDreams.Turnstile.ZDirection.FrontToBack);
        	NavigationService.Navigate(new Uri("/linkbr.xaml?msg="+"https://www.w3schools.com",UriKind.RelativeOrAbsolute));
		}
    }
}
  