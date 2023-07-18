using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Models
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    class User
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public string Gender { get; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime Birthday { get; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Создание пользователя.
        /// </summary>
        /// <param name="name">Имя </param>
        /// <param name="gender">Пол </param>
        /// <param name="birthday">Дата рождения </param>
        /// <param name="weight">Вес </param>
        /// <param name="height">Рост </param>
        public User (string name, string gender, DateTime birthday, double weight, double height)
        {
            #region Проверка входных данных
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть null или пустым", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(gender))
            {
                throw new ArgumentNullException("Пол не может быть null или пустым", nameof(gender));
            }
            if(birthday <=DateTime.Parse ("01.01.1920") || birthday >= DateTime.Now)
            {
                throw new ArgumentException("Неправильная дата рождения", nameof(birthday));
            }
            if (weight <= 0)
            {
                throw new ArgumentException("Вес не может быть ноль и меньше", nameof(weight));
            }
            if(height <=0)
            {
                throw new ArgumentException("Рост не может быть ноль и меньше", nameof(height));
            }
            #endregion 
            
            Name = name;
            Gender = gender;
            Birthday = birthday;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
