using System;
using System.Collections.ObjectModel;
using Prism.Navigation;
using UpdatedArabianDall.Modal;

namespace UpdatedArabianDall.ViewModal
{
    public class LandingPageViewModel : BaseViewModel
    {
        public LandingPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Slides = new ObservableCollection<Slide>(new[]
            {
                new Slide("landing01.jpg", "Some description for slide one."),
                new Slide("landing02.jpg", "Some description for slide two."),
                new Slide("landing03.png", "Some description for slide three.")
            });
        }

        public ObservableCollection<Slide> Slides { get; }
    }
}