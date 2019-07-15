using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Services;
using Presentation.Views;

namespace Presentation
{
    public class RemoteOperationManager : IRemoteOperationManager
    {
        private readonly IBusyIndicator _busyIndicator;
        private readonly IErrorNotifier _errorNotifier;

        public RemoteOperationManager(IBusyIndicator busyIndicator, IErrorNotifier errorNotifier)
        {
            _busyIndicator = busyIndicator ?? throw new ArgumentNullException(nameof(busyIndicator));
            _errorNotifier = errorNotifier ?? throw new ArgumentNullException(nameof(errorNotifier));
        }
        /// <inheritdoc />
        public async Task RunWithResultOperation(IHasAlertSource target, Func<Task<IEnumerable<Alert>>> remoteOperation)
        {
            IEnumerable<Alert> result = null;
            await Task.Factory.StartNew(async () =>
            {
                try
                {
                    _busyIndicator.ShowIndicator();
                    result = await remoteOperation.Invoke();
                }
                catch (TimeoutException exception)
                {
                    _errorNotifier.NotifyError("Timeout Exception", exception.Message);
                }
                catch (CommunicationException exception)
                {
                    _errorNotifier.NotifyError("Connection Exception", exception.Message);
                }
                finally
                {
                    _busyIndicator.HideIndicator();
                    target.SetDataSource(result);
                }
            }, TaskCreationOptions.AttachedToParent);
        }
        /// <inheritdoc />
        public async Task RunNoResultOperation(Func<Task> remoteOperation)
        {
            await Task.Factory.StartNew(async () =>
            {
                try
                {
                    _busyIndicator.ShowIndicator();
                    await remoteOperation.Invoke();
                }
                catch (TimeoutException exception)
                {
                    _errorNotifier.NotifyError("Timeout Exception", exception.Message);
                }
                catch (CommunicationException exception)
                {
                    _errorNotifier.NotifyError("Connection Exception", exception.Message);
                }
                finally
                {
                    _busyIndicator.HideIndicator();
                }
            },TaskCreationOptions.AttachedToParent);

        }
    }
}
