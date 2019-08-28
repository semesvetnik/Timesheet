using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationTimesheet.Interfaces;
using WebApplicationTimesheet.Repositories;

namespace WebApplicationTimesheet.Model.Tests
{
    /// <summary>
    /// ��������� ������ ����������� ����������.
    /// </summary>
    [TestClass]
    public class EmployeeRepositoryTests
    {
        /// <summary>
        /// ����������� ����������.
        /// </summary>
        public IEmployeeRepository _employeeRepository { get; set; }

        /// <summary>
        /// ������������� ��������.
        /// </summary>
        /// <param name="employee_repository"></param>
        public EmployeeRepositoryTests(EmployeeRepository employee_repository)
        {
            _employeeRepository = employee_repository;
        }


        [TestCase("������")]
        [TestCase("�")]
        [TestCase("���")]
        public void GetFIOList_Result_NotNull()
        {

        }
    }
}
