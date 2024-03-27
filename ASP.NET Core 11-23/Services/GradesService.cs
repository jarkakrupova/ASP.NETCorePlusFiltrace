using ASP.NET_Core_11_23.DTO;
using ASP.NET_Core_11_23.Models;
using ASP.NET_Core_11_23.Views.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_11_23.Services
{
    public class GradesService {
        private ApplicationDbContext dbContext;

        public GradesService(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<GradeDTO>> GetAllDtosAsync() {
            List<Grade>grades = await dbContext.Grades.Include(n => n.Student).Include(c => c.Subject).ToListAsync();
            List<GradeDTO> gradeDtos = new List<GradeDTO>();
            foreach (var grade in grades)
            {
                ModeltoDto(grade);
            }
            return gradeDtos;
        }

        public async Task<IEnumerable<GradesViewModel>> GetAllAsync()
        {
            List<Grade> grades = await dbContext.Grades.Include(n => n.Student).Include(c => c.Subject).ToListAsync();
            List<GradesViewModel> gradeVMs = new List<GradesViewModel>();
            foreach (var grade in grades)
            {
                gradeVMs.Add(ModeltoViewModel(grade));
            }
            return gradeVMs;
        }

        private GradesViewModel ModeltoViewModel(Grade grade)
        {
            return new GradesViewModel
            {
                Id = grade.Id,
                Date = grade.Date,
                Mark = grade.Mark,
                What = grade.Topic,
                StudentName = $"{grade.Student.FirstName} {grade.Student.LastName}",
                SubjectName = grade.Subject.Name
            };
        }

        private GradeDTO ModeltoDto(Grade grade)
        {
            return new GradeDTO
            {
                Id = grade.Id,
                Date = grade.Date,
                Mark = grade.Mark,
                Topic = grade.Topic,
                StudentId = grade.Student.Id,
                SubjectId = grade.Subject.Id
            };
        }

        public async Task<GradesDropdownsViewModel> GetNewGradesDropdownsValues() {
            var gradesDropdownsData = new GradesDropdownsViewModel() {
                Students = await dbContext.Students.OrderBy(n => n.LastName).ToListAsync(),
                Subjects = await dbContext.Subjects.OrderBy(x => x.Name).ToListAsync(),
            };
            return gradesDropdownsData;
        }
        public async Task CreateAsync(GradeDTO newGrade)
        {
            Grade gradeToInsert = DtoToModel(newGrade);
            if (gradeToInsert.Student != null && gradeToInsert.Subject != null)
            {
                await dbContext.Grades.AddAsync(gradeToInsert);
                await dbContext.SaveChangesAsync();
            }
        }

        private Grade DtoToModel(GradeDTO newGrade)
        {
            return new Grade()
            {
                Student = dbContext.Students.FirstOrDefault(s => s.Id == newGrade.StudentId),
                Subject = dbContext.Subjects.FirstOrDefault(sub => sub.Id == newGrade.SubjectId),
                Date = DateTime.Today,
                Topic = newGrade.Topic,
                Mark = newGrade.Mark
            };
        }

        public async Task<Grade> GetByIdAsync(int id) {
            return await dbContext.Grades.Include(n => n.Student).Include(c => c.Subject).FirstOrDefaultAsync(n => n.Id == id);
        }
        public async Task UpdateAsync(int id, GradeDTO updatedGrade) {
            var dbGrade = await GetByIdAsync(id);
            //var dbGrade = await dbContext.Grades.FirstOrDefaultAsync(n => n.Id == updatedGrade.Id);
            if (dbGrade != null) {
                dbGrade.Student = dbContext.Students.FirstOrDefault(n => n.Id == updatedGrade.StudentId);
                dbGrade.Subject = dbContext.Subjects.FirstOrDefault(x => x.Id == updatedGrade.SubjectId);
                dbGrade.Topic = updatedGrade.Topic;
                dbGrade.Mark = updatedGrade.Mark;
                dbGrade.Date = updatedGrade.Date;
                //dbGrade = DtoToModel(updatedGrade);
            }
            dbContext.Update(dbGrade);
            await dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id) {
            var gradeToDelete = await dbContext.Grades.FirstOrDefaultAsync(g => g.Id == id);
            dbContext.Grades.Remove(gradeToDelete);
            dbContext.SaveChanges();
        }

    }
}