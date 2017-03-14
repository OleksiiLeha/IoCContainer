using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Flow
{
    public interface IEngine
    {
        //Page GetPage(Type pageType, string WizardPageName);

        Page Go<TPage>(TPage page)
            where TPage : Page, IWizardPage;
    }
}
