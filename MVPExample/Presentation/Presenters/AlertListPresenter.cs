using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Domain.Model;
using Domain.Services;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class AlertListPresenter : IAlertListPresenter
    {
        private readonly IAlertListView _view;
        private readonly IAlertRepository _alertRepository;
        private readonly IRemoteOperationManager _remoteOperationManager;
        /// <inheritdoc />
        public XtraUserControl View => _view as XtraUserControl;

        public AlertListPresenter(IAlertListView alertListView, IAlertRepository alertRepository,IRemoteOperationManager remoteOperationManager)
        {
            _view = alertListView ?? throw new ArgumentNullException(nameof(alertListView));
            _alertRepository = alertRepository ?? throw new ArgumentNullException(nameof(alertRepository));
            _remoteOperationManager = remoteOperationManager ?? throw new ArgumentNullException(nameof(remoteOperationManager));
            _view.SaveRequested += View_SaveRequested;
            LoadAlerts();
        }

        private void  View_SaveRequested()
        {
            var alerts = _view.GetItems();
            _remoteOperationManager.RunWithResultOperation(_view,() => _alertRepository.UpdateAll(alerts));
        }

        private void LoadAlerts()
        {
            _remoteOperationManager.RunWithResultOperation(_view, () => _alertRepository.All());
        }
    }
}
