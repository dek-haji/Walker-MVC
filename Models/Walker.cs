using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGO.Models
{
    public class Walker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NeighborhoodId { get; set; }
        public string ImageURL { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }
}
