using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Services;
using Moq;
using NUnit.Framework;
using Presentation;
using Presentation.Presenters;
using Presentation.Views;

namespace PresentationTests
{
    [TestFixture]
    public class AlertInputPresenterTests
    {
        [Test]
        public void InvokingInputCancelled_Should_ResetViewState()
        {
            //arrange
            var view = new Mock<IAlertInputView>();
            var expectedIcon = ((IEnumerable<Icon>) Enum.GetValues(typeof(Icon))).FirstOrDefault();
            var presenter = new AlertInputPresenter(view.Object, new Mock<IAlertService>().Object,
                new Mock<IAlertRepository>().Object, new Mock<IRemoteOperationManager>().Object);

            //act
            view.Raise(v => v.InputCancelled += null);

            //assert
            view.VerifySet(v => v.Message = string.Empty);
            view.VerifySet(v => v.ConfirmationRequired = false);
            view.VerifySet(v => v.Icon = expectedIcon);
        }

        [Test]
        public void InvokingInputAccepted_Should_RunSendAlertOperation()
        {
            //arrange
            var view = new Mock<IAlertInputView>();
            var remoteOperationManager = new Mock<IRemoteOperationManager>();
            var presenter = new AlertInputPresenter(view.Object, new Mock<IAlertService>().Object,
                new Mock<IAlertRepository>().Object, remoteOperationManager.Object);

            //act
            view.Raise(v => v.InputAccepted += null);

            //assert
            remoteOperationManager.Verify(r => r.RunNoResultOperation(It.IsAny<Func<Task>>()));
        }

        [Test]
        public void Constructor_Should_RunAllAlertsOperation()
        {
            //arrange
            var view = new Mock<IAlertInputView>();
            var remoteOperationManager = new Mock<IRemoteOperationManager>();

            //act
            var presenter = new AlertInputPresenter(view.Object, new Mock<IAlertService>().Object,
                new Mock<IAlertRepository>().Object, remoteOperationManager.Object);

            //assert
            remoteOperationManager.Verify(r => r.RunWithResultOperation(view.Object,It.IsAny<Func<Task<IEnumerable<Alert>>>>()));
        }
    };
}