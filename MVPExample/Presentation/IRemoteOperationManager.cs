using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Presentation.Views;

namespace Presentation
{
    public interface IRemoteOperationManager
    {
        /// <summary>
        /// Runs remote operation notifying busy indicator and errorNotifier if required and sets result to the target
        /// </summary>
        /// <param name="target">Target that requires result</param>
        /// <param name="remoteOperation">Operation to be performed</param>
        /// <returns>Task indicating async operation</returns>
        Task RunWithResultOperation(IHasAlertSource target, Func<Task<IEnumerable<Alert>>> remoteOperation);
        /// <summary>
        /// Runs remote operation notifying busy indicator and errorNotifier if required
        /// </summary>
        /// <param name="remoteOperation">Operation to be performed</param>
        /// <returns>Task indicating async operation</returns>
        Task RunNoResultOperation(Func<Task> remoteOperation);
    }
}
