using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Flow
{
    
    public sealed class PageStore
    {
        

        
        private static readonly PageStore instance = new PageStore();
        private IEnumerable<Page> pages;
        static PageStore()
        {}
        private PageStore()
        {
            pages = new List<Page>
            {
                new StartPage {Name = Pages_Name.StartPage.ToString()},
                new BasketPage {Name = Pages_Name.BasketPage.ToString(), WizardPageName = WizardPagesNames_List.BasketPage.ToString()},
                new FinalPage {Name = Pages_Name.FinalPage.ToString(), WizardPageName = WizardPagesNames_List.SuccessPayment.ToString()},
                new FinalPage {Name = Pages_Name.FinalPage.ToString(), WizardPageName = WizardPagesNames_List.FailPayment.ToString()},
                new RegisterPage {Name = Pages_Name.RegisterPage.ToString(), WizardPageName = WizardPagesNames_List.RegisterPage.ToString()}
                //new DetailsPage {Name = Pages_Name.DetailsPage.ToString(), WizardPageName = WizardPagesNames_List.DetailsPage.ToString()}
            };
        }
        public static IEnumerable<Page> Pages
        {
            get 
            {
                return instance.pages; 
            }
        }
    }
}
