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
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			Faker faker = new Faker("tr");

			Product product1 = new()
			{
				Id = 1,
				Title = faker.Commerce.ProductName(),
				Derscription = faker.Commerce.ProductDescription(),
				BranId = 1,
				Discount =faker.Random.Decimal(0,10),
				Price = faker.Finance.Amount(10,1000),
				CreateDate = DateTime.Now,
				IsDeleted = false

			};

			Product product2 = new()
			{
				Id = 2,
				Title = faker.Commerce.ProductName(),
				Derscription = faker.Commerce.ProductDescription(),
				BranId = 3,
				Discount = faker.Random.Decimal(0, 10),
				Price = faker.Finance.Amount(10, 1000),
				CreateDate = DateTime.Now,
				IsDeleted = false

			};

			builder.HasData(product1, product2);
		}
	}
}
