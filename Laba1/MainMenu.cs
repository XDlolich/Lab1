using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Laba1
{
    public partial class MainMenu : Form
    {
        Logic MigrantIDLogic = new Logic();
        Button[] filterButtons;

        /// <summary>
        /// Конструктор формы "главное меню".
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            RefreshList();
            filterButtons = new Button[] { btnShowCriminals, btnSortByDurationOfStay, btnReset };
        }

        /// <summary>
        /// Обновление отображаемого в меню списка.
        /// </summary>
        /// <param name="migrants">Коллекция объектов мигрант (по умолчанию выводится вся, при передаче измененной коллекции будет выведена соответствующая</param>
        private void RefreshList(IEnumerable<Migrant> migrants = null)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = migrants ?? MigrantIDLogic.GetMigrantList();
        }

        /// <summary>
        /// Событие клика по ячейке таблицы.
        /// </summary>
        /// <param name="sender">Ячейка таблицы</param>
        /// <param name="e">Контейнер аргументов</param>
        private void dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGrid.ClearSelection();
                dataGrid.Rows[e.RowIndex].Selected = true;

                contextMenuMigrant.Show(Cursor.Position);
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку "редактировать"
        /// </summary>
        /// <param name="sender">Кнопка редактирвоать</param>
        /// <param name="e">Контейнер аргументов события</param>
        private void MenuEditMigrant_Click(object sender, EventArgs e)
        {
            var migrant = GetSelectedMigrant();
            if (migrant != null)
            {
                using (var form = new EditOrReadMigrantForm(migrant, MigrantIDLogic))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        MigrantIDLogic.EditMigrant(form.EditedMigrant);
                        RefreshList();
                    }
                }
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку "удалить"
        /// </summary>
        /// <param name="sender">Кнопка удалить</param>
        /// <param name="e">Контейнер аргументов события</param>
        private void MenuDeleteMigrant_Click(object sender, EventArgs e)
        {
            var migrant = GetSelectedMigrant();
            if (migrant != null)
            {
                var result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить {migrant.Name}?",
                    "Удаление записи о мигранте", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MigrantIDLogic.DeleteMigrant(migrant.Id);
                    RefreshList();
                }
            }
        }

        /// <summary>
        /// Событие даблклика по записи в таблице.
        /// </summary>
        /// <param name="sender">Листбокс</param>
        /// <param name="e">Контейцнер аргусментов события</param>
        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var migrant = dataGrid.Rows[e.RowIndex].DataBoundItem as Migrant;
                if (migrant != null)
                {
                    using (var form = new EditOrReadMigrantForm(migrant, MigrantIDLogic, true))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            MigrantIDLogic.EditMigrant(form.EditedMigrant);
                            RefreshList();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку фильтра.
        /// </summary>
        /// <param name="sender">Кнопка фильтра</param>
        /// <param name="e">Контейнер аргументов</param>
        private void FilterButton_Click(object sender, EventArgs e) // постоянно удаляется из файла дезигнера
        {
            Button clicked = sender as Button;

            foreach (var btn in filterButtons)
            {
                btn.BackColor = SystemColors.Control;
            }

            clicked.BackColor = Color.LightBlue;
        }

        /// <summary>
        /// Событие нажатия кнопки создать новую запись.
        /// </summary>
        /// <param name="sender">Кнопка "Создать новую запись"</param>
        /// <param name="e">Контейнер аргументов</param>
        private void btnCreateNewMigrant_Click(object sender, EventArgs e)
        {
            using (var form = new AddMigrantForm(MigrantIDLogic))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MigrantIDLogic.AddNewMigrant(
                        form.NewMigrant.Name,
                        form.NewMigrant.CountryOfOrigin,
                        form.NewMigrant.Description,
                        form.NewMigrant.Birthday,
                        form.NewMigrant.DayOfMigration,
                        form.NewMigrant.HasCriminalRecord
                    );

                    RefreshList(); 
                }
            }
        }

        /// <summary>
        /// Событие нажатия кнопки сортировки по времени пребываания.
        /// </summary>
        /// <param name="sender">Кнопка "сортировать по времени пербывания"</param>
        /// <param name="e">Контейнер аргументов</param>
        private void btnSortByDurationOfStay_Click(object sender, EventArgs e)
        {
            var sortedMigrantList = MigrantIDLogic.GetMigrantsByDurationOfStay();
            RefreshList(sortedMigrantList);
        }

        /// <summary>
        /// Событие нажатия на кнопку "Сбросить фильтр".
        /// </summary>
        /// <param name="sender">Кнопка сбросить фильтр</param>
        /// <param name="e">Контейнер аргументов события</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var btn in filterButtons)
            {
                btn.BackColor = SystemColors.Control;
            }
            RefreshList();          
        }

        /// <summary>
        /// Событие нажатия на кнопку "Показать только записи с судимостями".
        /// </summary>
        /// <param name="sender">Кнопка "показать записи с судимостями"</param>
        /// <param name="e">Контейнер аргументов события</param>
        private void btnShowCriminals_Click(object sender, EventArgs e)
        {
            var criminals = MigrantIDLogic.GetMigrantsWithCriminalRecord();
            RefreshList(criminals);
        }

        /// <summary>
        /// Метод, возвращающий объект мигрант соотв. выбранной записи в таблице.
        /// </summary>
        /// <returns>Объект класса Migrant</returns>
        private Migrant GetSelectedMigrant()
        {
            if (dataGrid.SelectedRows.Count > 0)
                return dataGrid.SelectedRows[0].DataBoundItem as Migrant;
            return null;
        }

        /// <summary>
        /// Событие изменения размеров главного меню
        /// </summary>
        /// <param name="sender">Глваное меню</param>
        /// <param name="e">Контейнер аргументов события</param>
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            float scaleFactor = (float)this.ClientSize.Width / 800f;
            btnCreateNewMigrant.Font = new Font("Segoe UI", 8f * scaleFactor, FontStyle.Regular);
            dataGrid.Font = new Font("Segoe UI", 9f * scaleFactor, FontStyle.Regular);
            btnShowCriminals.Font = new Font("Segoe UI", 8f * scaleFactor, FontStyle.Regular);
            btnSortByDurationOfStay.Font = new Font("Segoe UI", 8f * scaleFactor, FontStyle.Regular);
            btnReset.Font = new Font("Segoe UI", 8f * scaleFactor, FontStyle.Regular);
            lbl_Instr1.Font = new Font("Segoe UI", 8f * scaleFactor, FontStyle.Regular);
            lbl_Instr2.Font = new Font("Segoe UI", 8f * scaleFactor, FontStyle.Regular);
        }

        /// <summary>
        /// Событие нажатия кнопки добавления новой страны.
        /// </summary>
        /// <param name="sender">Кнопка "добавить страну"</param>
        /// <param name="e">Контейнер аргументов</param>
        private void btnAddNewCountry_Click(object sender, EventArgs e)
        {
            using (var form = new AddCountryForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string newCountry = form.CountryName;

                    if (!MigrantIDLogic.GetCountries().Contains(newCountry))
                    {
                        MigrantIDLogic.AddNewCountry(newCountry);
                    }
                    else
                    {
                        MessageBox.Show("Такая страна уже существует.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        /// <summary>
        /// Событие загрузки формы главного меню.
        /// </summary>
        /// <param name="sender">Главное меню</param>
        /// <param name="e">Контейнер аргументов</param>
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
