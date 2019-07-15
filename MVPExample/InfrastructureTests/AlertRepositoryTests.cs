using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertApiMock;
using AutoMapper;
using Domain.Model;
using FluentAssertions;
using Infrastructure.Repositories;
using Moq;
using NUnit.Framework;

namespace InfrastructureTests
{
    [TestFixture]
    public class AlertRepositoryTests
    {
        private readonly Mapper _mapper = new Mapper(new MapperConfiguration(cfg => {
            cfg.CreateMap<AlertDto, Alert>()
                .AfterMap((src, dest) =>
                {
                    Icon.TryParse(src.Icon, out Icon iconEnum);
                    dest.Icon = iconEnum;
                }).ReverseMap()
                .AfterMap((src, dest) => dest.Icon = src.Icon.ToString()); ;
        }));

        private readonly List<AlertDto> _apiCollection = new List<AlertDto>()
        {
            new AlertDto() { DisplayTime = 10, Favorite = true, Icon = Icon.Star.ToString(), Id = 1,Message = "msg 1",NeedsConfirmation = true},
            new AlertDto() { DisplayTime = 11, Favorite = false, Icon = Icon.Check.ToString(), Id = 2,Message = "msg 2",NeedsConfirmation = false},
            new AlertDto() { DisplayTime = 12, Favorite = false, Icon = Icon.Error.ToString(), Id =3,Message = "msg 3",NeedsConfirmation = false}
        };



        [Test]
        [Timeout(1000)]
        public async Task All_Should_ReturnAllAlertsFromApi()
        {
            //arrange
            var expected = new List<Alert>()
            {
                new Alert() { DisplayTime = 10, Favorite = true, Icon = Icon.Star, Id = 1,Message = "msg 1",NeedsConfirmation = true},
                new Alert() { DisplayTime = 11, Favorite = false, Icon = Icon.Check, Id = 2,Message = "msg 2",NeedsConfirmation = false},
                new Alert() { DisplayTime = 12, Favorite = false, Icon = Icon.Error, Id =3,Message = "msg 3",NeedsConfirmation = false}
            };
            var api = new Mock<IAlertApi>();
            api.Setup(a => a.All()).Returns(Task.FromResult((IEnumerable<AlertDto>)_apiCollection));
            var repository = new AlertRepository(api.Object, _mapper);

            //act
            var actual = await repository.All();

            //assert
            actual.Should().BeEquivalentTo(expected);

        }

        [Test]
        [Timeout(1000)]
        public async Task UpdateAll_Should_SendAllAlertsToApi()
        {
            //arrange
            var expected = new List<AlertDto>()
            {
                new AlertDto() { DisplayTime = 10, Favorite = true, Icon = Icon.Star.ToString(), Id = 1,Message = "msg 1",NeedsConfirmation = true},
                new AlertDto() { DisplayTime = 11, Favorite = false, Icon = Icon.Check.ToString(), Id = 2,Message = "msg 2",NeedsConfirmation = false},
                new AlertDto() { DisplayTime = 12, Favorite = false, Icon = Icon.Error.ToString(), Id =3,Message = "msg 3",NeedsConfirmation = false}
            };
            var values = new List<Alert>()
            {
                new Alert() { DisplayTime = 10, Favorite = true, Icon = Icon.Star, Id = 1,Message = "msg 1",NeedsConfirmation = true},
                new Alert() { DisplayTime = 11, Favorite = false, Icon = Icon.Check, Id = 2,Message = "msg 2",NeedsConfirmation = false},
                new Alert() { DisplayTime = 12, Favorite = false, Icon = Icon.Error, Id =3,Message = "msg 3",NeedsConfirmation = false}
            };
            IEnumerable<AlertDto> actual = null;
            var api = new Mock<IAlertApi>();
            api.Setup(a => a.UpdateAll(It.IsAny<IEnumerable<AlertDto>>()))
                .Callback<IEnumerable<AlertDto>>(c => actual = c);
            var repository = new AlertRepository(api.Object,_mapper);

            //act
            var result = await repository.UpdateAll(values);

            //assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        [Timeout(1000)]
        public async Task UpdateAll_Should_ReturnUpdatedAlertsFromApi()
        {
            var values = new List<Alert>()
            {
                new Alert() { DisplayTime = 10, Favorite = true, Icon = Icon.Star, Id = 1,Message = "msg 1",NeedsConfirmation = true},
                new Alert() { DisplayTime = 11, Favorite = false, Icon = Icon.Check, Id = 2,Message = "msg 2",NeedsConfirmation = false},
                new Alert() { DisplayTime = 12, Favorite = false, Icon = Icon.Error, Id =3,Message = "msg 3",NeedsConfirmation = false}
            };
            var api = new Mock<IAlertApi>();
            api.Setup(a => a.UpdateAll(It.IsAny<IEnumerable<AlertDto>>())).Returns(Task.FromResult((IEnumerable<AlertDto>)_apiCollection));
            var repository = new AlertRepository(api.Object, _mapper);

            //act
            var actual = await repository.UpdateAll(values);

            //assert
            actual.Should().BeEquivalentTo(values);
        }
    }
}
