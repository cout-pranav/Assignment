using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessageCenterDemoApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Messages { get; set; } = new ObservableCollection<string>();
        public MainPage()
        {
            
            InitializeComponent();
            BindingContext = this;
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<Page>(this, "rada", (p) =>
            {
                Messages.Add($"Message Received");
            });
        }

        async public void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
        }
    }
}
