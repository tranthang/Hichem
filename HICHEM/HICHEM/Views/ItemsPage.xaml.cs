using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HICHEM
{
    public partial class ItemsPage : ContentPage
    {

        public ItemsPage()
        {
      Title = "Home";
            InitializeComponent();

            //BindingContext = viewModel = new ItemsViewModel();
      LogoHome.Source = FileImageSource.FromFile("bigicon.png");

      ObservableCollection<Item> employeeList = new ObservableCollection<Item>();
      ItemsListView.ItemsSource = employeeList;

      //Mr. Mono will be added to the ListView because it uses an ObservableCollection
      //employeeList.Add(new Employee() { DisplayName = "Mr. Mono" })
      employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "VỀ CHÚNG TÔI", Icon = "about.png", GoToDetail = "listArrow.png", DetailUrl = "vechungtoi.html" });
      employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "THÀNH TỰU", Icon = "Achievement-512.png", GoToDetail = "listArrow.png", DetailUrl = "thanhtuu.html" });
      employeeList.Add(new Item { Id = Guid.NewGuid().ToString(), Text = "LIÊN HỆ", Icon = "grey_new_seo2-41-512.png", GoToDetail = "listArrow.png", DetailUrl = "lienhe.html" });
         
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item
            ItemsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //if (viewModel.Items.Count == 0)
                //viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
