using System;

namespace School_1
{

    /// <summary>
    /// Ученик.
    /// </summary>
    public class Student
    {

        /// <param FirstName="firstName"> Имя ученика. </param>
        /// <param LastName="lastName"> Фамилия ученика. </param>
        /// <param MiddleName="middleName"> Отчество ученика. </param>

        public Student(string lastName, string firstName,
            string middleName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException(nameof(firstName));
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentNullException(nameof(lastName));
            }
            if (string.IsNullOrWhiteSpace(middleName))
            {
                throw new ArgumentNullException(nameof(middleName));
            }
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Имя ученика.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Фамилия ученика.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Отчество ученика.
        /// </summary>
        public string MiddleName { get; }
    }
}