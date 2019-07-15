using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using Presentation.Presenters;

namespace Task
{
    public interface IMainView
    {
        /// <summary>
        /// Hosts user control inside main view container
        /// </summary>
        /// <typeparam name="T">Type of the presenter handling user control to be hosted</typeparam>
        void HostView<T>() where T : IUserControlPresenter;
        /// <summary>
        /// Hosts AlertInputPresenter
        /// </summary>
        event Action OpenAlertInput;
        /// <summary>
        /// Hosts AlertListPresenter
        /// </summary>
        event Action OpenAlertList;
    }
}
