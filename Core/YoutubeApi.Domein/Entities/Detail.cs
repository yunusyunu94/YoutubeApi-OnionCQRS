using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domein.Commen;

namespace YoutubeApi.Domein.Entities
{
	public class Detail : EntityBase, IEntityBase // zaten EntityBase den miras alıyor yazmasakta olur
	{
		public Detail()
		{
		}

		public Detail(string title, string description, int categoryId)
		{
			Title = title;
			Description = description;
			CategoryId = categoryId;
		}

		public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
