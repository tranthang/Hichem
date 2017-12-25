using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HICHEM.Views
{
  public partial class NewsPage : ContentPage
  {
    public NewsPage ()
    {
      Title = "Tin Tức";
      InitializeComponent();
      News.Source = "http://hichemvn.com/vi/tin-tuc/";
    }
  }
}
