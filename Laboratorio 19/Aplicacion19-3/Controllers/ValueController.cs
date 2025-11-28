using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion19_3.Controllers
{
    public class ValueController : Controller
    {
        public ActionResult Index()
        {
            var url = "https://localhost:44396/item/{id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";   
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)
                            return View();

                        using (StreamReader objReader = new StreamReader(strReader)) 
                        {
                            string responseBody = objReader.ReadToEnd();

                            ViewBag.Data = responseBody;   
                        }
                    }
                }
            }
            catch (WebException )
            {
            }
            return View();
        }

    }
}