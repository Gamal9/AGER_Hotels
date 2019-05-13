using AGER_Hotels.Helper;
using AGER_Hotels.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AGER_Hotels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PresentationPage : ContentPage
    {
        public class item
        {
            public string Img { get; set; }
            public string Text { get; set; }
        }
        NavigationViewModel NavVM;
        List<item> list;
        public PresentationPage()
        {
            InitializeComponent();
            
            list = new List<item>
            {
                new item
                {
                    Img="A.png",Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                },
                new item
                {
                    Img="B.png",Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                },
                new item
                {
                    Img="A.png",Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                },
                new item
                {
                    Img="D.png",Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                }

            };
            this.BindingContext = list;
           
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            caro.Position++;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        private void Caro_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            if(caro.Position+1==list.Count)
                NextBtn.IsVisible = false;
            else
                NextBtn.IsVisible = true;
        }
    }
}