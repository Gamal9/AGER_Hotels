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
        
        public PresentationPage()
        {
            InitializeComponent();
            var list = new List<item>
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
                    Img="CA.png",Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry."
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
            Navigation.PushAsync(new MainPage());
        }

        
    }
}