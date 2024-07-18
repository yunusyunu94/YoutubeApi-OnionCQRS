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

		public int PerentId { get; set; }
		public string Name { get; set; }
		public int Priorty { get; set; }
		public ICollection<Detail> Details { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}
