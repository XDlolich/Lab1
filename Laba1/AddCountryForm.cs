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
    public partial class AddCountryForm : Form
    {
        public string CountryName { get; private set; }

        /// <summary>
        /// Конструктор формы доавбления новой страны
        /// </summary>
        public AddCountryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие нажатия кнопки ок.
        /// </summary>
        /// <param name="sender">Кнопкак ок</param>
        /// <param name="e">Контейнер аргументов</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string input = txtCountryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Название не может быть пустым или состоять только из пробелов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (input.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Название не может содержать цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CountryName = input;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Событие нажатия кнопки "отмена".
        /// </summary>
        /// <param name="sender">Кнопка "отмена"</param>
        /// <param name="e">Контейнер аргументов</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Событие загрузки формы добавления новой страны.
        /// </summary>
        /// <param name="sender">Форма добавления новой страны</param>
        /// <param name="e">Контейнер аргументов</param>
        private void AddNewCountry_Load(object sender, EventArgs e)
        {

        }
    }
}
