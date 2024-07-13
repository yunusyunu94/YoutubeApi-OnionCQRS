using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domein.Commen;

namespace YoutubeApi.Domein.Entities
{
	public class Product : EntityBase, IEntityBase // zaten EntityBase den miras alıyor yazmasakta olur
	{
        public required string Title { get; set; }
        public required string Derscription { get; set; }
        public required int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; } // İndirim olursa
        public Brand Brand { get; set; }
        public ICollection<Category> Categories { get; set; }
        
        //public required string ImagePath { get; set; }
    }
}
