using EFCoreCodeFirstSample_CodeMazedotCom.Models;
using EFCoreCodeFirstSample_CodeMazedotCom.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample_CodeMazedotCom.Controllers
{

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
        [HttpGet("{id}", Name = "Get")]
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
        [HttpPut("{id}")]
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
