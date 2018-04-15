using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Specification.Provider
{
    /// <summary>
    /// 
    /// </summary>
    public class GenerationServiceProvider : IServiceProvider
    {
        public object GetService(Type serviceType)
        {
            return serviceType;
        }
    }
}
