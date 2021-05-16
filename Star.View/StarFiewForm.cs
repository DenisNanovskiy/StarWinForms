using System.Collections.Generic;
using System.Windows.Forms;

namespace Star.View
{
    /// <summary>
    /// Форма для отображения всех звезд, вызова форм для создания новых или удаления существующих звезд
    /// </summary>
    public partial class StarViewForm : Form
    {
        /// <summary>
        /// Все звезды для отрисовки
        /// </summary>
        private readonly List<StarViewModel> stars = new List<StarViewModel>();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public StarViewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывается, когда пользователь нажал на Меню-Создать. Здесь просто создается форма для создания звезды, подписываемся на событие <see cref="StarCreatorForm.StarCreated"/> и вызываем метод для обработки новой звезды
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateStarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var starCreatorForm = new StarCreatorForm();
            starCreatorForm.StarCreated += StarCreatorForm_StarCreated;
            starCreatorForm.ShowDialog();
        }

        /// <summary>
        /// Вызывается, когда пользователь нажал на Меню-Удалить. Здесь просто создается форма для удаления звезды, подписываемся на событие <see cref="SelectStarToDeleteForm.StarSelected"/> и вызываем метод для обработки удаления звезды
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteStarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var starDeleteForm = new SelectStarToDeleteForm(stars);
            starDeleteForm.StarSelected += StarDeleteForm_StarSelected;
            starDeleteForm.ShowDialog();
        }

        /// <summary>
        /// Добавление звезды в коллекцию
        /// </summary>
        /// <param name="star"></param>
        private void StarCreatorForm_StarCreated(StarViewModel star)
        {
            stars.Add(star);
            DrawStars();
        }

        /// <summary>
        /// Удаление звезды из коллекции
        /// </summary>
        /// <param name="star"></param>
        private void StarDeleteForm_StarSelected(StarViewModel star)
        {
            stars.Remove(star);
            DrawStars();
        }

        /// <summary>
        /// Вызывает метод перерисовки формы, в следствие чего вызывается <see cref="StarViewForm_Paint"/>
        /// </summary>
        private void DrawStars()
        {
            this.Invalidate();
        }

        /// <summary>
        /// Здесь отрисовываются все звезды. Каждой звезде посылается команда на отрисовку в текущей графике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StarViewForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (var star in stars)
            {
                star.Draw(e.Graphics);
            }
        }
    }
}
