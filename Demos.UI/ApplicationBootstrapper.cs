using Demos.UI.Views;
using Prism.Unity;
using Microsoft.Practices.Unity;
using System.Windows;

namespace Demos.UI
{
    class ApplicationBootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<ApplicationShell>();
        }
        protected override void InitializeShell()
        {
            App.Current.MainWindow.Show();
        }
    }
}
