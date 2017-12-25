using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HICHEM.Views.Login
{
  public partial class ForgotPasswordPage : ContentPage
  {
    public ForgotPasswordPage()
    {
      InitializeComponent();
      warning.IsVisible = false;
      getPassword.Clicked += handleEmailBehavior;
    }

    private void handleEmailBehavior (Object sender, EventArgs args) {
      warning.IsVisible = true;

    }
  }
}
