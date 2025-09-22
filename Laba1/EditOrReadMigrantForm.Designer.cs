namespace Laba1
{
    partial class EditOrReadMigrantForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMigrantName = new System.Windows.Forms.Label();
            this.txtMigrantName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblMigrationDate = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.chkCriminal = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpMigrationDate = new System.Windows.Forms.DateTimePicker();
            this.cmbbCountries = new System.Windows.Forms.ComboBox();
            this.lblOriginCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMigrantName
            // 
            this.lblMigrantName.AutoSize = true;
            this.lblMigrantName.Location = new System.Drawing.Point(121, 93);
            this.lblMigrantName.Name = "lblMigrantName";
            this.lblMigrantName.Size = new System.Drawing.Size(60, 25);
            this.lblMigrantName.TabIndex = 0;
            this.lblMigrantName.Text = "ФИО";
            // 
            // txtMigrantName
            // 
            this.txtMigrantName.Location = new System.Drawing.Point(271, 93);
            this.txtMigrantName.Name = "txtMigrantName";
            this.txtMigrantName.Size = new System.Drawing.Size(399, 29);
            this.txtMigrantName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(121, 148);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 25);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(121, 232);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(161, 25);
            this.lblBirthday.TabIndex = 3;
            this.lblBirthday.Text = "Дата рождения";
            // 
            // lblMigrationDate
            // 
            this.lblMigrationDate.AutoSize = true;
            this.lblMigrationDate.Location = new System.Drawing.Point(121, 301);
            this.lblMigrationDate.Name = "lblMigrationDate";
            this.lblMigrationDate.Size = new System.Drawing.Size(132, 25);
            this.lblMigrationDate.TabIndex = 5;
            this.lblMigrationDate.Text = "Дата въезда";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(271, 144);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(399, 66);
            this.txtDescription.TabIndex = 8;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(288, 232);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 29);
            this.dtpBirthday.TabIndex = 9;
            // 
            // chkCriminal
            // 
            this.chkCriminal.AutoSize = true;
            this.chkCriminal.Location = new System.Drawing.Point(126, 427);
            this.chkCriminal.Name = "chkCriminal";
            this.chkCriminal.Size = new System.Drawing.Size(231, 29);
            this.chkCriminal.TabIndex = 11;
            this.chkCriminal.Text = "Имеется судимость";
            this.chkCriminal.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(218, 499);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(139, 66);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Изменить запись";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 499);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 66);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_click);
            // 
            // dtpMigrationDate
            // 
            this.dtpMigrationDate.Location = new System.Drawing.Point(288, 297);
            this.dtpMigrationDate.Name = "dtpMigrationDate";
            this.dtpMigrationDate.Size = new System.Drawing.Size(200, 29);
            this.dtpMigrationDate.TabIndex = 10;
            // 
            // cmbbCountries
            // 
            this.cmbbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbCountries.FormattingEnabled = true;
            this.cmbbCountries.Location = new System.Drawing.Point(288, 359);
            this.cmbbCountries.Name = "cmbbCountries";
            this.cmbbCountries.Size = new System.Drawing.Size(193, 32);
            this.cmbbCountries.TabIndex = 17;
            // 
            // lblOriginCountry
            // 
            this.lblOriginCountry.Location = new System.Drawing.Point(121, 345);
            this.lblOriginCountry.Name = "lblOriginCountry";
            this.lblOriginCountry.Size = new System.Drawing.Size(161, 58);
            this.lblOriginCountry.TabIndex = 16;
            this.lblOriginCountry.Text = "Страна происхождения";
            this.lblOriginCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditOrReadMigrantForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(790, 658);
            this.Controls.Add(this.cmbbCountries);
            this.Controls.Add(this.lblOriginCountry);
            this.Controls.Add(this.dtpMigrationDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkCriminal);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblMigrationDate);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtMigrantName);
            this.Controls.Add(this.lblMigrantName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditOrReadMigrantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование информации о мигранте";
            this.Load += new System.EventHandler(this.EditOrReadMigrantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMigrantName;
        private System.Windows.Forms.TextBox txtMigrantName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblMigrationDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.CheckBox chkCriminal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpMigrationDate;
        private System.Windows.Forms.ComboBox cmbbCountries;
        private System.Windows.Forms.Label lblOriginCountry;
    }
}