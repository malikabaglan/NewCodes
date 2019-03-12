using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace UpdatedArabianDall.ViewModal
{

    public abstract class BaseViewModel : BindableBase, INavigationAware
    {
        protected readonly INavigationService NavigationService;

        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}






