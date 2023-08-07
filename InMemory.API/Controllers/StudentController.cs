using InMemory.API.Context;
using InMemory.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InMemory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllStudent()
        {
            try
            {
                using (var context = new InMemoryContext())
                {
                    context.ChangeTracker.LazyLoadingEnabled = false;
                    var students = await context.Students.Include(s => s.Notes).AsNoTracking().ToListAsync();
                    return Ok(students);
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            try
            {
                using (var context = new InMemoryContext())
                {
                    context.ChangeTracker.LazyLoadingEnabled = false;
                    await context.Students.AddAsync(student);
                    return Ok(await context.SaveChangesAsync());
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            try
            {
                using (var context = new InMemoryContext())
                {
                    var student = await context.Students.Where(s => s.Id == id).FirstOrDefaultAsync();
                    await Task.Run(() => context.Students.Remove(student));
                    return Ok(await context.SaveChangesAsync());
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateStudent([FromBody] Student student)
        {
            try
            {
                using (var context = new InMemoryContext())
                {
                    await Task.Run(() => context.Students.Update(student));
                    return Ok(await context.SaveChangesAsync());
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
