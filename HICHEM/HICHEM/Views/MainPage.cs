using System;
using HICHEM.Views.Login;
using Xamarin.Forms;

namespace HICHEM.Views
{
  public class MainPage : TabbedPage
  {
    public MainPage()
    {
      Page itemsPage, sanphamPage, newsPage = null, followPage = null, salePage = null;

      switch (Device.RuntimePlatform)
      {
        case Device.iOS:
          itemsPage = new NavigationPage(new ItemsPage())
          {
            Title = "Home"
          };

          sanphamPage = new NavigationPage(new ProductPage())
          {
            Title = "Sản phẩm"
          };
          newsPage = new NavigationPage(new NewsPage())
          {
            Title = "Tin tức"
          };

          followPage = new NavigationPage(new FollowUsPage())
          {
            Title = "Follow us"
          };
          salePage = new NavigationPage(new LoginPage())
          {
            Title = "Sales"
          };
          itemsPage.Icon = "tab1.png";
          sanphamPage.Icon = "tab2.png";
          newsPage.Icon = "tab3.png";
          followPage.Icon = "tab4.png";
          salePage.Icon = "tab5.png";
          break;
        default:
          itemsPage = new ItemsPage()
          {
            Title = "Home"
          };

          sanphamPage = new ProductPage()
          {
            Title = "Sản phẩm"
          };
          break;
      }

      Children.Add(itemsPage);
      Children.Add(sanphamPage);
      Children.Add(newsPage);
      Children.Add(followPage);
      Children.Add(salePage);

      Title = Children[0].Title;
    }


    protected override void OnCurrentPageChanged()
    {
      base.OnCurrentPageChanged();
      Title = CurrentPage?.Title ?? string.Empty;
    }
  }
}

