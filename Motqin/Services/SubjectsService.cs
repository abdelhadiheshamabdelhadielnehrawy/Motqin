using Microsoft.EntityFrameworkCore;
using Motqin.Data;
using Motqin.Data.DTOs;
using Motqin.Models;

namespace Motqin.Services
{
    public class SubjectsService
    {
        private readonly AppDbContext _context;

        public SubjectsService(AppDbContext context)
        {
            _context = context;
        }

        // pagination in the future
        public async Task<List<Subject>> GetAllAsync() =>
            await _context.Subjects.AsNoTracking().ToListAsync();

        public async Task<Subject?> GetByIdAsync(int id)
        {
            return await _context.Subjects
                    .AsNoTracking()
                    .FirstOrDefaultAsync(s => s.SubjectID == id);
        }

        public async Task<Subject> CreateAsync(SubjectDTO subjectDTO)
        {
            var subject = new Subject()
            {
                Name = subjectDTO.Name
            };
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
            return subject;
        }

        public async Task<bool> UpdateAsync(Subject subject, CancellationToken ct = default)
        {
            var existing = await _context.Subjects.FindAsync(new object[] { subject.SubjectID }, ct);
            if (existing is null) return false;

            existing.Name = subject.Name;
            existing.Country = subject.Country;
            existing.EducationalStage = subject.EducationalStage;
            existing.GradeLevel = subject.GradeLevel;

            _context.Subjects.Update(existing);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken ct = default)
        {
            var existing = await _context.Subjects.FindAsync(new object[] { id }, ct);
            if (existing is null) return false;

            _context.Subjects.Remove(existing);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> ExistsAsync(int id, CancellationToken ct = default) =>
            await _context.Subjects.AnyAsync(s => s.SubjectID == id, ct);
    }
}
