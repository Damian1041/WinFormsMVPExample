namespace Presentation.Views
{
    partial class AlertListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlertsGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Message = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Favorite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NeedsConfirmation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DisplayTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Icon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IconsComboBoxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.AlertsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconsComboBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // AlertsGrid
            // 
            this.AlertsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlertsGrid.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.AlertsGrid.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.AlertsGrid.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.AlertsGrid.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.AlertsGrid.Location = new System.Drawing.Point(3, 3);
            this.AlertsGrid.MainView = this.gridView1;
            this.AlertsGrid.Name = "AlertsGrid";
            this.AlertsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.IconsComboBoxEdit});
            this.AlertsGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AlertsGrid.Size = new System.Drawing.Size(494, 445);
            this.AlertsGrid.TabIndex = 2;
            this.AlertsGrid.UseEmbeddedNavigator = true;
            this.AlertsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Message,
            this.Favorite,
            this.NeedsConfirmation,
            this.DisplayTime,
            this.Icon});
            this.gridView1.GridControl = this.AlertsGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Message
            // 
            this.Message.Caption = "Wiadomość";
            this.Message.FieldName = "Message";
            this.Message.Name = "Message";
            this.Message.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Message.Visible = true;
            this.Message.VisibleIndex = 4;
            this.Message.Width = 276;
            // 
            // Favorite
            // 
            this.Favorite.Caption = "Ulubione";
            this.Favorite.FieldName = "Favorite";
            this.Favorite.Name = "Favorite";
            this.Favorite.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Favorite.Visible = true;
            this.Favorite.VisibleIndex = 0;
            this.Favorite.Width = 40;
            // 
            // NeedsConfirmation
            // 
            this.NeedsConfirmation.Caption = "Wymagaj Potwierdzenia";
            this.NeedsConfirmation.FieldName = "NeedsConfirmation";
            this.NeedsConfirmation.Name = "NeedsConfirmation";
            this.NeedsConfirmation.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.NeedsConfirmation.Visible = true;
            this.NeedsConfirmation.VisibleIndex = 1;
            this.NeedsConfirmation.Width = 40;
            // 
            // DisplayTime
            // 
            this.DisplayTime.Caption = "Czas Wyświetlania [ s ]";
            this.DisplayTime.FieldName = "DisplayTime";
            this.DisplayTime.FieldNameSortGroup = "DisplayTime";
            this.DisplayTime.Name = "DisplayTime";
            this.DisplayTime.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.DisplayTime.Visible = true;
            this.DisplayTime.VisibleIndex = 2;
            this.DisplayTime.Width = 40;
            // 
            // Icon
            // 
            this.Icon.Caption = "Ikona";
            this.Icon.ColumnEdit = this.IconsComboBoxEdit;
            this.Icon.FieldName = "Icon";
            this.Icon.Name = "Icon";
            this.Icon.Visible = true;
            this.Icon.VisibleIndex = 3;
            this.Icon.Width = 80;
            // 
            // IconsComboBoxEdit
            // 
            this.IconsComboBoxEdit.AutoHeight = false;
            this.IconsComboBoxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IconsComboBoxEdit.Name = "IconsComboBoxEdit";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(422, 454);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Zapisz";
            // 
            // AlertListView
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.AlertsGrid);
            this.Controls.Add(this.SaveButton);
            this.MinimumSize = new System.Drawing.Size(500, 480);
            this.Name = "AlertListView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(500, 480);
            ((System.ComponentModel.ISupportInitialize)(this.AlertsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconsComboBoxEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl AlertsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Message;
        private DevExpress.XtraGrid.Columns.GridColumn Favorite;
        private DevExpress.XtraGrid.Columns.GridColumn NeedsConfirmation;
        private DevExpress.XtraGrid.Columns.GridColumn DisplayTime;
        private DevExpress.XtraGrid.Columns.GridColumn Icon;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox IconsComboBoxEdit;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
    }
}
