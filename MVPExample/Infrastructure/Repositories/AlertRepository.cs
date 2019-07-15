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

namespace Infrastructure.Repositories
{
    public class AlertRepository : IAlertRepository
    {
        private readonly IAlertApi _alertApi;
        private readonly IMapper _mapper;
        /// <inheritdoc />
        public AlertRepository(IAlertApi alertApi, IMapper mapper)
        {
            _alertApi = alertApi ?? throw new ArgumentNullException(nameof(alertApi));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <inheritdoc />
        public async Task<IEnumerable<Alert>> All()
        {
            var apiResult = await _alertApi.All();
            return _mapper.Map<IEnumerable<AlertDto>, IEnumerable<Alert>>(apiResult);
        }
        /// <inheritdoc />
        public async Task<IEnumerable<Alert>> UpdateAll(IEnumerable<Alert> alerts)
        {
            var alertDtos = _mapper.Map<IEnumerable<Alert>, IEnumerable<AlertDto>>(alerts);
            var result = await _alertApi.UpdateAll(alertDtos);
            return _mapper.Map<IEnumerable<AlertDto>, IEnumerable<Alert>>(result);
        }
    }
}
