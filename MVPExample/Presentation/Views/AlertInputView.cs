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
    public partial class AlertInputView : XtraUserControl, IAlertInputView
    {
        private BindingList<Alert> _source = new BindingList<Alert>();
        /// <inheritdoc />
        public event Action InputAccepted;
        /// <inheritdoc />
        public event Action InputCancelled;
        /// <inheritdoc />
        public void SetDataSource(IEnumerable<Alert> alerts)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                var list = new BindingList<Alert>();
                foreach (var a in alerts.OrderByDescending(a => a.Favorite).ThenBy(a => a.Message).ToList())
                {
                    list.Add(a);
                }
                _source = list;
                AlertLookup.Properties.DataSource = list;
                AlertLookup.Properties.DisplayMember = nameof(Alert.Message);
            }));
        }
        /// <inheritdoc />
        public Icon Icon
        {
            get => (Icon) ((ImageComboBoxItem) IconComboBox.SelectedItem).Value;
            set => Invoke(new MethodInvoker(delegate()
            {
                var items = (IEnumerable<ImageComboBoxItem>) IconComboBox.Properties.Items;
                IconComboBox.SelectedItem = items.FirstOrDefault(i => (Icon)i.Value == value);
            }));
        }
        /// <inheritdoc />
        public string Message
        {
            get => AlertLookup.Text;
            set => Invoke(new MethodInvoker(delegate() { AlertLookup.Text = value; })); 
        }
        /// <inheritdoc />
        public bool ConfirmationRequired
        {
            get => ConfirmationCheckEdit.Checked; 
            set => Invoke(new MethodInvoker(delegate() { ConfirmationCheckEdit.Checked = value; })); 
        }

        public AlertInputView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            SetupIconsCombobox();
            AlertLookup.EditValueChanged += AlertLookup_EditValueChanged;
            OkButton.Click += (s, a) => InputAccepted?.Invoke();
            CancelButton.Click += (s, a) => InputCancelled?.Invoke();
        }

        private void AlertLookup_EditValueChanged(object sender, EventArgs e)
        {
            if (AlertLookup.ItemIndex >= 0)
            {
                var selectedElement = _source.ElementAt(AlertLookup.ItemIndex);
                ConfirmationRequired = selectedElement.NeedsConfirmation;
                Icon = selectedElement.Icon;
            }
        }

        private void SetupIconsCombobox()
        {
            var images = new ImageCollection();
            var imageIndex = 0;
            foreach (Icon icon in (Icon[])Enum.GetValues(typeof(Icon)))
            {
                IconComboBox.Properties.Items.Add(new ImageComboBoxItem()
                    { Description = icon.ToString(), ImageIndex = imageIndex, Value = icon });
                images.AddImage(Icons.ResourceManager.GetObject(icon.ToString()) as Bitmap);
                imageIndex++;
            }
            IconComboBox.Properties.SmallImages = images;
            IconComboBox.SelectedItem = IconComboBox.Properties.Items.FirstOrDefault();
        }
    }
}
