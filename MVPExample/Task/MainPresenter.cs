using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.FluentDesignSystem;
using Presentation.Presenters;

namespace Task
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView _view;
        /// <inheritdoc />
        public FluentDesignForm View => _view as FluentDesignForm;

        public MainPresenter(IMainView mainView)
        {
            _view = mainView ?? throw new ArgumentNullException(nameof(mainView));
            _view.OpenAlertInput +=  () => _view.HostView<IAlertInputPresenter>();
            _view.OpenAlertList += () => _view.HostView<IAlertListPresenter>();
        }
    }
}
