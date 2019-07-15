using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Services;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace DomainTests
{
    [TestFixture]
    public class AlertServiceTests
    {
        [Timeout(1000)]
        [TestCase("message 1", true, Icon.Error)]
        [TestCase("!message_2", false, Icon.Check)]
        [TestCase("2 Message_3", false, Icon.Star)]
        public async Task SendAlert_Should_SendNewAlert(string message,bool confirmation, Icon icon)
        {
            //arrange
            Alert actual = null;
            var notifier = new Mock<IAlertNotifier>();
            notifier.Setup(n => n.Notify(It.IsAny<Alert>())).Callback<Alert>(a => actual = a);
            var service = new AlertService(notifier.Object);

            //act
            await service.SendAlert(message, confirmation,icon);

            //assert
            actual.Should().NotBeNull();
            actual.Message.Should().BeEquivalentTo(message);
            actual.NeedsConfirmation.Should().Be(confirmation);
            actual.Icon.Should().Be(icon);
        }
    }
}
