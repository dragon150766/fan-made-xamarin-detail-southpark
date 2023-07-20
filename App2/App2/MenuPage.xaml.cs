using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            homeButton.Clicked += HomeButton_Clicked;
            charaterButton.Clicked += CharaterButton_Clicked;
            websiteButton.Clicked += WebsiteButton_Clicked;
            facebookButton.Clicked += FacebookButton_Clicked;
            twitterButton.Clicked += TwitterButton_Clicked;
            instagramIcon.Clicked += InstagramIcon_Clicked;
            discordIcon.Clicked += DiscordIcon_Clicked;
            

        }

        private void DiscordIcon_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new DiscordPage());
            fp.IsPresented = false;
        }

        private void InstagramIcon_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new InstagramIcon());
            fp.IsPresented = false;
        }

        private void TwitterButton_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new TwitterPage());
            fp.IsPresented = false;
        }

        private void FacebookButton_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new FacebookPage());
            fp.IsPresented = false;
        }

        private void WebsiteButton_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new WebSite());
            fp.IsPresented = false;
        }

        private void CharaterButton_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            var tp = new TabbedPage();
            tp.Children.Add(new StanPage());
            tp.Children.Add(new KylePage());
            tp.Children.Add(new EricPage());
            tp.Children.Add(new KennyPage());
            fp.Detail = new NavigationPage(tp);
            fp.IsPresented = false;
        }

        private void HomeButton_Clicked(object sender, EventArgs e)
        {
            var fp = Parent as FlyoutPage;
            fp.Detail = new NavigationPage(new MainPage());
            fp.IsPresented = false;
        }
    }
}