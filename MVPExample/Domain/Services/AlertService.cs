using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Services
{
    public class AlertService : IAlertService
    {
        private readonly IAlertNotifier _alertNotifier;

        public AlertService( IAlertNotifier alertNotifier)
        {
            _alertNotifier = alertNotifier ?? throw new ArgumentNullException(nameof(alertNotifier));
        }
        /// <inheritdoc />
        public async Task SendAlert(string input, bool requireConfirmation, Icon icon)
        {
            var alert = new Alert()
            {
                Message = input,
                NeedsConfirmation = requireConfirmation,
                Icon = icon
            };
            await _alertNotifier.Notify(alert);
        }
    }
}
