using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTimesheet.Interfaces;

namespace WebApplicationTimesheet.Services
{
    /// <summary>
    /// Сервис ФИО.
    /// </summary>
    public class EmployeeService : IEployeeService
    {
        #region Properties

        /// <summary>
        /// Репозиторий ФИО.
        /// </summary>
        public IEmployeeRepository _employeeRepository { get; set; }

        #endregion

        /// <summary>
        /// Инициализация структур.
        /// </summary>
        /// <param name="employee_repository"></param>
        public EmployeeService(IEmployeeRepository employee_repository)
        {
            _employeeRepository = employee_repository;
        }

        /// <summary>
        /// Возвращает список фамилий по образцу.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Список фамилий.</returns>
        public IEnumerable<string> GetFIOList(string name)
        {
            return _employeeRepository.GetFIOList(name);
        }
    }
}
