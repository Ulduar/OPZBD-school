using System;

namespace School_1
{

    /// <summary>
    /// �����.
    /// </summary>
    public class Classroom
    {

        /// <param ClassName="className"> ����� ������. </param>

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
        /// �������������
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// ����� ������.
        /// </summary>
        public string ClassName { get; }

    }
}