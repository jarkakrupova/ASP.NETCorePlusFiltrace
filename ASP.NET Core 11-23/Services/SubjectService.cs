using ASP.NET_Core_11_23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_11_23.Services {
    public class SubjectService {
        public ApplicationDbContext _dbContext;
        public SubjectService(ApplicationDbContext dbContext) {
            this._dbContext = dbContext;
        }
        public async Task<IEnumerable<Subject>> GetAllAsync() {
            return await _dbContext.Subjects.ToListAsync();
        }
        public async Task CreateAsync(Subject newSubject) {
            await _dbContext.Subjects.AddAsync(newSubject);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<Subject> GetByIdAsync(int id) {
            return await _dbContext.Subjects.FirstOrDefaultAsync(n => n.Id == id);
        }
        public async Task<Subject> UpdateAsync(int id, Subject updatedSubject) {
            _dbContext.Update(updatedSubject);
            await _dbContext.SaveChangesAsync();
            return updatedSubject;
        }
        internal async Task DeleteAsync(int id) {
            var subjectToDelete = await _dbContext.Subjects.FirstOrDefaultAsync(x => x.Id == id);
            _dbContext.Subjects.Remove(subjectToDelete);
            await _dbContext.SaveChangesAsync();
        }

    }
}
