using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Flow.Controllers
{
    class FinalPageController : BasketWizardPageController<FinalPage>
    {
        private FinalPage page;

        public FinalPageController(FinalPage page)
            : base(page)
        {
            this.page = page;
        }
        //public void Index()
        //{
        //    Console.WriteLine(page.Name);
        //    GoToNextPage();
        //}
        //public void GoToNextPage()
        //{}
    }
}
