using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP_Lab7
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _age;

        public static readonly int maxPeopleAge = 122;

        /// <summary>
        /// Уникальный идентификатор пользователя.
        /// </summary>
        /// <value>Уникальный идентификатор пользователя.</value>
        public int Id
        {
            get => _id;
            init => _id = value;
        }

        /// <summary>
        /// Свойство для доступа к имени пользователя. Имя не должно быть пустой или null строкой.
        /// При установке значения, свойство удаляет начальные и конечные пробелы из имени.
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            init => _firstName = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentException("Имя не должно быть пустой или равной null строкой.");
        }

        /// <summary>
        /// Свойство для доступа к фамилии пользователя. Фамилия не должна быть пустой или null строкой.
        /// При установке значения, свойство удаляет начальные и конечные пробелы из фамилии.
        /// </summary>
        public string LastName
        {
            get => _lastName;
            init => _lastName = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentException("Фамилия не должна быть пустой или равной null строкой.");
        }

        /// <summary>
        /// Свойство возраста пользователя.
        /// Позволяет получить и установить возраст пользователя.
        /// Возраст должен быть больше 0 и меньше или равен 122.
        /// </summary>
        public int Age
        {
            get => _age;
            set => _age = value > 0 && value <= maxPeopleAge ? value : throw new ArgumentOutOfRangeException("Значение возраста должно быть больше 0 и меньше или равно 122.");
        }

        /// <summary>
        /// Конструктор класса пользователь.
        /// </summary>
        /// <param name="id">Уникальный идентификатор пользователя.</param>
        /// <param name="firstName">Имя пользователя. Должно быть не пустым.</param>
        /// <param name="lastName">Фамилия пользователя. Должно быть не пустым.</param>
        /// <param name="age">Возраст пользователя. Должен быть больше 0 и меньше 123.</param>
        /// <param name="dateCreationUser">Дата создания пользователя.</param>
        public User(int id, string firstName, string lastName, int age)
        {
            Id = id; 
            FirstName = firstName; 
            LastName = lastName; 
            Age = age; 
        }

        /// <summary>
        /// Переопределение метода сравнения классов пользователей.
        /// Сравнивает текущий экземпляр с указанным объектом и возвращает true, если объекты равны, иначе возвращает false.
        /// Два объекта считаются равными, если они являются экземплярами класса User и все их свойства совпадают, включая Id, FirstName, LastName и Age.
        /// </summary>
        /// <param name="obj">Объект, с которым сравнивается текущий экземпляр.</param>
        /// <returns>True, если объекты равны, иначе False.</returns>
        public override bool Equals(object? obj)
        {
            return obj is not null
                    && obj is User user
                    && user.Id == Id
                    && user.FirstName == FirstName
                    && user.LastName == LastName
                    && user.Age == Age;
        }

        /// <summary>
        /// Переопределение метода ToString для форматированного вывода информации о пользователе.
        /// </summary>
        /// <returns>Строка, представляющая объект класса User в удобочитаемом формате.</returns>
        public override string ToString()
        {
            return $"Id: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\nAge: {Age}";
        }
    }
}
