using Star.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Star.View
{
    /// <summary>
    /// Форма для создания звезды. Здесь заполняются данные пользователем и форма собирает из них звезду.
    /// </summary>
    public partial class StarCreatorForm : Form
    {
        /// <summary>
        /// Цвет звезды
        /// </summary>
        private Color StarColor = Color.Black;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public StarCreatorForm()
        {
            InitializeComponent();
            SetColor(StarColor);
        }

        /// <summary>
        /// Событие, возникающее, когда пользователь ввел данные и звезда была создана
        /// </summary>
        public event Action<StarViewModel> StarCreated;

        /// <summary>
        /// Возникает, когда пользователь нажимает на кнопку Выбрать цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                StarColor = colorDialog1.Color;
            }
            SetColor(StarColor);
        }

        /// <summary>
        /// Разукрашивает label выбранным цветом. Это позволяет пользователю рассмотреть цвет заранее
        /// </summary>
        /// <param name="color"></param>
        private void SetColor(Color color)
        {
            labelColor.ForeColor = color;
        }

        /// <summary>
        /// Логика по созданию звезды здесь. Здесь считываются введенные пользователем данные, преобразуются в нужный тип и отправляются в конструктор модели звезды. Готовая звезда отдается родительской форме, а исключения отлавливаются и показываются пользователю в виде понятного текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateStar_Click(object sender, EventArgs e)
        {
            try
            {
                var largeRadius = double.Parse(TextBoxLargeRadius.Text);
                var smallRadius = double.Parse(TextBoxSmallRadius.Text);
                var centerPointX = float.Parse(TextBoxCenterX.Text);
                var centerPointY = float.Parse(TextBoxCenterY.Text);
                var degree = double.Parse(TextBoxDegree.Text);
                var raysNumber = int.Parse(TextBoxRaysCount.Text);
                var star = new StarModel(largeRadius, smallRadius, new PointF(centerPointX, centerPointY), degree, raysNumber);
                var starViewModel = new StarViewModel(star, StarColor);

                this.StarCreated?.Invoke(starViewModel);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы использовали недопустимые данные для ввода. Для ввода большего радиуса, малого радиуса, центральных точек и угла допускаются числа с плавающей запятой (целая часть от дробной разделяется запятой), а для количества лучей допускаются только целые числа.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка! {ex.Message}");
            }
        }

        /// <summary>
        /// Возникает, когда пользователь нажал на кнопку Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
