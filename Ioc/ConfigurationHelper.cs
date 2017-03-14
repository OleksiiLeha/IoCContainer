using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace Lesson2_Flow
{
    class ConfigurationHelper
    {
        public static void ConfigureDependencies(ConfigurationExpression x)
        {
            x.For<IEngine>().Use<Engine>();
        }
    }
}
