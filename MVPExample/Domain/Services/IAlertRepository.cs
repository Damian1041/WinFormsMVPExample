using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Model;

namespace Domain.Services
{
    public interface IAlertRepository
    {
        /// <summary>
        /// Gets all alerts in repository
        /// </summary>
        /// <returns>collection of stored alerts</returns>
        Task<IEnumerable<Alert>> All();
        /// <summary>
        /// Overrides all alerts in repository
        /// </summary>
        /// <param name="alerts">Collection of alerts to updated repository</param>
        /// <returns>Updated alerts</returns>
        Task<IEnumerable<Alert>> UpdateAll(IEnumerable<Alert> alerts);
    }
}
