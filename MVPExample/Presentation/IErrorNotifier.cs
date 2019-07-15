using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IErrorNotifier
    {
        /// <summary>
        /// Opens error notification over main window
        /// </summary>
        /// <param name="errorTitle">Error Title</param>
        /// <param name="errorMessage">Error Message</param>
        void NotifyError(string errorTitle, string errorMessage);
    }
}
