using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertApiMock
{
    public class AlertApi : IAlertApi
    {
        private static readonly List<AlertDto> Alerts = new List<AlertDto>()
        {
            new AlertDto() {DisplayTime = 10, Favorite = false, NeedsConfirmation = false, Id = 1, Message = "First alert message", Icon = "Check"},
            new AlertDto() {DisplayTime = 10, Favorite = false, NeedsConfirmation = false, Id = 2, Message = "Second alert message", Icon = "Star"},
            new AlertDto() {DisplayTime = 10, Favorite = true, NeedsConfirmation = false, Id = 3, Message = "Third alert message", Icon = "Error"},
            new AlertDto() {DisplayTime = 10, Favorite = true, NeedsConfirmation = false, Id = 4, Message = "Forth alert message", Icon = "Star"},
        };

        /// <inheritdoc />
        public async Task<IEnumerable<AlertDto>> All()
        {
            //Its just to mock long running operation
            await Task.Delay(2000);

            return await Task.FromResult(Alerts);
        }
        /// <inheritdoc />
        public async Task<bool> Send(AlertDto alert)
        {
            //Its just to mock long running operation
            await Task.Delay(2000);

            return await Task.FromResult<bool>(true);
        }
        /// <inheritdoc />
        public async Task<IEnumerable<AlertDto>> UpdateAll(IEnumerable<AlertDto> alerts)
        {
            //Its just to mock long running operation
            await Task.Delay(2000);

            var sent = alerts.ToList();
            RemoveOld(sent);
            AddNew(sent);
            UpdateExisting(sent);
            return Alerts;
        }

        private void RemoveOld(IEnumerable<AlertDto> alerts)
        {
            var oldItems = Alerts.Where(a => !alerts.Select(x => x.Id).Contains(a.Id)).ToList();
            for (var i = 0; i < oldItems.Count; i++)
            {
                Alerts.Remove(oldItems.ElementAt(i));
            }
        }

        private void AddNew(IEnumerable<AlertDto> alerts)
        {
            var newItems = alerts.Where(a => a.Id == 0);
            foreach (var item in newItems)
            {
                item.Id = Alerts.Any() ? Alerts.Select(a => a.Id).Max() + 1 : 1;
                Alerts.Add(item);
            }
        }

        private void UpdateExisting(IEnumerable<AlertDto> alerts)
        {
            var existingItems = alerts.Where(a => Alerts.Select(x => x.Id).Contains(a.Id));
            foreach (var item in existingItems)
            {
                var alert = Alerts.FirstOrDefault(a => a.Id == item.Id);
                if (alert != null)
                {
                    alert.DisplayTime = item.DisplayTime;
                    alert.Favorite = item.Favorite;
                    alert.NeedsConfirmation = item.NeedsConfirmation;
                    alert.Icon = item.Icon;
                    alert.Message = item.Message;
                }
            }
        }
    }
}
