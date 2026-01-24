using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motqin.Dtos.Lesson;
using Motqin.Dtos.Subject;
using Motqin.Services;

namespace Motqin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SubjectsService subjectsService;

        public SubjectController(SubjectsService subjectsService)
        {
            this.subjectsService = subjectsService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectReadDto>>> GetBySubjectId(string gradeLevel, string educationalStage)
        {
            var subjects = await subjectsService.GetAllAsync(gradeLevel, educationalStage);
            return Ok(subjects.Select(s => new SubjectReadDto
            {
                SubjectID = s.SubjectID,
                Name = s.Name,
                Country = s.Country,
                EducationalStage = s.EducationalStage,
                GradeLevel = s.GradeLevel
            }));
        }
    }
}
