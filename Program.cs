using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2_Flow.Controllers;
using StructureMap;

namespace Lesson2_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            StrMap_IoC.Initialize(ConfigurationHelper.ConfigureDependencies);

            var BasketPage = PageStore.Pages.OfType<BasketPage>().FirstOrDefault();
            var controller = new BasketPageController(BasketPage);
            controller.Index();
            Console.WriteLine(new string('*', Console.BufferWidth - 1));
            var RegisterPage = PageStore.Pages.OfType<RegisterPage>().FirstOrDefault();
            var reg_controller = new RegisterPageController(RegisterPage);
            reg_controller.Index();

            Console.WriteLine(new string('*', Console.BufferWidth - 1));

            


            //var runner = new Engine(/*StrMap_IoC.Current.Container.GetInstance<IEngine>()*/);
            //runner.Go(BasketPage);

            //var container = new Container();
            //container.Configure(r => r.For<IEngine>().Use<Engine>());
            //IEngine engine = container.GetInstance<IEngine>();

            Console.ReadLine();
        }
    }
}
