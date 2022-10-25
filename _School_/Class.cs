using System;

namespace School_1
{

    /// <summary>
    /// Класс.
    /// </summary>
    public class Classroom
    {

        /// <param ClassName="className"> Номер класса. </param>

        public Classroom(string className)
        {
            if (string.IsNullOrWhiteSpace(className))
            {
                throw new ArgumentNullException(nameof(className));
            }
            
            this.Id = Guid.NewGuid();
            this.ClassName = className;
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Номер класса.
        /// </summary>
        public string ClassName { get; }

    }
}