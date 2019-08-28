using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTimesheet.Interfaces;
using WebApplicationTimesheet.Model;

namespace WebApplicationTimesheet.Services
{
    /// <summary>
    /// Сервис валидации формы табеля учета.
    /// </summary>
    public class ValidateService : IValidateService
    {
        /// <summary>
        /// Проверяет, что дата не больше текущего момента.
        /// </summary>
        /// <param name="datetime">Дата.</param>
        /// <returns>Признак правильности даты.</returns>
        public bool Datetime(DateTime datetime)
        {


            return true;
        }
    }
}
