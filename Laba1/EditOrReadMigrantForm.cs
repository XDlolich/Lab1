using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laba1
{
    public partial class EditOrReadMigrantForm : Form
    {
        Logic MigrantIDLogic;
        public Migrant EditedMigrant { get; private set; }

        /// <summary>
        /// Конструктор формы редактирования или чтения
        /// </summary>
        /// <param name="migrant">Экземпляр класса мигрант</param>
        /// <param name="isReadOnly">Флаг переключения между режимом чтения и редактирования.</param>
        public EditOrReadMigrantForm(Migrant migrant, Logic logic, bool isReadOnly = false)
        {
            InitializeComponent();
            MigrantIDLogic = logic;

            cmbbCountries.DataSource = MigrantIDLogic.GetCountries();
            cmbbCountries.SelectedItem = migrant.CountryOfOrigin;
            txtMigrantName.Text = migrant.Name;
            txtDescription.Text = migrant.Description;
            dtpBirthday.Value = migrant.Birthday;
            dtpMigrationDate.Value = migrant.DayOfMigration;
            chkCriminal.Checked = migrant.HasCriminalRecord;       

            EditedMigrant = migrant;

            if (isReadOnly)
            {
                cmbbCountries.Enabled = false;
                txtMigrantName.TabStop = false;
                txtDescription.TabStop = false;
                this.ActiveControl = null;             
                txtMigrantName.ReadOnly = true;
                txtDescription.ReadOnly = true;    
                dtpBirthday.Enabled = false;
                dtpMigrationDate.Enabled = false;
                chkCriminal.Enabled = false;
                btnOk.Visible = false;
                btnCancel.Text = "Выйти";
                btnCancel.Left = (this.ClientSize.Width - btnCancel.Width) / 2;
            }
        }

        /// <summary>
        /// Событие нажатия кнопки "отмена" в форме.
        /// </summary>
        /// <param name="sender">кнопка "отмена"</param>
        /// <param name="e">Контейнер аргументов события.</param>
        private void btnCancel_click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Событие нажатия кнопки ок в форме.
        /// </summary>
        /// <param name="sender">Кнопка ок</param>
        /// <param name="e">Контейнер аргументов события.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtpBirthday.Value > dtpMigrationDate.Value)
            {
                MessageBox.Show(
                    "Дата рождения не может быть позже даты миграции!",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; 
            }

            EditedMigrant.Name = txtMigrantName.Text;
            EditedMigrant.CountryOfOrigin = cmbbCountries.Text;
            EditedMigrant.Description = txtDescription.Text;
            EditedMigrant.Birthday = dtpBirthday.Value.Date;
            EditedMigrant.DayOfMigration = dtpMigrationDate.Value.Date;
            EditedMigrant.HasCriminalRecord = chkCriminal.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        /// <param name="sender">Форма редактирования или чтения</param>
        /// <param name="e">Контейнер аргументов события.</param>
        private void EditOrReadMigrantForm_Load(object sender, EventArgs e) // эта противная штука не удаляется 
        {

        }
    }
}
