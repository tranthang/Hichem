using System;
using Plugin.Geolocator;
using Position = Plugin.Geolocator.Abstractions.Position;
using Xamarin.Forms;

namespace HICHEM.Views.MapPicker
{
  public class MapPicker : ContentPage
  {
    Xamarin.Forms.Maps.Map map;
    public MapPicker()
    {
      map = new Xamarin.Forms.Maps.Map()
      {
        IsShowingUser = true,
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,

      };
      //var location = await locator.GetPositionAsync(TimeSpan.FromTicks(10000));

      //MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(3)));

      //Position position = new Position(location.La)
      getMyLocation();
      Content = new StackLayout
      {
        Children = {map}
      };
    }

    private async void getMyLocation () {
      var locator = CrossGeolocator.Current;
      var location = await locator.GetPositionAsync(TimeSpan.FromTicks(10000));
      Position position = new Position(location.Latitude, location.Longitude);
      map.MoveToRegion(Xamarin.Forms.Maps.MapSpan.FromCenterAndRadius(new Xamarin.Forms.Maps.Position(position.Latitude, position.Longitude), Xamarin.Forms.Maps.Distance.FromMiles(3)));
    }
  }
}

