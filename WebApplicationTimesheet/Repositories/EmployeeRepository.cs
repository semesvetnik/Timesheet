using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTimesheet.Interfaces;
using WebApplicationTimesheet.Model;

namespace WebApplicationTimesheet.Repositories
{
    /// <summary>
    /// Репозиторий сотрудника.
    /// </summary>
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// Возвращает список фамилий по образцу.
        /// </summary>
        /// <param name="name">Образец.</param>
        /// <returns>Список фамилий.</returns>
        public IEnumerable<string> GetFIOList(string name)
        {
            List<string> result = new List<string>();
            string sql_query = $@"
select distinct name
from timesheet.employee
where name like @{nameof(name)} + '%'
order by asc;
";
            //using (var sqlh = new SqlConnection().)
            //{

            //}

            
            return result;
        }

    }
}
