using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STUDENTREGISTRATIONFORM.Data;
using STUDENTREGISTRATIONFORM.Models;
using STUDENTREGISTRATIONFORM.Models.Domain;

namespace STUDENTREGISTRATIONFORM.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        
        public StudentController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var students = await applicationDbContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var student = await applicationDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (student != null)
            {
                var editModel = new UpdateStudentViewModel()
                {
                    Branch = student.Branch,
                    StudentFirstName = student.StudentFirstName,
                    StudentLastName = student.StudentLastName,
                    Gender = student.Gender,
                    AdmissionCategory = student.AdmissionCategory,
                    AdmissionYear = student.AdmissionYear,
                    Class = student.Class,
                    StudentDateofBirth = student.StudentDateofBirth,
                    SecondLanguage = student.SecondLanguage,
                    ThirdLanguage = student.ThirdLanguage,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    MobileNumber = student.MobileNumber,
                    EmailID = student.EmailID,
                    Relationship = student.Relationship,
                    WouldyoulikeCampusTour = student.WouldyoulikeCampusTour,
                    Howdidyouhearaboutus = student.Howdidyouhearaboutus,
                    AdditionalInformation = student.AdditionalInformation,
                };
                return await Task.Run(() => View("updateStudentModel", editModel));
            }


            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateStudentViewModel addStudentRequest)
        {
            var student = await applicationDbContext.Students.FindAsync(addStudentRequest.Id);
            Console.WriteLine(addStudentRequest.Id);
            if (student != null)
            {
                Console.WriteLine("TESTING");
                student.Branch = addStudentRequest.Branch;
                student.StudentFirstName = addStudentRequest.StudentFirstName;
                student.StudentLastName = addStudentRequest.StudentLastName;
                student.Gender = addStudentRequest.Gender;
                student.AdmissionCategory = addStudentRequest.AdmissionCategory;
                student.AdmissionYear = addStudentRequest.AdmissionYear;
                student.Class = addStudentRequest.Class;
                student.StudentDateofBirth = addStudentRequest.StudentDateofBirth;
                student.SecondLanguage = addStudentRequest.SecondLanguage;
                student.ThirdLanguage = addStudentRequest.ThirdLanguage;
                student.FirstName = addStudentRequest.FirstName;
                student.LastName = addStudentRequest.LastName;
                student.MobileNumber = addStudentRequest.MobileNumber;
                student.EmailID = addStudentRequest.EmailID;
                student.Relationship = addStudentRequest.Relationship;
                student.WouldyoulikeCampusTour = addStudentRequest.WouldyoulikeCampusTour;
                student.Howdidyouhearaboutus = addStudentRequest.Howdidyouhearaboutus;
                student.AdditionalInformation = addStudentRequest.AdditionalInformation;

                await applicationDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel Sample)
        {
            var student = new Student()
            {
                Id = Guid.NewGuid(),
                Branch = Sample.Branch,
                StudentFirstName = Sample.StudentFirstName,
                StudentLastName = Sample.StudentLastName,
                Gender = Sample.Gender,
                AdmissionCategory = Sample.AdmissionCategory,
                AdmissionYear = Sample.AdmissionYear,
                Class = Sample.Class,
                StudentDateofBirth = Sample.StudentDateofBirth,
                SecondLanguage = Sample.SecondLanguage,
                ThirdLanguage = Sample.ThirdLanguage,
                FirstName = Sample.FirstName,
                LastName = Sample.LastName,
                MobileNumber = Sample.MobileNumber,
                EmailID = Sample.EmailID,
                Relationship = Sample.Relationship,
                WouldyoulikeCampusTour = Sample.WouldyoulikeCampusTour,
                Howdidyouhearaboutus = Sample.Howdidyouhearaboutus,
                AdditionalInformation = Sample.AdditionalInformation,
            };
            await applicationDbContext.Students.AddAsync(student);
            await applicationDbContext.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateStudentViewModel Model)
        {
            var student = await applicationDbContext.Students.FindAsync(Model.Id);
            Console.WriteLine(Model.Id);
            if (student != null)
            {
                applicationDbContext.Students.Remove(student);
                await applicationDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
