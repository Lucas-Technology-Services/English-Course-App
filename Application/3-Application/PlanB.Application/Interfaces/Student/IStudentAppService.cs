using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using PlanB.Application.ViewModels.Student;

namespace PlanB.Application.Interfaces.Student
{
    public interface IStudentAppService : IDisposable
    {
        Task<IEnumerable<StudentViewModel>> GetAll();
        Task<StudentViewModel> GetById(Guid id);

        Task<ValidationResult> Register(StudentViewModel studentViewModel);
        Task<ValidationResult> Update(StudentViewModel studentViewModel);
        Task<ValidationResult> Remove(StudentViewModel studentViewModel);
         
    }
}