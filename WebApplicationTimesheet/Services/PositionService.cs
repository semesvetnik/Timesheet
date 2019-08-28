using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTimesheet.Interfacess;

namespace WebApplicationTimesheet.Services
{
    /// <summary>
    /// Сервис должности.
    /// </summary>
    public class PositionService : IPositionService
    {
        #region Properties

        /// <summary>
        /// Репозиторий должности.
        /// </summary>
        public IPositionRepository _positionRepository { get; set; }

        #endregion

        /// <summary>
        /// Инициализация структур.
        /// </summary>
        /// <param name="position_repository"></param>
        public PositionService(IPositionRepository position_repository)
        {
            _positionRepository = position_repository;
        }

        /// <summary>
        /// Возвращает список должностей по образцу.
        /// </summary>
        /// <param name="text">Образец.</param>
        /// <returns>Список должностей.</returns>
        public IEnumerable<string> GetPositionList(string text)
        {
            return _positionRepository.GetPositionList(text);
        }
    }
}
