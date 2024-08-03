using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonDers_JWToken.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Model> Model { get; set; }
    }
}
