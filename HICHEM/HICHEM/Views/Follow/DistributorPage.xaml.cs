using System;
using System.Collections.Generic;
using HICHEM.Services;
using Xamarin.Forms;

namespace HICHEM.Views
{
  public partial class DistributorPage : ContentPage
  {
    public DistributorPage()
    {
      InitializeComponent();
      HeaderImage.Source = FileImageSource.FromFile("header-logo-hichem.png");
      submit.Clicked += (sender, e) => {
        DependencyService.Get<IBaseUrl>().ShortAlert("Implement this later");
      };

      btnNhucau.Clicked += async (sender, e) => {
        var action = await DisplayActionSheet("Choose from list", null, null, "Đăng ký làm đại lý", "Đăng ký bán lẻ", "Đăng ký nhà thầu");
        nhucau.Text = action;
      };

      btnAddress.Clicked += (sender, e) => {
        DependencyService.Get<IBaseUrl>().ShortAlert("Implement this later");
      };
    }
  }
}
