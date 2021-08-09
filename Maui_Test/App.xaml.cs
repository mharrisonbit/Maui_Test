using System.Threading.Tasks;
using Maui_Test.ViewModels;
using Maui_Test.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Prism;
using Prism.Ioc;
using Prism.Navigation;

namespace Maui_Test
{
    public partial class App : PrismApplication
    {
        public App(IContainerExtension container)
            : base(container)
        {
        }

        protected override async Task OnWindowCreated(IActivationState activationState)
        {
            try
            {
                Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);

                this.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
                    .SetImageDirectory("Assets");

                var results = await NavigationService.NavigateAsync("/NavigationPage/MainPageView");
                if (!results.Success)
                {
                    System.Diagnostics.Debugger.Break();
                }
            }
            catch (System.Exception)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPageView, MainPageViewModel>();
        }
    }
}
