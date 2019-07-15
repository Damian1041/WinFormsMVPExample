using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IBusyIndicator
    {
        /// <summary>
        /// Shows busy indicator overlay over main window
        /// </summary>
        void ShowIndicator();
        /// <summary>
        /// Hides busy indicator if shown
        /// </summary>
        void HideIndicator();
    }
}
