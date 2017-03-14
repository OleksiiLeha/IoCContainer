using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Flow.Controllers
{
    public class StartPageController
    {
        private StartPage page;

        public StartPageController(StartPage page)
        {
            this.page = page;
        }
        public void Index()
        {
            Console.WriteLine(page.Name);
        }
    }
}
