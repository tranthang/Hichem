using System;

using Xamarin.Forms;

namespace HICHEM
{
  public partial class AboutPage : ContentPage
  {
    public AboutPage ()
    {
      Title = "Sales";
      InitializeComponent();
      var htmlSource = new HtmlWebViewSource();
      htmlSource.Html = DependencyService.Get<Services.IBaseUrl>().Get("tab5.html");
      Browser.Source = htmlSource;
      Browser.VerticalOptions = LayoutOptions.FillAndExpand;
      Browser.HorizontalOptions = LayoutOptions.FillAndExpand;
    }
  }
}
