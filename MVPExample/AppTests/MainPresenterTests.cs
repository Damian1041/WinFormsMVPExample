using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Presentation.Presenters;
using Task;

namespace AppTests
{
    [TestFixture]
    public class MainPresenterTests
    {
        [Test]
        public void InvokingOpenAlertInput_Should_HostIAlertInputPresenter()
        {
            //arrange
            var view = new Mock<IMainView>();
            var presenter = new MainPresenter(view.Object);

            //act
            view.Raise(v => v.OpenAlertInput += null);

            //assert
            view.Verify(v => v.HostView<IAlertInputPresenter>());
        }

        [Test]
        public void InvokingOpenAlertList_Should_HostIAlertListPresenter()
        {
            //arrange
            var view = new Mock<IMainView>();
            var presenter = new MainPresenter(view.Object);

            //act
            view.Raise(v => v.OpenAlertList += null);

            //assert
            view.Verify(v => v.HostView<IAlertListPresenter>());
        }
    }
}
