using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Slider
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

   

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
       
            await MainProgressBar.ProgressTo(1, 11900, Easing.Linear);

            }

        private void MenuItem_OnClicked (object sender, EventArgs e)
        {
            MainLabel5.Text = "Item Clikced!";


        }
        

        //private void MainSlider_OnValueChanged(Object sender , ValueChangedEventArgs e)
        //{
        //    MainLabel.Text = MainSlider.Value.ToString();
        //}

        //private void DatePicker_OnDateSelected(Object sender, DateChangedEventArgs e)
        //{
        //    MainLabel.Text = e.NewDate.ToString();
        //}





    }
}
