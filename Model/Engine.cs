using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson2_Flow
{
    public class Engine : IEngine
    {
      
        private static IDictionary<string, Page> BasketFlow = new Dictionary<string, Page>();

        private static Random random = new Random();

        private IEngine engine;

        public Engine(IEngine engine)
        {
            this.engine = engine;
        }
        //public Engine()
        //{
        //}
        static Engine()
        {
            BasketFlow.Add(Pages_Name.BasketPage.ToString(), GetPage(typeof(BasketPage), WizardPagesNames_List.BasketPage.ToString()));
            BasketFlow.Add(Pages_Name.SuccessPayment.ToString(), GetPage(typeof(FinalPage), WizardPagesNames_List.SuccessPayment.ToString()));
            BasketFlow.Add(Pages_Name.FailPayment.ToString(), GetPage(typeof(FinalPage), WizardPagesNames_List.FailPayment.ToString()));
            BasketFlow.Add(Pages_Name.RegisterPage.ToString(), GetPage(typeof(RegisterPage), WizardPagesNames_List.RegisterPage.ToString()));
            //BasketFlow.Add(Pages_Name.DetailsPage.ToString(), GetPage(typeof(DetailsPage), WizardPagesNames_List.DetailsPage.ToString()));
        }

        private static Page GetPage(Type pageType, string WizardPageName)
        {
            foreach(var page in PageStore.Pages)
            {
                var wizardPage = page as IWizardPage;
                if(wizardPage != null && page.GetType() == pageType && wizardPage.WizardPageName == WizardPageName)
                {
                    return page;
                }
            }
            
            return null;
        }

        public Page Go<TPage> (TPage page)
            where TPage : Page, IWizardPage
        {
            var startPage = PageStore.Pages.OfType<StartPage>().SingleOrDefault();

            if (BasketFlow.ContainsKey(page.WizardPageName))
            {
                if(page.WizardPageName == WizardPagesNames_List.BasketPage.ToString() || page.WizardPageName == WizardPagesNames_List.RegisterPage.ToString())
                {
                    return (random.Next(2) % 2 == 0)
                        ? BasketFlow[Pages_Name.SuccessPayment.ToString()] : BasketFlow[Pages_Name.FailPayment.ToString()];
                    
                }
                
            }
            return startPage;
        }
        
    }
}
