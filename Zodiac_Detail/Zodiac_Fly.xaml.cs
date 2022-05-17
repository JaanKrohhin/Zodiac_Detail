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
    public partial class Zodiac_Fly : FlyoutPage
    {
        public Zodiac_Fly()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Zodiac_FlyFlyoutMenuItem;
            if (item == null)
                return;
            Zodiac_FlyDetail.item = item;
            
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            IsPresented = false;
            item.Read = '*';

            FlyoutPage.ListView.SelectedItem = null;
        }
    }
}