using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTimesheet.Model
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
        [RegularExpression(@"[a-zA-Z""'\s-]*$", ErrorMessage = @"Должны использоваться только буквы.")]
        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        /// <summary>
        /// Идентификатор должности.
        /// </summary>
        public int PositionId { get; set; }
    }
}
