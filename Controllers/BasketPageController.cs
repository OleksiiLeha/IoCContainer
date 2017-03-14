using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Flow.Controllers
{
    public class BasketPageController : BasketWizardPageController<BasketPage>
    {
        private BasketPage page;

        public BasketPageController(BasketPage page)
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
        //{
        //    Engine engine = new Engine();
        //    var nextPage = engine.Go(page);
        //    if (nextPage is FinalPage)
        //    {
        //        var controller = new FinalPageController(nextPage as FinalPage);
        //        controller.Index();
        //        return;
        //    }
        //}
    }
}
