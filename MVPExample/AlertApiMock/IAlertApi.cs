using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlertApiMock
{
    public interface IAlertApi
    {
        /// <summary>
        /// Get all of the alerts in storage
        /// </summary>
        /// <returns>Collection of all alerts stored</returns>
        Task<IEnumerable<AlertDto>> All();
        /// <summary>
        /// Sends alert to remote user
        /// </summary>
        /// <param name="alert">Alert to send</param>
        /// <returns>Value indicating if operation was successful</returns>
        Task<bool> Send(AlertDto alert);
        /// <summary>
        /// Overrides entire collection of stored alerts
        /// </summary>
        /// <param name="alerts">Collection of modified alerts</param>
        /// <returns>Updated collection of alerts</returns>
        Task<IEnumerable<AlertDto>> UpdateAll(IEnumerable<AlertDto> alerts);
    }
}
