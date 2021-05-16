using System;

namespace Star.Models
{
    public class StarValidator
    {
        /// <summary>
        /// Минимальное количество лучей для звезды
        /// </summary>
        public const int StarMinimumRaysCount = 5;

        /// <summary>
        /// Проверить радиусы звезды
        /// </summary>
        /// <param name="largeRadius"></param>
        /// <param name="smallRadius"></param>
        public void ValidateRadius(double largeRadius, double smallRadius)
        {
            if (smallRadius <= 0 || largeRadius <= 0)
            {
                throw new Exception("Радиус не может быть меньше или равен нулю");
            }
            if (largeRadius <= smallRadius)
            {
                throw new Exception($"Больший радиус не больше меньшего радиуса ({largeRadius} <= {smallRadius})");
            }
        }

        /// <summary>
        /// Проверить минимальное количество лучей звезды
        /// </summary>
        /// <param name="raysNumber"></param>
        public void ValidateRaysNumber(int raysNumber)
        {
            if (raysNumber < StarMinimumRaysCount)
            {
                throw new Exception($"Количество лучей у зыезды не может быть меньше {StarMinimumRaysCount}");
            }
        }
    }
}
