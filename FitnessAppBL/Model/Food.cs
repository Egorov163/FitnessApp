using System;

namespace FitnessAppBL.Model
{
    [Serializable]
    public class Food
    {
        #region Свойства
        /// <summary>
        /// Название продукта.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Белки.
        /// </summary>
        public double Proteins { get; set; }

        /// <summary>
        /// Жиры.
        /// </summary>
        public double Fats { get; set; }

        /// <summary>
        /// Углеводы.
        /// </summary>
        public double Carbohydrates { get; }

        /// <summary>
        /// Калории за 100 грамм продукта.
        /// </summary>
        public double Calories { get; }

        private double CaloriesOneGramm { get { return Calories / 100.0; } }
        private double ProteinsOneGramm { get { return Proteins / 100.0; } }
        private double FatsOneGramm { get { return Fats / 100.0; } }
        private double CarbohydratesOneGramm { get { return Carbohydrates / 100.0; } }
        #endregion 

        public Food(string name) : this(name, 0, 0, 0, 0)
        {
        }

        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            // TODO: Проверка.

            Name = name;
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
