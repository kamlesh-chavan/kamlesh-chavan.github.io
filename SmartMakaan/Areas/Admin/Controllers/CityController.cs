using SmartMakaan.Areas.Admin.Models;
using SmartMakaan.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartMakaan.Areas.Admin.Controllers
{
    [Authorize]
    public class CityController : Controller
    {
        // GET: Admin/City
        public ActionResult Index(FormCollection fc, HttpPostedFileBase file)
        {
            try
            {
                using (SmartMakaanDBEntities db = new SmartMakaanDBEntities())
                {                    
                    var b = db.cities.ToList();

                    return View(b);
                }
            }
            catch (Exception)
            {
                return Content("Something went wrong");
            }
            //tbl_details tbl = new tbl_details();
            //var allowedExtensions = new[] {
            //".Jpg", ".png", ".jpg", "jpeg"
            //};
            //string Id = fc["Id"].ToString();
            //string Image_url = file.ToString(); //getting complete url  
            //string Image_Name = fc["Name"].ToString();
            //var fileName = Path.GetFileName(file.FileName); //getting only file name(ex-ganesh.jpg)  
            //var ext = Path.GetExtension(file.FileName); //getting the extension(ex-.jpg)  
            //if (allowedExtensions.Contains(ext)) //check what type of extension  
            //{
            //    string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
            //    string myfile = name + "_" + Id + ext; //appending the name with id  
            //                                           // store the file inside ~/project folder(Img)  
            //    var path = Path.Combine(Server.MapPath("~/Img"), myfile);
            //}
            //else
            //{
            //    ViewBag.message = "Please choose only Image file";
            //}
           
        }

        [HttpPost]
        public ActionResult SaveCity(City cityModel)
        {
            try
            {
                using (SmartMakaanDBEntities db = new SmartMakaanDBEntities())
                {
                    city cityTable = new city();
                    cityTable.cityName = cityModel.cityName;
                    cityTable.cityDesc = cityModel.cityDescription;
                    cityTable.cityImagePath = cityModel.cityImage;
                    cityTable.createdBy = 1;
                    cityTable.createdDate = DateTime.Now;
                    cityTable.updatedBy = 1;
                    cityTable.updatedDate = DateTime.Now;
                    cityTable.isActive = true;

                    db.cities.Add(cityTable);
                    int returnValue = db.SaveChanges();
                    return returnValue > 0 ?  Content("Data added", returnValue.ToString()) :  Content("Failed");

                }                              
            }
            catch (Exception)
            {
                return Content("Something went wrong");
            }
            
        }
    }
}