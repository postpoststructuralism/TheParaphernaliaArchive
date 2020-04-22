using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaphernaliaArchive.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAcquired { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Location StorageLocation { get; set; }

    }
}
