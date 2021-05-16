using System;
using System.Collections.Generic;
using System.Drawing;

namespace Star.Models
{
    /// <summary>
    /// Модель звезды
    /// </summary>
    public class StarModel
    {
        /// <summary>
        /// Инициализирует новый объект модели звезды
        /// </summary>
        /// <param name="largeRadius">Радиус внешних вершин</param>
        /// <param name="smallRadius">Радиус внутренних вершин</param>
        /// <param name="centerCoodinates">Координаты центра звезды</param>
        /// <param name="degree">Угол поворота звезды</param>
        /// <param name="raysNumber">Количество лучей звезды</param>
        public StarModel(double largeRadius, double smallRadius, PointF centerCoodinates, double degree, int raysNumber)
        {
            starValidator.ValidateRadius(largeRadius, smallRadius);
            starValidator.ValidateRaysNumber(raysNumber);
            LargeRadius = largeRadius;
            SmallRadius = smallRadius;
            CenterCoodinates = centerCoodinates;
            Degree = degree;
            RaysNumber = raysNumber;
            Calculate();
        }

        /// <summary>
        /// Радиус для внешних вершин
        /// </summary>
        public double LargeRadius { get; }

        /// <summary>
        /// Радиус для внутренних вершин
        /// </summary>
        public double SmallRadius { get; }

        /// <summary>
        /// Координаты центра звезды
        /// </summary>
        public PointF CenterCoodinates { get; }

        /// <summary>
        /// Угол поворота звезды (в радианах)
        /// </summary>
        public double Degree { get; }

        /// <summary>
        /// Количество лучей звезды
        /// </summary>
        public int RaysNumber { get; }

        /// <summary>
        /// Вершины звезды. Рассчитываются через метод Calculate, защищен от изменений извне
        /// </summary>
        public IReadOnlyCollection<PointF> Tops => _tops;

        /// <summary>
        /// Рассчет координат вершин звезды
        /// </summary>
        private void Calculate()
        {
            // очищаем список, чтобы заполнить его новыми вершинами при рассчете
            _tops.Clear();

            // текущий угол. Его устанавливаем в начальное положение, ниже будем его сдвигать для рассчета каждой координаты
            var currentDegree = Degree;

            var degreeStep = GetDegreeStep();

            var topsCount = GetTopsCount();

            for (int currentTopNumber = 0; currentTopNumber < topsCount; currentTopNumber++)
            {
                var radius = GetCurrentRadiusByStep(currentTopNumber);
                var currentTop = GetTopCoordinatesByParameters(CenterCoodinates, radius, currentDegree);

                _tops.Add(currentTop);
                currentDegree += degreeStep;
            }
        }

        /// <summary>
        /// Рассчет координат вершин по начальным координатам, расстоянию отдаления от них и углу
        /// </summary>
        /// <param name="center">Координаты центра</param>
        /// <param name="radius">Радиус (отдаление вершины от центра)</param>
        /// <param name="currentDegree"> Текущий угол, по которому будет</param>
        /// <returns></returns>
        private PointF GetTopCoordinatesByParameters(PointF center, double radius, double currentDegree)
        {
            var xTopPoint = center.X + radius * Math.Cos(currentDegree);
            var yTopPoint = center.Y + radius * Math.Sin(currentDegree);
            return new PointF((float)xTopPoint, (float)yTopPoint);
        }

        /// <summary>
        /// Получает радиус текущей вершины.
        /// </summary>
        /// <param name="currentTopNumber"></param>
        /// <returns>Если порядковый номер вершины четный - возвращает больший радиус, если нечетный - малый</returns>
        private double GetCurrentRadiusByStep(int currentTopNumber)
        {
            if (IsEven(currentTopNumber))
            {
                return LargeRadius;
            }
            else
            {
                return SmallRadius;
            }
        }

        /// <summary>
        /// Показывает, четное ли число.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true, если четное</returns>
        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Рассчет количества вершин для звезды. Для каждого луча 2 вершины (по одной на радиус)
        /// </summary>
        /// <returns></returns>
        private int GetTopsCount()
        {
            return RaysNumber * 2;
        }

        /// <summary>
        /// Рассчет сдвига угла
        /// </summary>
        /// <returns></returns>
        private double GetDegreeStep()
        {
            return Math.PI / RaysNumber;
        }

        /// <summary>
        /// Сюда заполняются координаты в методе Calculate. Через свойство <see cref="Tops"/> координаты доступны снаружи
        /// </summary>
        private readonly List<PointF> _tops = new List<PointF>();

        /// <summary>
        /// Валидатор данных звезды
        /// </summary>
        private readonly StarValidator starValidator = new StarValidator();

        public override string ToString()
        {
            return $"Звезда: {RaysNumber} лучей, {SmallRadius} - малый радиус, {LargeRadius} - больший радиус, центр координат: {CenterCoodinates}";
        }
    }
}
