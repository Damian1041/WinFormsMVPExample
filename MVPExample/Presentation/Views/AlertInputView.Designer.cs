namespace Presentation.Views
{
    partial class AlertInputView
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
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkButton = new DevExpress.XtraEditors.SimpleButton();
            this.ConfirmationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.InputTitleLablel = new DevExpress.XtraEditors.LabelControl();
            this.AlertLookup = new DevExpress.XtraEditors.LookUpEdit();
            this.IconComboBox = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmationCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertLookup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(361, 134);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Anuluj";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(280, 134);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 18;
            this.OkButton.Text = "Ok";
            // 
            // ConfirmationCheckEdit
            // 
            this.ConfirmationCheckEdit.Location = new System.Drawing.Point(12, 89);
            this.ConfirmationCheckEdit.Name = "ConfirmationCheckEdit";
            this.ConfirmationCheckEdit.Properties.Caption = "Wymagaj potwierdzenia";
            this.ConfirmationCheckEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfirmationCheckEdit.Size = new System.Drawing.Size(141, 19);
            this.ConfirmationCheckEdit.TabIndex = 17;
            // 
            // InputTitleLablel
            // 
            this.InputTitleLablel.Location = new System.Drawing.Point(12, 44);
            this.InputTitleLablel.Name = "InputTitleLablel";
            this.InputTitleLablel.Size = new System.Drawing.Size(106, 13);
            this.InputTitleLablel.TabIndex = 15;
            this.InputTitleLablel.Text = "Wprowadź komunikat:";
            // 
            // AlertLookup
            // 
            this.AlertLookup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlertLookup.EditValue = "";
            this.AlertLookup.Location = new System.Drawing.Point(12, 63);
            this.AlertLookup.Name = "AlertLookup";
            this.AlertLookup.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.AlertLookup.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.AlertLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AlertLookup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Message", "Wiadomość", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.AlertLookup.Properties.DisplayMember = "Message";
            this.AlertLookup.Properties.NullText = "";
            this.AlertLookup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.AlertLookup.Properties.ValueMember = "Message";
            this.AlertLookup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AlertLookup.Size = new System.Drawing.Size(424, 20);
            this.AlertLookup.TabIndex = 22;
            // 
            // IconComboBox
            // 
            this.IconComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconComboBox.Location = new System.Drawing.Point(280, 88);
            this.IconComboBox.Name = "IconComboBox";
            this.IconComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IconComboBox.Properties.NullText = "Check";
            this.IconComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IconComboBox.Size = new System.Drawing.Size(156, 20);
            this.IconComboBox.TabIndex = 23;
            // 
            // AlertInputView
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.IconComboBox);
            this.Controls.Add(this.AlertLookup);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ConfirmationCheckEdit);
            this.Controls.Add(this.InputTitleLablel);
            this.Name = "AlertInputView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(445, 359);
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmationCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertLookup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconComboBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton OkButton;
        private DevExpress.XtraEditors.CheckEdit ConfirmationCheckEdit;
        private DevExpress.XtraEditors.LabelControl InputTitleLablel;
        private DevExpress.XtraEditors.LookUpEdit AlertLookup;
        private DevExpress.XtraEditors.ImageComboBoxEdit IconComboBox;
    }
}
