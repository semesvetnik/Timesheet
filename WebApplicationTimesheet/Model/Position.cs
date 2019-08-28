using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTimesheet.Model
{
    /// <summary>
    /// Должность.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        [Required(ErrorMessage = "Не указана должность сотрудника")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 20 символов")]
        [RegularExpression(@"[a-zA-Z""'\s-]*$", ErrorMessage = @"Должны использоваться только буквы.")]
        [Display(Name = "Должность")]
        public string Name { get; set; }
    }
}
