using System;
using System.Reflection;
using Prism.Autofac;
using Prism.Ioc;
using UpdatedArabianDall.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace UpdatedArabianDall
{


public partial class App : PrismApplication
{
    protected override void OnInitialized()
    {
        InitializeComponent();

        NavigationService.NavigateAsync("landing");
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.AutoRegisterMvvmComponents(typeof(App).GetTypeInfo().Assembly);
    }
}
}