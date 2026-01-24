using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motqin.Dtos.Lesson;
using Motqin.Dtos.Subject;
using Motqin.Enums;
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
        public async Task<ActionResult<IEnumerable<SubjectReadDto>>> GetBySubjectId(string country, GradeLevel gradeLevel, EducationalStage educationalStage)
        {
            var subjects = await subjectsService.GetAllAsync(country, gradeLevel, educationalStage);
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
