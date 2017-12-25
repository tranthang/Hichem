using System;
using Xamarin.Forms;

namespace HICHEM
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string GoToDetail { get; set; }
    public string DetailUrl { get; set;  }
    public Page DetailPage { get; set; }
    }
}
