using EFCoreCodeFirstSample_CodeMazedotCom.Controllers;
using EFCoreCodeFirstSample_CodeMazedotCom.Models.DataManager;

namespace ApiEmployeeUnitTests
{
    public class EmployeeUnitTestController
    {
        //criar instancia do controller
        private EmployeeManager _employeeManager;
        private EmployeeController _employeeController;

        public EmployeeControllerTest()
        {
            _employeeManager = new EmployeeManager;
            _employeeController = new EmployeeController;
        }
    }
    
}
