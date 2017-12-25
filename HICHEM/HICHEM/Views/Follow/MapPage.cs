using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace HICHEM.Views
{
  public class MapPage : ContentPage
  {
    public MapPage()
    {
      Map map = new Map
      {
        IsShowingUser = true,
        HeightRequest = 100,
        WidthRequest = 960,
        VerticalOptions = LayoutOptions.FillAndExpand
      };

      map.MoveToRegion(MapSpan.FromCenterAndRadius(
        new Position(16.7246794, 105.6328234), Distance.FromMiles(400)));

      var position = new Position(10.8003978, 106.6486108); // Latitude, Longitude
      var pin = new Pin
      {
        Type = PinType.Place,
        Position = position,
        Label = "HCM",
        Address = "Văn phòng TP HCM"
      };
      map.Pins.Add(pin); // 20.9959147,105.7442068

      position = new Position(20.9959147, 105.744206); // Latitude, Longitude
      pin = new Pin
      {
        Type = PinType.Place,
        Position = position,
        Label = "Ha Noi",
        Address = "Trụ sở Hà nội"
      };
      map.Pins.Add(pin);
      // put the page together
      Content = new StackLayout
      {
        Spacing = 0,
        Children = {
          map
        }
      };
    }
  }
}

