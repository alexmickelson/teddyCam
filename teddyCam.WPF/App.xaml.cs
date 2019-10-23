using CommonServiceLocator;
using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using teddyCam.WPF.Views;

namespace teddyCam.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {

        protected override Window CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindowView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // FOR REFERENCE
            //containerRegistry.Register(typeof(PokeTypeRegistry), typeof(PokeTypeRegistry));
            //containerRegistry.RegisterForNavigation<PokedexView>();
        }
    }
}
