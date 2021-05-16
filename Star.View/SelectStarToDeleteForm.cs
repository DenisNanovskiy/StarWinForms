using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Star.View
{
    /// <summary>
    /// Форма для отображения всех звезд пользователю. Ждет, когда пользователь выберет одну из них
    /// </summary>
    public partial class SelectStarToDeleteForm : Form
    {
        /// <summary>
        /// Событие, возникающее, когда пользователь выбрал из списка звезду на удаление
        /// </summary>
        public event Action<StarViewModel> StarSelected;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="allStars"></param>
        public SelectStarToDeleteForm(List<StarViewModel> allStars)
        {
            InitializeComponent();
            foreach (var star in allStars)
            {
                StarsListBox.Items.Add(star);
            }
        }

        /// <summary>
        /// Вызывается, когда пользователь нажимает на кнопку Выбрать. Здесь через событие <see cref="StarSelected"/> выбранная звезда передается родительской форме на удаление.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectStarButton_Click(object sender, EventArgs e)
        {
            StarSelected?.Invoke((StarViewModel)StarsListBox.SelectedItem);
            this.Close();
        }

        /// <summary>
        /// Вызывается, когда пользователь нажал на кнопку Отмена. Просто закрывает текущую форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
