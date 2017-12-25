using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HICHEM.Views.Login
{
  public partial class LoginPage : ContentPage
  {
    public LoginPage()
    {
      InitializeComponent();
      login.Clicked += handleLoginClick;
      passWord.IsPassword = true;
      userName.Keyboard = Keyboard.Email;
      forgotPassword.GestureRecognizers.Add(new TapGestureRecognizer() {
        Command = new Command(() => forgotPasswordClicked())
      });
    }


    private async void handleLoginClick (Object sender, EventArgs args) {
      if (userName.Text.Equals("code") && passWord.Text.Equals("code"))
      {
        await Navigation.PushAsync(new MainActivityPage());
      } else
      {
        return;
      }
    }


    private async void forgotPasswordClicked () {
      await Navigation.PushAsync(new ForgotPasswordPage());
    }
  }
}
