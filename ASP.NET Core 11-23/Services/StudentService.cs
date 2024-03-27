using ASP.NET_Core_11_23.DTO;
using ASP.NET_Core_11_23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_11_23.Services {
    public class StudentService {
        public ApplicationDbContext _dbContext;
        public StudentService(ApplicationDbContext dbContext) {
            this._dbContext = dbContext;
        }
        public async Task<IEnumerable<StudentDTO>> GetAllAsync() {
            //var allStudents = await _dbContext.Students.ToListAsync();
            var allStudents = await _dbContext.Students.ToListAsync();
            var studentDtos = new List<StudentDTO>();
            foreach (var item in allStudents)
            {
                studentDtos.Add(modelToDto(item));
            }
            return studentDtos;
        }
        //transformační třída
        private StudentDTO modelToDto(Student item)
        {
            return new StudentDTO()
            {
                Id = item.Id,
                DateOfBirth = item.DateOfBirth,
                FirstName = item.FirstName,
                LastName = item.LastName
            };
        }

        private Student DtoToModel(StudentDTO item)
        {
            return new Student()
            {
                Id = item.Id,
                DateOfBirth = item.DateOfBirth,
                FirstName = item.FirstName,
                LastName = item.LastName
            };
        }

        public async Task CreateAsync(StudentDTO newStudent) {
            await _dbContext.Students.AddAsync(DtoToModel(newStudent));
            await _dbContext.SaveChangesAsync();
        }
        public async Task<StudentDTO> GetByIdAsync(int id) {
            var student = await _dbContext.Students.FirstOrDefaultAsync(n => n.Id == id);
            return modelToDto(student);
        }
        public async Task<StudentDTO> UpdateAsync(int id, StudentDTO updatedStudent)
        {
            _dbContext.Update(DtoToModel(updatedStudent));
            await _dbContext.SaveChangesAsync();
            return updatedStudent;
        }
        internal async Task DeleteAsync(int id) {
            var studentToDelete = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            _dbContext.Students.Remove(studentToDelete);
            await _dbContext.SaveChangesAsync();
        }

    }
}
