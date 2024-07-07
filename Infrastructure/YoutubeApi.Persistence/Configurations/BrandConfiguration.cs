﻿using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domein.Entities;

namespace YoutubeApi.Persistence.Configurations
{
	public class BrandConfiguration : IEntityTypeConfiguration<Brand>
	{
		public void Configure(EntityTypeBuilder<Brand> builder)
		{
			builder.Property(x => x.Name)
				.HasMaxLength(250);

			Faker faker = new("tr");

			Brand brand1 = new()
			{
				Id = 1,
				Name = faker.Commerce.Department(), // Random vericek
				CreateDate = DateTime.Now, 
				IsDeleted = false
			};

			Brand brand2 = new()
			{
				Id = 2,
				Name = faker.Commerce.Department(), // Random vericek
				CreateDate = DateTime.Now,
				IsDeleted = false
			};

			Brand brand3 = new()
			{
				Id = 3,
				Name = faker.Commerce.Department(), // Random vericek
				CreateDate = DateTime.Now,
				IsDeleted = true
			};

			builder.HasData(brand1, brand2, brand3);
		}
	}
}
