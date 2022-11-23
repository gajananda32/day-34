namespace EmpPayroll
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee PayRoll");

            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeeModel employeeModel = new EmployeeModel();

            employeeModel.EmployeeName = "Amogh";
            employeeModel.PhoneNumber = "1234567899";
            employeeModel.Address = "12 streeet";
            employeeModel.Department = "Developer";
            employeeModel.Gender = 'M';
            employeeModel.BasicPay = 22000.00;
            employeeModel.Deductions = 1500.00;
            employeeModel.Tax = 300.00;
            employeeModel.TaxablePay = 200.00;
            employeeModel.NetPay = 30000.00;
            employeeModel.City = "Pune";
            employeeModel.Country = "India";

             employeeRepo.AddEmployee(employeeModel);

            //employeeRepo.GetAllEmployee();
        }
    }
}

