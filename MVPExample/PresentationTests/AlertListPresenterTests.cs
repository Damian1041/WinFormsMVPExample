using System;
using System.Collections;
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
    public class AlertListPresenterTests
    {
        [Test]
        public void InvokingSaveRequested_Should_RunUpdateAllOperation()
        {
            //arrange
            var view = new Mock<IAlertListView>();
            var remoteOperationManager = new Mock<IRemoteOperationManager>();
            var presenter = new AlertListPresenter(view.Object, new Mock<IAlertRepository>().Object,
                remoteOperationManager.Object);

            //act
            view.Raise(v => v.SaveRequested += null);

            //assert
            remoteOperationManager.Verify(r => r.RunWithResultOperation(view.Object,It.IsAny<Func<Task<IEnumerable<Alert>>>>()));
        }

        [Test]
        [Timeout(1000)]
        public void Constructor_Should_RunAllAlertsOperation()
        {
            //arrange
            var view = new Mock<IAlertListView>();
            var remoteOperationManager = new Mock<IRemoteOperationManager>();
            

            //act
            var presenter = new AlertListPresenter(view.Object, new Mock<IAlertRepository>().Object,
                remoteOperationManager.Object);

            //assert
            remoteOperationManager.Verify(r => r.RunWithResultOperation(view.Object, It.IsAny<Func<Task<IEnumerable<Alert>>>>()));
        }
    }
}
