using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio19_2.Controllers
{
    public class ValuesController : Controller
    {
        // GET: Values
        public ActionResult Index()
        {
            var url= "https://localhost:44396/api/values";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try{
                {
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) 
                            using (StreamReader objReader = new StreamReader(strReader) ) {

                                string responseBody = objReader.ReadToEnd();

                                ViewBag.Data=responseBody;
                            }
                        }
                    
                    }
                
                }
            
            }
            catch (WebException ) { 
            }
            return View();
        }
    }
}