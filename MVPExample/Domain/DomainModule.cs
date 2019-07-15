using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Services;
using Ninject.Modules;

namespace Domain
{
    public class DomainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAlertService>().To<AlertService>();
        }
    }
}
