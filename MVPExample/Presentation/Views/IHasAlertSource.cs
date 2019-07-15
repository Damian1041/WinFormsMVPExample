using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Presentation.Views
{
    public interface IHasAlertSource
    {
        /// <summary>
        /// Sets collection of alerts to operate with at user interface
        /// </summary>
        /// <param name="alerts">Collection of alerts</param>
        void SetDataSource(IEnumerable<Alert> alerts);
    }
}
