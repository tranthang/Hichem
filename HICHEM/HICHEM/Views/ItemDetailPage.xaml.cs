using System;
using HICHEM.Services;
using Xamarin.Forms;

namespace HICHEM
{
  public partial class ItemDetailPage : ContentPage
  {
    ItemDetailViewModel viewModel;

    // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
    public ItemDetailPage()
    {
      InitializeComponent();

      var item = new Item
      {
        Text = "Item 1",
        Description = "This is an item description."
      };

      viewModel = new ItemDetailViewModel(item);
      BindingContext = viewModel;
      loadWebView();
    }

    public ItemDetailPage(ItemDetailViewModel viewModel)
    {
      InitializeComponent();

      BindingContext = this.viewModel = viewModel;
      loadWebView();
    }


    private void loadWebView()
    {
      var html = new HtmlWebViewSource();
      if (viewModel.Item.DetailUrl.Contains("http"))
      {
        ItemDetail.Source = viewModel.Item.DetailUrl;
      }
      else
      {
        html.Html = DependencyService.Get<IBaseUrl>().Get(viewModel.Item.DetailUrl);
        ItemDetail.Source = html;
        ItemDetail.IsEnabled = true;
      }
    }

    protected async override void OnAppearing()
    {
      base.OnAppearing();
      await activity_indicator.ProgressTo(0.9, 900, Easing.SpringIn);

    }

    public void OnNavigating(object sender, WebNavigatingEventArgs e)
    {
      activity_indicator.IsVisible = true;
    }

    public void OnNavigated(object sender, WebNavigatedEventArgs e)
    {
      activity_indicator.IsVisible = false;
    }
  }

}
