using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.FluentDesignSystem;
using Presentation.Presenters;

namespace Task
{
    public interface IMainPresenter 
    {
        /// <summary>
        /// Main form of the application
        /// </summary>
        FluentDesignForm View { get; }
    }
}
