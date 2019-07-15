using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Presentation;

namespace Task
{
    public class AppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMainView,IBusyIndicator>().To<MainView>().InSingletonScope();
            Bind<IMainPresenter>().To<MainPresenter>().InSingletonScope();
            Bind<IErrorNotifier>().To<MainView>();
        }
    }
}
