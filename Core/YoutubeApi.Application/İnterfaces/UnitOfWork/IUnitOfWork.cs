using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Application.İnterfaces.Repositories;
using YoutubeApi.Domein.Commen;

namespace YoutubeApi.Application.İnterfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class,IEntityBase,new ();
        IWriteRepository<T> GetWriteRepository<T>() where T : class,IEntityBase,new ();

        Task<int> saveAsync();

        int Save();
    
    
    }
}
