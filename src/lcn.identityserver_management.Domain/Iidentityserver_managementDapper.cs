using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace lcn.identityserver_management
{
    public interface Iidentityserver_managementDapper : ITransientDependency
    {
        Task<IEnumerable<T>> Query<T>(string sql, object param = null);


        Task<T> QueryFirstOrDefault<T>(string sql, object param = null);


    }
}
