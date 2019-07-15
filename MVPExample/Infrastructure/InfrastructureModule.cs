using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertApiMock;
using AutoMapper;
using Domain;
using Domain.Model;
using Domain.Services;
using Infrastructure;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Ninject;
using Ninject.Modules;
using Ninject.Planning.Bindings;

namespace Infrastructure
{
    public class InfrastructureModule : NinjectModule
    {
        public override void Load()
        {
            var mapperConfiguration = CreateConfiguration();
            Bind<MapperConfiguration>().ToConstant(mapperConfiguration).InSingletonScope();
            Bind<IMapper>().ToMethod(ctx => new Mapper(mapperConfiguration, type => ctx.Kernel.Get(type)));

            Bind<IAlertRepository>().To<AlertRepository>();
            Bind<IAlertApi>().To<AlertApiMock.AlertApi>();
            Bind<IAlertNotifier>().To<AlertNotificationService>();
        }

        private MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<AlertDto, Alert>()
                .AfterMap((src, dest) =>
                {
                    Icon.TryParse(src.Icon, out Icon iconEnum);
                    dest.Icon = iconEnum;
                }).ReverseMap()
                .AfterMap((src, dest) => dest.Icon = src.Icon.ToString()); ; });

            return config;
        }
    }
}
