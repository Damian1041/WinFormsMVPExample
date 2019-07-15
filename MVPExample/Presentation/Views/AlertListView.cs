using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Domain.Model;
using Icon = Domain.Model.Icon;

namespace Presentation.Views
{
    public partial class AlertListView : XtraUserControl, IAlertListView
    {
        /// <inheritdoc />
        public event Action SaveRequested;

        public AlertListView()
        {
            InitializeComponent();
            SetupIconsCombobox();
            this.Dock = DockStyle.Fill;
            SaveButton.Click += (s,a) => SaveRequested?.Invoke();
            
        }
        /// <inheritdoc />
        public IEnumerable<Alert> GetItems()
        {
            return AlertsGrid.DataSource as IEnumerable<Alert>;
        }
        /// <inheritdoc />
        public void SetDataSource(IEnumerable<Alert> alerts)
        {
            Invoke(new MethodInvoker(delegate()
            {
                var list = new BindingList<Alert>();
                foreach (var a in alerts)
                {
                    list.Add(a);
                }
                AlertsGrid.DataSource = list;
            }));
        }
        private void SetupIconsCombobox()
        {
            var images = new ImageCollection();
            var imageIndex = 0;
            foreach (Icon icon in (Icon[])Enum.GetValues(typeof(Icon)))
            {
                IconsComboBoxEdit.Items.Add(new ImageComboBoxItem()
                    { Description = icon.ToString(), ImageIndex = imageIndex, Value = icon});
                images.AddImage(Icons.ResourceManager.GetObject(icon.ToString()) as Bitmap);
                imageIndex++;
            }
            IconsComboBoxEdit.SmallImages = images;
        }
      
    }
}
