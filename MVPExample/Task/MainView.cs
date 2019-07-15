using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraSplashScreen;
using Presentation;
using Presentation.Presenters;

namespace Task
{
    public partial class MainView : FluentDesignForm, IMainView,IBusyIndicator,IErrorNotifier
    {
        public MainView()
        {
            InitializeComponent();
            AlertInputItem.Click += (s, o) => OpenAlertInput?.Invoke();
            AlertsListItem.Click += (s, o) => OpenAlertList?.Invoke();
        }
        /// <inheritdoc />
        public void HostView<T>() where T : IUserControlPresenter
        {
            MainContainer.Controls.Clear();
            MainContainer.Controls.Add(CompositionRoot.Resolve<T>().View);
        }
        /// <inheritdoc />
        public event Action OpenAlertInput;
        /// <inheritdoc />
        public event Action OpenAlertList;

        IOverlaySplashScreenHandle handle = null;
        /// <inheritdoc />
        public void ShowIndicator()
        {
            Invoke(new MethodInvoker(delegate () {
                    if (handle == null)
                        CreateHandle();
                    handle = SplashScreenManager.ShowOverlayForm(this);
                }));
            
        }
        /// <inheritdoc />
        public void HideIndicator()
        {
            Invoke(new MethodInvoker(delegate()
            {
                if (handle != null)
                    SplashScreenManager.CloseOverlayForm(handle);
            }));
        }
        /// <inheritdoc />
        public void NotifyError(string errorTitle, string errorMessage)
        {
            var dialog = new FlyoutDialog(this, new FlyoutAction(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1)
            {
                Caption = errorTitle,
                Description = errorMessage
            });
            dialog.ShowDialog();
        }
    }
}
