using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infrastructure;
using Ninject;
using Ninject.Modules;
using Presentation;

namespace Task
{
    public static class CompositionRoot
    {
        private static IKernel _kernel;

        public static void Create()
        {
            _kernel = new StandardKernel( new AppModule(), new PresentationModule(), new DomainModule(), new InfrastructureModule());
        }

        public static T Resolve<T>()
        {
            return _kernel.Get<T>();
        }

    }
}
