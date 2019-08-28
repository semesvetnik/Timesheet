using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Model
{
    /// <summary>
    /// Сотрудник.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// ФИО.
        /// </summary>
        [Required (ErrorMessage = "Не указано ФИО сотрудника")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string FIO { get; set; }

        /// <summary>
        /// Должность.
        /// </summary>
        [Required (ErrorMessage = "Не указана должность сотрудника")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 20 символов")]
        public string Position { get; set; }
    }
}
