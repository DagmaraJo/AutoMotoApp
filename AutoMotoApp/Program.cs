using AutoMotoApp.Entities;
using AutoMotoApp.Repositories;


var employeeRepository = new GenericRepository<Employee, int>();
employeeRepository.Add(new Employee { FirstName = "Adam" });
employeeRepository.Add(new Employee { FirstName = "Piotr" });
employeeRepository.Add(new Employee { FirstName = "Zuzia" });
employeeRepository.Save();
