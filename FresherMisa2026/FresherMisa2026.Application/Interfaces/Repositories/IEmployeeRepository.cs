using FresherMisa2026.Entities.Employee;
using FresherMisa2026.Entities;
using System;
using System.Collections.Generic;

namespace FresherMisa2026.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<Employee> GetEmployeeByCode(string code);
        Task<IEnumerable<Employee>> GetEmployeesByDepartmentId(Guid departmentId);
        Task<IEnumerable<Employee>> GetEmployeesByPositionId(Guid positionId);

        //Filter nhân viên
        Task<PagingResponse<Employee>> GetEmployeesByFilterAsync(Guid? departmentId, Guid? positionId, decimal? salaryFrom, decimal? salaryTo, int? gender, DateTime? hireDateFrom, DateTime? hireDateTo, int pageSize, int pageIndex);


        // Kiểm tra mã nhân viên đã tồn tại hay chưa
        Task<bool> CheckCodeExistsAsync(string employeeCode, Guid? employeeId = null);
    }
}
