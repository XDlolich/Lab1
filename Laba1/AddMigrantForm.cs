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

namespace Laba1
{
    public partial class AddMigrantForm : Form
    {
        Logic MigrantIDLogic;
        public Migrant NewMigrant { get; private set; }

        /// <summary>
        /// Конструктор формы добавления записи о мигранте.
        /// </summary>
        public AddMigrantForm(Logic logic)
        {
            MigrantIDLogic = logic;
            InitializeComponent();
            cmbbCountries.DataSource = MigrantIDLogic.GetCountries();
        }

        /// <summary>
        /// Событие нажатия кнопки ок в форме.
        /// </summary>
        /// <param name="sender">кнопка ок</param>
        /// <param name="e">Контейнер аргументов события.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMigrantName.Text))
            {
                MessageBox.Show("Введите имя мигранта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpBirthday.Value > dtpMigrationDate.Value)
            {
                MessageBox.Show(
                    "Дата рождения не может быть позже даты миграции!",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; 
            }

                NewMigrant = new Migrant( 
                txtMigrantName.Text,
                cmbbCountries.Text,
                txtDescription.Text,
                dtpBirthday.Value.Date,
                dtpMigrationDate.Value.Date,
                chkCriminal.Checked
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Событие нажатия кнопки "отмена" в форме.
        /// </summary>
        /// <param name="sender">кнопка "отмена"</param>
        /// <param name="e">Контейнер аргументов события.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Событие загрузки формы добавления мигранта.
        /// </summary>
        /// <param name="sender">Форма добавления мигранта.</param>
        /// <param name="e">Контейнер аргументов</param>
        private void AddMigrantForm_Load(object sender, EventArgs e)
        {

        }
    }
}
