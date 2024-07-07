using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domein.Commen;
using YoutubeApi.Domein.Entities;

namespace YoutubeApi.Persistence.Configurations
{
	public class CategoryConfirugation : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			Category category1 = new() 
			{
				Id = 1,
				Name = "Elektrik",
				Priorty = 1,
				PerentId = 0,
				CreateDate = DateTime.Now
			};

			Category category2 = new()
			{
				Id = 2,
				Name = "Moda",
				Priorty = 1,
				PerentId = 0,
				CreateDate = DateTime.Now
			};

			Category parent1 = new()
			{
				Id = 3,
				Name = "Bilgisayar", // Elektrigin altı
				Priorty = 1,
				PerentId = 1, // Elektrigin Id si 1 oldugu icin
				CreateDate = DateTime.Now
			};

			Category parent2 = new()
			{
				Id = 4,
				Name = "Kadın", // Modanın altı
				Priorty = 1,
				PerentId = 2, // Moda Id si 2 oldugu icin
				CreateDate = DateTime.Now
			};

			builder.HasData(category1,category2, parent1, parent2);

		}
	}
}
