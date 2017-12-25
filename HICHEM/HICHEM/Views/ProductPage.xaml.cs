using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HICHEM.Views
{
  public partial class ProductPage : ContentPage
  {
    public ProductPage ()
    {
      Title = "Sản phẩm";
      InitializeComponent();
      ProductBrowser.Source = "http://hichemvn.com/vi/danh-muc-san-pham";
    }
  }
}
