using Star.Models;
using System.Drawing;
using System.Linq;

namespace Star.View
{
    /// <summary>
    /// Отображаемая модель звезды
    /// </summary>
    public class StarViewModel
    {
        /// <summary>
        /// Конструктор отображаемой модели звезды
        /// </summary>
        /// <param name="starModel">Сама модель звезды</param>
        /// <param name="color">Цвет, которым ее нужно отобразить</param>
        public StarViewModel(StarModel starModel, Color color)
        {
            StarModel = starModel;
            Color = color;
        }

        /// <summary>
        /// Модель звезды
        /// </summary>
        public StarModel StarModel { get; }

        /// <summary>
        /// Цвет звезды
        /// </summary>
        public Color Color { get;  }

        /// <summary>
        /// Метод для рисования звезды на графике. Рисует все линии по точкам, а затем соединяет первую и последнюю тоже линией. Получается звезда.
        /// </summary>
        /// <param name="graphics"></param>
        public void Draw(Graphics graphics)
        {
            graphics.DrawLines(new Pen(Color), StarModel.Tops.ToArray());
            graphics.DrawLines(new Pen(Color), new[] { StarModel.Tops.First(), StarModel.Tops.Last() });
        }

        public override string ToString()
        {
            return $"{StarModel}, {Color}";
        }
    }
}
