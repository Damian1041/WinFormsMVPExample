using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertApiMock;
using AutoMapper;
using Domain;
using Domain.Model;
using Domain.Services;

namespace Infrastructure.Services
{
    public class AlertNotificationService : IAlertNotifier
    {
        private readonly IAlertApi _alertApi;
        private readonly IMapper _mapper;

        public AlertNotificationService(IAlertApi alertApi, IMapper mapper)
        {
            _alertApi = alertApi ?? throw new ArgumentNullException(nameof(alertApi));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <inheritdoc />
        public async Task Notify(Alert alert)
        {
            await _alertApi.Send(_mapper.Map<Alert, AlertDto>(alert));
        }
    }
}
