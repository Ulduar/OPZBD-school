using System;

namespace School_1
{

    /// <summary>
    /// Классный руководитель.
    /// </summary>
    public class Teacher
    {

        /// <param FirstName="firstName"> Имя классного руководителя. </param>
        /// <param LastName="lastName"> Фамилия классного руководителя. </param>
        /// <param MiddleName="middleName"> Отчество классного руководителя. </param>

        public Teacher(string lastName, string firstName,
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
        /// Имя классного руководителя.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Фамилия классного руководителя.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Отчество классного руководителя.
        /// </summary>
        public string MiddleName { get; }
    }
}