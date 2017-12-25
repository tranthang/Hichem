using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HICHEM.Views
{
  public partial class FollowUsPage : ContentPage
  {
    //ItemsFollowViewModel viewModel;
    public FollowUsPage ()
    {
      
      Title = "Follow us";
      InitializeComponent();
      //BindingContext = viewModel = new ItemsFollowViewModel();
      LogoFU.Source = FileImageSource.FromFile("header-logo-hichem.png");
      ObservableCollection<Item> employeeList = new ObservableCollection<Item>();
      ListFU.ItemsSource = employeeList;

      employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Facebook", Icon = "FACEBOOK.png", GoToDetail = "listArrow.png", DetailUrl = "https://www.facebook.com/Keohichemcaocap/" });
      employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Youtube", Icon = "YOUTUBE.png", GoToDetail = "listArrow.png", DetailUrl = "https://www.youtube.com/channel/UCT12GWcVZiDyfYB2ztLouWA" });
      employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Trụ sở", Icon = "ADDRESS.png", GoToDetail = "listArrow.png", DetailPage = new MapPage() });
      employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Đặt hẹn lịch", Icon = "LICHHEN.png", GoToDetail = "listArrow.png",  DetailPage = new HICHEM.Views.ApointmentPage() });
      employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Đăng ký nhà phân phối", Icon = "PHANPHOI.png", GoToDetail = "listArrow.png", DetailPage = new HICHEM.Views.DistributorPage() });
      //employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Tiện ích", Icon = "COUPON.png", GoToDetail = "listArrow.png", DetailUrl = "tienich.html" });
         
    }

    async void Handle_ItemSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
    {
      var item = e.SelectedItem as Item;
      if (item == null)
      {
        return;
      }
      if (item.DetailPage == null)
      {
        await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
      } else
      {
        await Navigation.PushAsync(item.DetailPage);
      }
      ListFU.SelectedItem = null;
    }


    protected override void OnAppearing ()
    {
      base.OnAppearing();
      //if (viewModel.Items.Count == 0) 
      //{
      //  viewModel.LoadItemsCommand.Execute(null);
      //}
    }
  }
}
