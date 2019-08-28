using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timesheet.Interfaces;
using Timesheet.Services;

namespace Timesheet.Controllers
{
    public class HomeController : Controller
    {
        #region Properties

        /// <summary>
        /// Сервис валидации.
        /// </summary>
        public IValidateService _validateService { get; set; }

        #endregion

        /// <summary>
        /// ИНициализация структур.
        /// </summary>
        /// <param name="validate_service">Сервис валидации.</param>
        public HomeController(IValidateService validate_service)
        {
            _validateService = validate_service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult CheckDate()
        {
            _validateService.

            return Json(true);
        }
    }
}
