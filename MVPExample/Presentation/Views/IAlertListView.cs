using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Controls;
using Domain.Model;

namespace Presentation.Views
{
    public interface IAlertListView : IHasAlertSource
    {
        /// <summary>
        /// Gets updated alerts from user interface
        /// </summary>
        /// <returns>Collection of updated alerts</returns>
        IEnumerable<Alert> GetItems();
        /// <summary>
        /// Raised when save operation is requested by user interface
        /// </summary>
        event Action SaveRequested;
    }
}
