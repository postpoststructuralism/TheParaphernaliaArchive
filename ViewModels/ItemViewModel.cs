using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParaphernaliaArchive.Models;

namespace ParaphernaliaArchive.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAcquired { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Location StorageLocation { get; set; }

        public ItemViewModel()
        {

        }

        public ItemViewModel(Item item)
        {
            this.Id = item.Id;
            this.Title = item.Title;
            this.Description = item.Description;
            this.ExpirationDate = item.ExpirationDate;
            this.StorageLocation = item.StorageLocation;
        }
    }
}
