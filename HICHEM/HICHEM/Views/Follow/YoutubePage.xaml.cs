using System;
using System.Collections.Generic;
using HICHEM.Services;
using Xamarin.Forms;

namespace HICHEM.Views
{
  public partial class YoutubePage : ContentPage
  {
    public YoutubePage ()
    {
      InitializeComponent();
      //var html = new HtmlWebViewSource();
      //html.Html = DependencyService.Get<IBaseUrl>().Get("mobileyoutube1.html");

      //YoutubeHeader.Source = html;

      YoutubeHeader.Source = "http://youtube.seattleclouds.com/youtubeResult.ashx?q=https://www.youtube.com/channel/UCT12GWcVZiDyfYB2ztLouWA&type=channel&feedsmaxitems=10&channelId=UCT12GWcVZiDyfYB2ztLouWA";
    }
  }
}
