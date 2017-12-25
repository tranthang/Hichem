using System;
using Foundation;
using HICHEM.Services;
using UIKit;

[assembly : Xamarin.Forms.Dependency(typeof(HICHEM.iOS.Services.iOSBaseUrl))]
namespace HICHEM.iOS.Services
{
  public class iOSBaseUrl : IBaseUrl
  {
    public string Get (String fileName)
    {
      String[] str = fileName.Split(".".ToCharArray(), 2);
      String path = NSBundle.MainBundle.PathForResource(str[0], str[1]);
      return NSString.FromData(NSData.FromFile(path), NSStringEncoding.UTF8).ToString();
    }

    const double LONG_DELAY = 3.5;
    const double SHORT_DELAY = 2.0;

    NSTimer alertDelay;
    UIAlertController alert;

    public void LongAlert(string message)
    {
      ShowAlert(message, LONG_DELAY);
    }
    public void ShortAlert(string message)
    {
      ShowAlert(message, SHORT_DELAY);
    }

    void ShowAlert(string message, double seconds)
    {
      alertDelay = NSTimer.CreateScheduledTimer(seconds, (obj) =>
      {
        dismissMessage();
      });
      alert = UIAlertController.Create(null, message, UIAlertControllerStyle.Alert);
      UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
    }

    void dismissMessage()
    {
      if (alert != null)
      {
        alert.DismissViewController(true, null);
      }
      if (alertDelay != null)
      {
        alertDelay.Dispose();
      }
    }
  }
}
