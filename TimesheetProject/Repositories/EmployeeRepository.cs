using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheet.Interfaces;
using Timesheet.Model;

namespace Timesheet.Repositories
{
    /// <summary>
    /// Репозиторий сотрудника.
    /// </summary>
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// Возвращает список фамилий по образцу.
        /// </summary>
        /// <param name="text">Образец.</param>
        /// <returns>Список фамилий.</returns>
        public IEnumerable<string> GetFIOList(string text)
        {
            List<string> result= new List<string>();
            //using (var sqlh = new SqlConnection().)
            //{

            //}

                return result;
        }

        /// <summary>
        /// Возвращает список должностей по образцу.
        /// </summary>
        /// <param name="text">Образец.</param>
        /// <returns>Список должностей.</returns>
        public IEnumerable<string> GetPositionList(string text)
        {
            List<string> result = new List<string>();

            return result;
        }
    }
}
