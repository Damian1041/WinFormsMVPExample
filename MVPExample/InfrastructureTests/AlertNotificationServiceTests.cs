using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertApiMock;
using AutoMapper;
using Domain.Model;
using FluentAssertions;
using Infrastructure.Services;
using Moq;
using NUnit.Framework;

namespace InfrastructureTests
{
    [TestFixture]
    public class AlertNotificationServiceTests
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

        [Test]
        [Timeout(1000)]
        public async Task Notify_Should_SendAlertDtoToApi()
        {
            //arrange
            Alert value = new Alert()
            {
                DisplayTime = 10,
                Favorite = true,
                Icon = Icon.Error,
                Message = "Message",
                NeedsConfirmation = true
            };
            AlertDto actual = null;
            var api = new Mock<IAlertApi>();
            api.Setup(a => a.Send(It.IsAny<AlertDto>())).Callback<AlertDto>(dto => actual = dto);
            var service = new AlertNotificationService(api.Object,_mapper);

            //act
            await service.Notify(value);

            //assert
            actual.Should().NotBeNull();
            actual.DisplayTime.Should().Be(value.DisplayTime);
            actual.Favorite.Should().Be(value.Favorite);
            actual.Icon.Should().Be(value.Icon.ToString());
            actual.Message.Should().Be(value.Message);
            actual.NeedsConfirmation.Should().Be(value.NeedsConfirmation);

        }
    }
}
