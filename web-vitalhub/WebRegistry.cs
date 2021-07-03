using Microsoft.Extensions.Configuration;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vitalhub.Core;
using Vitalhub.Store.MySqlStore;

namespace Vitalhub.Web
{
    public class WebRegistry : Registry
    {
        public WebRegistry()
        {

            new ConfigurationBuilder();

            For<ICategoryStore>().Use<CategoryStore>().Singleton();
        }
    }
}
