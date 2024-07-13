using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using YoutubeApi.Persistence.Ripositories;
using YoutubeApi.Application.İnterfaces.Repositories;

namespace YoutubeApi.Persistence
{
	public static class Registration
	{
		public static void AddPersistance(this IServiceCollection services, IConfiguration configuration)
		{

			services.AddDbContext<AppDbContext>(opt =>

				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			// ReadRepositor nin Dependency Injectionını gerceklestiricez

			services.AddScoped(typeof(ReadRepository<>), typeof(ReadRepository<>));

		}
	}
}
