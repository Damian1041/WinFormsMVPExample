using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Services
{
    public interface IAlertNotifier
    {
        /// <summary>
        /// Sends alert to remote user
        /// </summary>
        /// <param name="alert">Alert to send</param>
        /// <returns>Async task while performing remote operation</returns>
        Task Notify(Alert alert);
    }
}
