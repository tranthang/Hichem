using System;
using HICHEM.Services;
using HICHEM.Views;
using Xamarin.Forms;

namespace HICHEM
{
  public partial class App : Application
  {
    public static bool UseMockDataStore = true;
    public static bool UseFollowDataStore = true;
    public static string BackendUrl = "https://localhost:5000";

    public App ()
    {
      InitializeComponent();

      if (UseMockDataStore)
      {
        DependencyService.Register<MockDataStore>();
        //else if (UseFollowDataStore)
      }
    else 
                DependencyService.Register<CloudDataStore>();
    
            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}
