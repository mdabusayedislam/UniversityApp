using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.BLL.RequestViewModel;
using UnversityApp.DLL.Models;
using UnversityApp.DLL.Repository;
using UnversityApp.DLL.UOW;

namespace UniversityApp.BLL.Services
{
    public interface IDepartmentService
    {
        Task<Department> InsertAsync(DepartmentInsertRequestViewModel request);
        Task<List<Department>> GetAllAsync();
        Task DeleteAsync(string departmentCode);
        Task<Department> GetAsync(string departmentCode);

    }

    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;       
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentService(IDepartmentRepository departmentRepository,IUnitOfWork unitOfWork)
        {
            _departmentRepository = departmentRepository;
            _unitOfWork = unitOfWork;   
        }
        public Task DeleteAsync(string departmentCode)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAllAsync()
        {
            return await _departmentRepository.QueryAll().ToListAsync();
        }

        public async Task<Department> GetAsync(string departmentCode)
        {
            throw new NotImplementedException();
        }

        public async Task<Department> InsertAsync(DepartmentInsertRequestViewModel request)
        {
            var department = new Department()
            {
                Name = request.Name,
                Code = request.Code
            };

           await _departmentRepository.CreateAsync(department);
           await _unitOfWork.Commit();
            return department;

        }
    }
}
