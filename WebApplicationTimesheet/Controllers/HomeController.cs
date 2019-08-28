using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTimesheet.Interfaces;
using WebApplicationTimesheet.Services;
using WebApplicationTimesheet.Interfacess;
using WebApplicationTimesheet.Model;

namespace WebApplicationTimesheet.Controllers
{
    public class HomeController : Controller
    {
        #region Properties

        /// <summary>
        /// Сервис валидации.
        /// </summary>
        public IValidateService _validateService { get; set; }

        /// <summary>
        /// Сервис ФИО.
        /// </summary>
        public IEployeeService _fioService { get; set; }

        /// <summary>
        /// Сервис должности.
        /// </summary>
        public IPositionService _positionService { get; set; }

        /// <summary>
        /// Сервис табеля учета.
        /// </summary>
        public ITimesheetService _timesheetService { get; set; }

        #endregion

        /// <summary>
        /// Инициализация структур.
        /// </summary>
        /// <param name="validate_service">Сервис валидации.</param>
        public HomeController(IValidateService validate_service, IEployeeService fio_service,
            IPositionService position_service, ITimesheetService timesheet_service)
        {
            _validateService = validate_service;
            _fioService = fio_service;
            _positionService = position_service;
            _timesheetService = timesheet_service;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Автокомплит ФИО по образцу.
        /// </summary>
        /// <param name="name">Образец.</param>
        /// <returns>Список ФИО.</returns>
        [HttpPost]
        public JsonResult GetFIO(string name)
        {
            var result = _fioService.GetFIOList(name).ToList();

            return new JsonResult(result);
        }

        /// <summary>
        /// Автокомплит должности по образцу.
        /// </summary>
        /// <param name="name">Образец.</param>
        /// <returns>Список должностей.</returns>
        [HttpGet]
        public JsonResult GetPosition(string name)
        {
            var result = _positionService.GetPositionList(name).ToList();

            return new JsonResult(result);
        }

        /// <summary>
        /// Сохранение записи в табеле учета.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Save(Timesheet timesheet)
        {
            _timesheetService.Save(timesheet);

            return new JsonResult(true);
        }

        /// <summary>
        /// Проверяет корректность даты.
        /// </summary>
        /// <returns></returns>
        public IActionResult CheckDate()
        {
           // _validateService.

            return Json(true);
        }
    }
}
