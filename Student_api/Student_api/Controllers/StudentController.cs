using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_api.DomainModels;
using Student_api.Repositories;

namespace Student_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo studentRepo;
        private readonly IMapper mapper;

        public StudentController(IStudentRepo _studentRepo,IMapper _mapper)
        {
            studentRepo = _studentRepo;
            mapper = _mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllStudent()
        {
           var Students = await studentRepo.GetStudents() ;

           


            #region
            //var domStudent = new List<Students>();

            //foreach(var student in Students)
            //{
            //    domStudent.Add(new Students()
            //    {
            //        Id = student.Id,
            //        FirstName = student.FirstName,
            //        LastName = student.LastName,
            //        DateOfBirth = student.DateOfBirth,
            //        Email = student.Email,
            //        Mobile = student.Mobile,
            //        ProfileImageUrl = student.ProfileImageUrl,
            //        GenderId = student.GenderId,
            //        Gender = new Gender()
            //        {
            //            Id = student.Gender.Id,
            //            Description = student.Gender.Description
            //        }
            //        //Address = new Address()
            //        //{
            //        //    Id = student.Address.Id,
            //        //    PostalAddress = student.Address.PostalAddress,
            //        //    PhysicalAddress = student.Address.PhysicalAddress,

            //        //}




            //    });
            //}
            #endregion     

            return Ok(mapper.Map<List<Students>>(Students));
        }


    }
}
