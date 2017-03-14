using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Flow
{
    enum Pages_Name
    {
        StartPage,
        BasketPage,
        FinalPage,
        SuccessPayment,
        FailPayment,

        RegisterPage,
        DetailsPage
    };

    enum WizardPagesNames_List
    {
        BasketPage,
        SuccessPayment,
        FailPayment,

        RegisterPage,
        DetailsPage
    };


    public abstract class Page
    {
        

        public string Name { get; set; }
    }
}
