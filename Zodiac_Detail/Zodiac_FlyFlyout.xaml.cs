using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zodiac_Detail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Zodiac_FlyFlyout : ContentPage
    {
        public ListView ListView;

        public Zodiac_FlyFlyout()
        {
            InitializeComponent();

            BindingContext = new Zodiac_FlyFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class Zodiac_FlyFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Zodiac_FlyFlyoutMenuItem> MenuItems { get; set; }

            public Zodiac_FlyFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<Zodiac_FlyFlyoutMenuItem>(new[]
                {
                    new Zodiac_FlyFlyoutMenuItem { Id = 0, Title = "Aries",Pic = "_0.jpg", Description = Properties.Resources.Aries },
                    new Zodiac_FlyFlyoutMenuItem { Id = 1, Title = "Leo" ,Pic = "_1.jpg", Description = Properties.Resources.Leo},
                    new Zodiac_FlyFlyoutMenuItem { Id = 4, Title = "Sagittarius",Pic = "_2.jpg", Description = Properties.Resources.Sagittarius },
                    new Zodiac_FlyFlyoutMenuItem { Id = 5, Title = "Taurus",Pic = "_3.jpg", Description = Properties.Resources.Tauros },
                    new Zodiac_FlyFlyoutMenuItem { Id = 6, Title = "Virgo" ,Pic = "_4.jpg", Description = Properties.Resources.Virgo},
                    new Zodiac_FlyFlyoutMenuItem { Id = 7, Title = "Capricorn" ,Pic = "_5.jpg", Description = Properties.Resources.Capricorn},
                    new Zodiac_FlyFlyoutMenuItem { Id = 8, Title = "Gemini" ,Pic = "_6.jpg", Description = Properties.Resources.Gemini},
                    new Zodiac_FlyFlyoutMenuItem { Id = 9, Title = "Libra" ,Pic = "_7.jpg", Description = Properties.Resources.Libra},
                    new Zodiac_FlyFlyoutMenuItem { Id = 10, Title = "Aquarius" ,Pic = "_8.jpg", Description = Properties.Resources.Aquarius},
                    new Zodiac_FlyFlyoutMenuItem { Id = 11, Title = "Cancer" ,Pic = "_9.jpg", Description = Properties.Resources.Cancer},
                    new Zodiac_FlyFlyoutMenuItem { Id = 2, Title = "Scorpio",Pic = "_10.jpg" , Description = Properties.Resources.Scorpio},
                    new Zodiac_FlyFlyoutMenuItem { Id = 3, Title = "Pisces" ,Pic = "_11.jpg", Description = Properties.Resources.Pisces},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}