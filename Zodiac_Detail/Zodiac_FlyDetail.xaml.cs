using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zodiac_Detail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Zodiac_FlyDetail : ContentPage
    {
        public static Zodiac_FlyFlyoutMenuItem item;
        public Zodiac_FlyDetail()
        {
            InitializeComponent();
            if (item == null)
                BindingContext = new Zodiac_FlyFlyoutMenuItem { Title = "THE BOOK OF ZODIACS", Description = Properties.Resources.Start, Pic = "mainZodiacimg.jpg"};
            else
                BindingContext = item;
            
        }
    }
}