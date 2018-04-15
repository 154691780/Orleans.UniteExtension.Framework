using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExampleProviders
{
    public interface IExamplesProvider
    {
        object GetExamples();
    }
}