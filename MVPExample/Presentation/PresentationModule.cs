using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Services;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using Presentation.Presenters;
using Presentation.Views;

namespace Presentation
{
    public class PresentationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAlertInputView>().To<AlertInputView>();
            Bind<IAlertInputPresenter>().To<AlertInputPresenter>();
            Bind<IAlertListView>().To<AlertListView>();
            Bind<IAlertListPresenter>().To<AlertListPresenter>();
            Bind<IRemoteOperationManager>().To<RemoteOperationManager>();
        }
    }
}
