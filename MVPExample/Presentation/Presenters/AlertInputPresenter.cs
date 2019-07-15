using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Domain.Model;
using Domain.Services;
using Presentation.Presenters;
using Presentation.Views;


namespace Presentation.Presenters
{
    public class AlertInputPresenter : IAlertInputPresenter
    {
        private readonly IAlertInputView _view;
        private readonly IAlertService _alertService;
        private readonly IAlertRepository _alertRepository;
        private readonly IRemoteOperationManager _remoteOperationManager;
        /// <inheritdoc />
        public XtraUserControl View => _view as XtraUserControl;

        public AlertInputPresenter(IAlertInputView alertInputView,IAlertService alertService,
            IAlertRepository alertRepository, IRemoteOperationManager remoteOperationManager)
        {
            _view = alertInputView ?? throw new ArgumentNullException(nameof(alertInputView));
            _alertService = alertService ?? throw new ArgumentNullException(nameof(alertService));
            _alertRepository = alertRepository ?? throw new ArgumentNullException(nameof(alertRepository));
            _remoteOperationManager = remoteOperationManager ?? throw new ArgumentNullException(nameof(remoteOperationManager));
            SubscribeToEvents();
            LoadAlerts();
        }

        private void SubscribeToEvents()
        {
            _view.InputAccepted += _alertInputView_InputAccepted;
            _view.InputCancelled += _view_InputCancelled; ;
        }

        private void _view_InputCancelled()
        {
            ResetState();
        }

        private void _alertInputView_InputAccepted()
        {
            _remoteOperationManager.RunNoResultOperation(() => _alertService.SendAlert(_view.Message, _view.ConfirmationRequired, _view.Icon));
        }

        private void LoadAlerts()
        {
            _remoteOperationManager.RunWithResultOperation(_view,() => _alertRepository.All());
        }

        private void ResetState()
        {
            _view.Message = string.Empty;
            _view.ConfirmationRequired = false;
            _view.Icon = (Icon) Enum.GetValues(typeof(Icon)).GetValue(0);
        }

        
    }
}
