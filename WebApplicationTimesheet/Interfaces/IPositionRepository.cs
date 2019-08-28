using System.Collections.Generic;

namespace WebApplicationTimesheet.Interfacess
{
    /// <summary>
    /// Интерфейс репозитория должности.
    /// </summary>
    public interface IPositionRepository
    {
        /// <summary>
        /// Возвращает список должностей по образцу.
        /// </summary>
        /// <param name="text">Образец.</param>
        /// <returns>Список должностей.</returns>
        IEnumerable<string> GetPositionList(string text);
    }
}