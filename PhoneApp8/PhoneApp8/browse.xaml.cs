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
    public partial class browse : PhoneApplicationPage
    {
       
        private static Stack<Uri> history = new Stack<Uri>();
        private static Stack<Uri> bck = new Stack<Uri>();
        bool b = false;
        bool frwrd= false;

        static Stack<Uri> fo = new Stack<Uri>();
		
        public browse()
        {
            InitializeComponent();
        }

		protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string msg = "";
            
            if (NavigationContext.QueryString.TryGetValue("msg", out msg))
			{

               browse1.Text = msg;
				mcs2.Navigate(new Uri(browse1.Text,UriKind.RelativeOrAbsolute));
			
			}
           
        }
        private void go_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	mcs2.Navigate(new Uri(browse1.Text,UriKind.RelativeOrAbsolute));
         
        }

        private void forward_Click(object sender, System.EventArgs e)
        {
            frwrd = true;
            if (fo.Count >= 1)
            {
            mcs2.Navigate(fo.Pop());
            }
            else
            {
            }
        }
        private void home_Click(object sender, System.EventArgs e)
        {
            // TODO: Add event handler implementation here.
        }

        private void refresh_Click(object sender, System.EventArgs e)
        {
            mcs2.Navigate(new Uri(browse1.Text, UriKind.RelativeOrAbsolute));
        }

        private void mcs2_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            progresshow.IsIndeterminate = false;
            browse1.Text = e.Uri.ToString();
            history.Push(e.Uri); 
            bck.Push(e.Uri);
            if(b==false && frwrd==false&&fo.Count>=1)
                fo.Clear();
            b = false;
            frwrd = false;

            
        }

        private void mcs2_Navigating(object sender, Microsoft.Phone.Controls.NavigatingEventArgs e)
        {
        	progresshow.IsIndeterminate=true;
        }

        private void mcs2_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {progresshow.IsIndeterminate=false;
        }

        private void back_Click(object sender, System.EventArgs e)
        {
            b = true;

            if (bck.Count > 1)
            {
                fo.Push(bck.Pop());
                mcs2.Navigate(bck.Pop());
                
            }
            else
            {
                NavigationService.Navigate(new Uri("/MainPAge.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}