﻿using System;

namespace HICHEM
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
      Title = item?.Description;
            Item = item;
        }
    }
}
