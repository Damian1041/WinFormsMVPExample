using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Services
{
    public interface IAlertService
    {
        /// <summary>
        /// Creates alert from provided values and sends it to remote user
        /// </summary>
        /// <param name="message">Message to send</param>
        /// <param name="requireConfirmation">Is confirmation required</param>
        /// <param name="icon">Icon to display</param>
        /// <returns>Async task while performing remote operation</returns>
        Task SendAlert(string message, bool requireConfirmation, Icon icon);
    }
}
