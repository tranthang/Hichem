using System;
using System.Collections.Generic;
using HICHEM.Services;
using Xamarin.Forms;

namespace HICHEM.Views
{
  public partial class ApointmentPage : ContentPage
  {
    public ApointmentPage()
    {
      InitializeComponent();
      imageApoiment.Source = FileImageSource.FromFile("header-logo-hichem.png");
      btnLocation.Clicked += async (sender, e) => {
        await Navigation.PushAsync(new HICHEM.Views.MapPicker.MapPicker());
      };
      //btnDate.Clicked += (sender, e) => {
      //  DependencyService.Get<IBaseUrl>().ShortAlert("Implement this later");
      //};
      //btnTime.Clicked += (sender, e) => {
      //  DependencyService.Get<IBaseUrl>().ShortAlert("Implement this later");
      //};
      submit.Clicked += (sender, e) => {
        DependencyService.Get<IBaseUrl>().ShortAlert("Implement this later");
      };
    }


    private void handleTimePicker () {
      //time.chan
    }


    private void handleDatePicker () {
      
    }


    private void handleLocationPicker () {
      
    }
  }
}
