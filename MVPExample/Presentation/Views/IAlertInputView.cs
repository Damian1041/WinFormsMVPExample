using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Presentation.Views
{
    public interface IAlertInputView : IHasAlertSource
    {
        /// <summary>
        /// Raised when user accepts input
        /// </summary>
        event Action InputAccepted;
        /// <summary>
        /// Raised when user cancels input
        /// </summary>
        event Action InputCancelled;
        /// <summary>
        /// Current message
        /// </summary>
        string Message { get; set; }
        /// <summary>
        /// Current confirmation status
        /// </summary>
        bool ConfirmationRequired { get; set; }
        /// <summary>
        /// Currently selected icon
        /// </summary>
        Icon Icon { get; set; }
    }
}
