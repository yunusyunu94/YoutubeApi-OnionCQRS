using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domein.Commen;

namespace YoutubeApi.Domein.Entities
{
	public class Category : EntityBase, IEntityBase // zaten EntityBase den miras alıyor yazmasakta olur
	{
		public Category(){	}

		public Category(int perentId, string name, int priorty)
		{
			PerentId = perentId;
			Name = name;
			Priorty = priorty;
		}

		public required int PerentId { get; set; }
		public required string Name { get; set; }
		public required int Priorty { get; set; }
		public ICollection<Detail> Details { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}
