
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaphernaliaArchive.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int FLoorId { get; set; }
        public int ShelfId { get; set; }
        public int Slot { get; set; }
    }
}
