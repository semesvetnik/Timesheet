using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTimesheet.Interfacess;

namespace WebApplicationTimesheet.Repositories
{
    /// <summary>
    /// Репозиторий должности.
    /// </summary>
    public class PositionRepository : IPositionRepository
    {
        /// <summary>
        /// Возвращает список должностей по образцу.
        /// </summary>
        /// <param name="text">Образец.</param>
        /// <returns>Список должностей.</returns>
        public IEnumerable<string> GetPositionList(string text)
        {
            List<string> result = new List<string>();
            string sql_query = $@"
select name
from timesheet.position
where name like @{nameof(text)} +'%'
order by asc;
";
            return result;
        }
    }
}
