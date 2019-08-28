using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationTimesheet.Interfaces;
using WebApplicationTimesheet.Repositories;

namespace WebApplicationTimesheet.Model.Tests
{
    /// <summary>
    /// Проверяет методы репозитория сотрудника.
    /// </summary>
    [TestClass]
    public class EmployeeRepositoryTests
    {
        /// <summary>
        /// Репозиторий сотрудника.
        /// </summary>
        public IEmployeeRepository _employeeRepository { get; set; }

        /// <summary>
        /// Инициализация структур.
        /// </summary>
        /// <param name="employee_repository"></param>
        public EmployeeRepositoryTests(EmployeeRepository employee_repository)
        {
            _employeeRepository = employee_repository;
        }


        [TestCase("Иванов")]
        [TestCase("И")]
        [TestCase("Ива")]
        public void GetFIOList_Result_NotNull()
        {

        }
    }
}
