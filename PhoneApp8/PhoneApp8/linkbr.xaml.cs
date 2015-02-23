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
    public partial class linkbr : PhoneApplicationPage
    {
        private string msg;
        int n = 0;
        int i = 0;
        private static Stack<Uri> history = new Stack<Uri>();
        private static Stack<Uri> bck = new Stack<Uri>();
        bool b = false;
        bool frwrd = false;
        static Stack<Uri> fo = new Stack<Uri>();		
        public linkbr()
        {
            InitializeComponent();

        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            msg = "";

            if (NavigationContext.QueryString.TryGetValue("msg", out msg))
            {
                linkbrtext.Text = msg;
                mcs3.Navigate(new Uri(msg, UriKind.RelativeOrAbsolute));

            }
        }

        private void backtopopapps_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.RelativeOrAbsolute));

        }

        private void refresh_Click(object sender, System.EventArgs e)
        {
            mcs3.Navigate(new Uri(linkbrtext.Text, UriKind.RelativeOrAbsolute));

        }

        private void back_Click(object sender, System.EventArgs e)
        {

            b = true;
            if (bck.Count > 1)
            {
            bck.Pop();
                mcs3.Navigate(bck.Pop());
            }
            else
            {
                NavigationService.Navigate(new Uri("/PanormaPage1.xaml", UriKind.RelativeOrAbsolute));
            }

        }

        private void forward_Click(object sender, System.EventArgs e)
        {
            frwrd = true;
            if (fo.Count >= 1)
            {
                mcs3.Navigate(fo.Pop());
            }
            else
            {
            }
        }

        private void mcs3_Navigating(object sender, Microsoft.Phone.Controls.NavigatingEventArgs e)
        {
            progress.IsIndeterminate = true;
        }

        private void mcs3_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            progress.IsIndeterminate = false;
            linkbrtext.Text = e.Uri.ToString();
            history.Push(e.Uri);
                bck.Push(e.Uri);
                if (b == false && frwrd == false && fo.Count >= 1)
                    fo.Clear();
                b = false;
                frwrd = false;
               
        }    
        private void count_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            linkbrtext.Text = history.Count.ToString() + " " + bck.Count.ToString();

        }
        private void mcs3_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            progress.IsIndeterminate = false;
        }

    }
}