namespace Laba1
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.contextMenuMigrant = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEditMigrant = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteMigrant = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateNewMigrant = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowCriminals = new System.Windows.Forms.Button();
            this.btnSortByDurationOfStay = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNewCountry = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Instr1 = new System.Windows.Forms.Label();
            this.lbl_Instr2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfMigrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasCriminalRecordDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.migrantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuMigrant.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.migrantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuMigrant
            // 
            this.contextMenuMigrant.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuMigrant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditMigrant,
            this.menuDeleteMigrant});
            this.contextMenuMigrant.Name = "contextMenuMigrant";
            this.contextMenuMigrant.Size = new System.Drawing.Size(365, 76);
            // 
            // menuEditMigrant
            // 
            this.menuEditMigrant.BackColor = System.Drawing.SystemColors.Control;
            this.menuEditMigrant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuEditMigrant.Name = "menuEditMigrant";
            this.menuEditMigrant.Size = new System.Drawing.Size(364, 36);
            this.menuEditMigrant.Text = "Редактировать информацию";
            this.menuEditMigrant.Click += new System.EventHandler(this.MenuEditMigrant_Click);
            // 
            // menuDeleteMigrant
            // 
            this.menuDeleteMigrant.Name = "menuDeleteMigrant";
            this.menuDeleteMigrant.Size = new System.Drawing.Size(364, 36);
            this.menuDeleteMigrant.Text = "Удалить запись";
            this.menuDeleteMigrant.Click += new System.EventHandler(this.MenuDeleteMigrant_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.btnCreateNewMigrant, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGrid, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1626, 720);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // btnCreateNewMigrant
            // 
            this.btnCreateNewMigrant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateNewMigrant.Location = new System.Drawing.Point(0, 589);
            this.btnCreateNewMigrant.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnCreateNewMigrant.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnCreateNewMigrant.Name = "btnCreateNewMigrant";
            this.btnCreateNewMigrant.Size = new System.Drawing.Size(813, 128);
            this.btnCreateNewMigrant.TabIndex = 7;
            this.btnCreateNewMigrant.Text = "Добавить новую запись";
            this.btnCreateNewMigrant.UseVisualStyleBackColor = true;
            this.btnCreateNewMigrant.Click += new System.EventHandler(this.btnCreateNewMigrant_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnShowCriminals, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSortByDurationOfStay, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(816, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.167F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.36346F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.66601F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(807, 583);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnShowCriminals
            // 
            this.btnShowCriminals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowCriminals.Location = new System.Drawing.Point(3, 3);
            this.btnShowCriminals.Name = "btnShowCriminals";
            this.btnShowCriminals.Size = new System.Drawing.Size(801, 198);
            this.btnShowCriminals.TabIndex = 0;
            this.btnShowCriminals.Text = "Показать только записи с судимостями";
            this.btnShowCriminals.UseVisualStyleBackColor = true;
            this.btnShowCriminals.Click += new System.EventHandler(this.btnShowCriminals_Click);
            // 
            // btnSortByDurationOfStay
            // 
            this.btnSortByDurationOfStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortByDurationOfStay.Location = new System.Drawing.Point(3, 207);
            this.btnSortByDurationOfStay.Name = "btnSortByDurationOfStay";
            this.btnSortByDurationOfStay.Size = new System.Drawing.Size(801, 199);
            this.btnSortByDurationOfStay.TabIndex = 1;
            this.btnSortByDurationOfStay.Text = "Отфильтровать по убыванию длительности пребывания";
            this.btnSortByDurationOfStay.UseVisualStyleBackColor = true;
            this.btnSortByDurationOfStay.Click += new System.EventHandler(this.btnSortByDurationOfStay_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddNewCountry, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 412);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(801, 168);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnAddNewCountry
            // 
            this.btnAddNewCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewCountry.Location = new System.Drawing.Point(403, 3);
            this.btnAddNewCountry.Name = "btnAddNewCountry";
            this.btnAddNewCountry.Size = new System.Drawing.Size(395, 162);
            this.btnAddNewCountry.TabIndex = 3;
            this.btnAddNewCountry.Text = "Добавить новую страну в системе";
            this.btnAddNewCountry.UseVisualStyleBackColor = true;
            this.btnAddNewCountry.Click += new System.EventHandler(this.btnAddNewCountry_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(3, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(394, 162);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сбросить фильтр";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Instr1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Instr2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(816, 592);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 125);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lbl_Instr1
            // 
            this.lbl_Instr1.AutoSize = true;
            this.lbl_Instr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Instr1.Location = new System.Drawing.Point(3, 0);
            this.lbl_Instr1.Name = "lbl_Instr1";
            this.lbl_Instr1.Size = new System.Drawing.Size(801, 62);
            this.lbl_Instr1.TabIndex = 0;
            this.lbl_Instr1.Text = "Для чтения записи нажмите два раза левой кнопкой мыши.";
            // 
            // lbl_Instr2
            // 
            this.lbl_Instr2.AutoSize = true;
            this.lbl_Instr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Instr2.Location = new System.Drawing.Point(3, 62);
            this.lbl_Instr2.Name = "lbl_Instr2";
            this.lbl_Instr2.Size = new System.Drawing.Size(801, 63);
            this.lbl_Instr2.TabIndex = 1;
            this.lbl_Instr2.Text = "Для ред./уд. записи нажмити по ней правой кнопкой мыши.";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.dayOfMigrationDataGridViewTextBoxColumn,
            this.hasCriminalRecordDataGridViewCheckBoxColumn});
            this.dataGrid.DataSource = this.migrantBindingSource;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 20;
            this.dataGrid.RowTemplate.Height = 31;
            this.dataGrid.Size = new System.Drawing.Size(807, 583);
            this.dataGrid.TabIndex = 10;
            this.dataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            this.dataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_CellMouseClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 75F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.FillWeight = 50F;
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayOfMigrationDataGridViewTextBoxColumn
            // 
            this.dayOfMigrationDataGridViewTextBoxColumn.DataPropertyName = "DayOfMigration";
            this.dayOfMigrationDataGridViewTextBoxColumn.FillWeight = 53.01205F;
            this.dayOfMigrationDataGridViewTextBoxColumn.HeaderText = "Дата миграции";
            this.dayOfMigrationDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.dayOfMigrationDataGridViewTextBoxColumn.Name = "dayOfMigrationDataGridViewTextBoxColumn";
            this.dayOfMigrationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasCriminalRecordDataGridViewCheckBoxColumn
            // 
            this.hasCriminalRecordDataGridViewCheckBoxColumn.DataPropertyName = "HasCriminalRecord";
            this.hasCriminalRecordDataGridViewCheckBoxColumn.FillWeight = 40F;
            this.hasCriminalRecordDataGridViewCheckBoxColumn.HeaderText = "Судимость";
            this.hasCriminalRecordDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.hasCriminalRecordDataGridViewCheckBoxColumn.Name = "hasCriminalRecordDataGridViewCheckBoxColumn";
            this.hasCriminalRecordDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // migrantBindingSource
            // 
            this.migrantBindingSource.DataSource = typeof(Model.Migrant);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 720);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "MainMenu";
            this.Text = "MigrantID System";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.contextMenuMigrant.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.migrantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuMigrant;
        private System.Windows.Forms.ToolStripMenuItem menuEditMigrant;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteMigrant;
        private System.Windows.Forms.BindingSource migrantBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnCreateNewMigrant;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnShowCriminals;
        private System.Windows.Forms.Button btnSortByDurationOfStay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Instr1;
        private System.Windows.Forms.Label lbl_Instr2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfMigrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasCriminalRecordDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAddNewCountry;
        private System.Windows.Forms.Button btnReset;
    }
}

