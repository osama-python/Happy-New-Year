using HappyNewYear_DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HappyNewYear_DAL.Models;
using System;

namespace HappyNewYearServices.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetailsController : Controller
    {
        HappyNewYearRepository repository;
        public DetailsController()
        {
            repository = new HappyNewYearRepository();
        }

        public JsonResult GetName(string enteredName)
        {
            Detail Name = new Detail();
            try
            {
                Name = repository.GetDetails(enteredName);
            }
            catch (Exception ex)
            {

                Name = null;
                Console.WriteLine(ex.Message);
            }
            return Json(Name);
        }

        public JsonResult AddName(string enteredName)
        {
            bool status = false;
            string message;
            try
            {
                status = repository.AddDetails(enteredName);
                if (status)
                {
                    message = "successfully Added";
                }
                else
                {
                    message = "Unsuccessful Operation!";
                }
            }
            catch (Exception ex)
            {

                message = ex.Message+ " Some error occured, try again later" ;
            }
            return Json(message);
        }

        public JsonResult RemoveName(string enteredName)
        {
            bool status = false;
            string message;
            try
            {
                status = repository.DeleteDetails(enteredName);
                if (status)
                {
                    message = "successfully deleted";
                }
                else
                {
                    message = "operation unsuccessful";
                }
            }
            catch (Exception ex)
            {

                message = ex.Message +"Some error occured, Please try again later";
            }
            return Json(message);
        }

    }
}
