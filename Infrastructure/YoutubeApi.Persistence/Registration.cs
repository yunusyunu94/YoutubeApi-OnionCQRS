using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace YoutubeApi.Persistence
{
	public static class Registration
	{
		public static void AddPersistance(this IServiceCollection services, IConfiguration configuration)
		{

			services.AddDbContext<AppDbContext>(opt =>
			
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

		
		}
	}
}
