using System;
using System.Collections.Generic;

using Xamarin.Forms;
using HICHEM.Views.Login;

namespace HICHEM.Views
{
  public partial class MainActivityPage : ContentPage
  {
    public MainActivityPage()
    {
      InitializeComponent();
      tracnghiem.GestureRecognizers.Add(new TapGestureRecognizer()
      {
        Command = new Command((obj) => thiTracNghiem())
      });

      ghethamdaily.GestureRecognizers.Add(new TapGestureRecognizer()
      {
        Command = new Command((obj) => gheThamDaiLy())
      });

      chamcong.GestureRecognizers.Add(new TapGestureRecognizer()
      {
        Command = new Command((obj) => chamCong())
      });

      tailieusanpham.GestureRecognizers.Add(new TapGestureRecognizer()
      {
        Command = new Command((obj) => taiLieuSanPham())
      });

      baocaocongviec.GestureRecognizers.Add(new TapGestureRecognizer()
      {
        Command = new Command((obj) => baoCaoCongViec())
      });
    }

    private async void taiLieuSanPham()
    {
      await Navigation.PushAsync(new TaiLieuSanPham());
    }

    private async void chamCong()
    {
      await Navigation.PushAsync(new ChamCong());
    }

    private async void baoCaoCongViec()
    {
      await Navigation.PushAsync(new BaoCaoCongViec());
    }

    private async void thiTracNghiem()
    {
      await Navigation.PushAsync(new HICHEM.Views.Login.TracNghiem());
    }


    private async void gheThamDaiLy()
    {
      await Navigation.PushAsync(new HICHEM.Views.Login.GheThamDaiLy());
    }
  }
}
