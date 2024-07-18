using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domein.Commen;

namespace YoutubeApi.Domein.Entities
{
	public class Brand : EntityBase, IEntityBase // zaten EntityBase den miras alıyor yazmasakta olur
	{
		public Brand()
		{
		}

		public Brand(string name)
		{
			Name = name;
		}

		public string Name { get; set; }

		public ICollection<Product> Products { get; set; }
    }
}
