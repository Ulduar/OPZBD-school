using System;

namespace School_1
{

    /// <summary>
    /// �������� ������������.
    /// </summary>
    public class Teacher
    {

        /// <param FirstName="firstName"> ��� ��������� ������������. </param>
        /// <param LastName="lastName"> ������� ��������� ������������. </param>
        /// <param MiddleName="middleName"> �������� ��������� ������������. </param>

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
        /// �������������
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// ��� ��������� ������������.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// ������� ��������� ������������.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// �������� ��������� ������������.
        /// </summary>
        public string MiddleName { get; }
    }
}