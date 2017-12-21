using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580057B
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            contentButton.Clicked += ContentButton_Clicked;
            navButton.Clicked += NavButton_Clicked;
            tabButton.Clicked += TabButton_Clicked;
            carouselButton.Clicked += CarouselButton_Clicked;

        }

        private void CarouselButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var cp = new CarouselPage();
            cp.Children.Add(new TabPage1());
            cp.Children.Add(new TabPage2());
            cp.Children.Add(new TabPage3());

            var np = new NavigationPage(cp);
            mp.Detail = np;

            mp.IsPresented = false;
        }

        private void TabButton_Clicked(object sender, EventArgs e)
        {

            var mp = Parent as MasterDetailPage;
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());

            var np = new NavigationPage(tp);
            mp.Detail = np;
     
            mp.IsPresented = false;
        }

        private void NavButton_Clicked(object sender, EventArgs e)
        {

            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new ICT13580057B.NavPage1());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        private void ContentButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new MyPage1());
            mp.Detail = np;
            mp.IsPresented = false;
        }
    }
}