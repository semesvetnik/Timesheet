using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Model
{
    /// <summary>
    /// Табель учета.
    /// </summary>
    public class Timesheet
    {
        /// <summary>
        /// Идентификатор записи табеля учета.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Дата отсутствия.
        /// </summary>
        [Required (ErrorMessage = "Не указана дата отсутствия сотрудника")]
        //[RegularExpression(@"", ErrorMessage = "Некорректная дата")]
        //[Range(DateTime.Now., DateTime.Now)]
        [Remote(action: "CheckDate", controller: "Home", ErrorMessage = "Некорректная дата")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Время отсутствия. ???
        /// </summary>
        [Required (ErrorMessage = "Не указано время отсутствия сотрудника")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Сотрудник.
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// Причина отсутствия.
        /// </summary>
        [Required (ErrorMessage = "Не указана причина отсутствия сотрудника")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 100 символов")]
        public string Reason { get; set; }
    }
}
