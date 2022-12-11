using System;
using MAUIAPP2.Data.Model;

namespace MAUIAPP2.Data
{
    public class EmployeeModelService
    {
        public List<EmployeeModel> EmployeeDetails()
        {
            List<EmployeeModel> list = new List<EmployeeModel>
            {
                new EmployeeModel{Name = "Ram1", Age = 24, Address = "Kathmandu1", DoB = DateTime.Now.AddDays(1), IsMarried = false, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram2", Age = 30, Address = "Kathmandu2", DoB = DateTime.Now.AddDays(2), IsMarried = true, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram3", Age = 24, Address = "Kathmandu3", DoB = DateTime.Now.AddDays(3), IsMarried = false, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram4", Age = 25, Address = "Kathmandu4", DoB = DateTime.Now.AddDays(4), IsMarried = false, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram5", Age = 26, Address = "Kathmandu5", DoB = DateTime.Now.AddDays(5), IsMarried = true, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram6", Age = 29, Address = "Kathmandu6", DoB = DateTime.Now.AddDays(6), IsMarried = true, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram7", Age = 22, Address = "Kathmandu7", DoB = DateTime.Now.AddDays(7), IsMarried = false, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram8", Age = 28, Address = "Kathmandu8", DoB = DateTime.Now.AddDays(8), IsMarried = false, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram9", Age = 24, Address = "Kathmandu9", DoB = DateTime.Now.AddDays(9), IsMarried = false, JoinedDate = DateTime.Now.AddDays(20) },
                new EmployeeModel{Name = "Ram10", Age = 35, Address = "Kathmandu10", DoB = DateTime.Now.AddDays(10), IsMarried = true, JoinedDate = DateTime.Now.AddDays(20) },
            };


            return list;

        }
    }
}

