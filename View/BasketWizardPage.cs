using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Flow
{
    public abstract class BasketWizardPage : Page, IWizardPage
    {
        public string WizardPageName { get; set; }
    }
}
