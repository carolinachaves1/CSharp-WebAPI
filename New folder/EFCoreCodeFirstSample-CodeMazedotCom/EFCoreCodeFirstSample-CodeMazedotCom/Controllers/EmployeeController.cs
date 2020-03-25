using EFCoreCodeFirstSample_CodeMazedotCom.Models;
using EFCoreCodeFirstSample_CodeMazedotCom.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample_CodeMazedotCom.Controllers
{

    [Produces("application/json")]
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _dataRepository;

        public EmployeeController(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        /// <summary>
        /// Return all employee.
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }
        /// <summary>
        /// Find employee by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 and a employee</returns>
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status404NotFound)]
        public IActionResult Get(long id)
        {
            Employee employee = _dataRepository.Get(id);

            if(employee == null)
            {
                return NotFound("The Employee record couldn't be found");
            }

            return Ok(employee);
        }

        /// <summary>
        /// Creates a employee.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Employee is null");
            }

            _dataRepository.Add(employee);
            return CreatedAtRoute(
                "Get",
                new { Id = employee.EmployeeId }, employee);
        }
        /// <summary>
        /// Update an employee
        /// </summary>
        /// //<param name="id"></param>
        /// <param name="employee"></param>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status404NotFound)]
        public IActionResult Put(long id, [FromBody] Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Employee is null");
            }

            Employee employeeToUpdate = _dataRepository.Get(id);

            if(employeeToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found");
            }

            _dataRepository.Update(employeeToUpdate, employee);

            return NoContent();
        }
        /// <summary>
        /// Deletes a specific employee.
        /// </summary>
        /// <param name="id"></param> 
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status404NotFound)]
        public IActionResult Delete(long id)
        {
            Employee employee = _dataRepository.Get(id);
            if(employee == null)
            {
                return NotFound("The Employee record couldn't be found");
            }


            _dataRepository.Delete(employee);
            return NoContent();
        }
    }
}
