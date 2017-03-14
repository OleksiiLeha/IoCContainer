using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Flow.Controllers
{
    class RegisterPageController : BasketWizardPageController<RegisterPage>
    {
        private RegisterPage page;

        public RegisterPageController(RegisterPage page)
            : base(page)
        {
            this.page = page;
        }
    }
}
