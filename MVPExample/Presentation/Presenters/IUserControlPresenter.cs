using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Presentation.Presenters
{
    public interface IUserControlPresenter
    {
        /// <summary>
        /// Returns view that presenter is operating with
        /// </summary>
        XtraUserControl View { get; }
    }
}
