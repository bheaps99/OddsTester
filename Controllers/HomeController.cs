using First12.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using First12.DB;
using System.Globalization;
using System.Text;

namespace First9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment Environment;
        static _context stocks = new _context();

        public HomeController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(List<IFormFile> postedFiles, string CDate)
        {
            string[] formats = { "MM/dd/yyyy" };
            DateTime date;
            try
            {
                date = DateTime.ParseExact(CDate, formats, new CultureInfo("en-US"), DateTimeStyles.None);
            }
            catch(Exception e)
            {
                ViewBag.Message = "invalid date";
                return View();
            }
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if(System.IO.File.Exists(Path.Combine(path, "Compare.csv")))
            {
                System.IO.File.Delete(Path.Combine(path, "Compare.csv"));
            }
            string fileName = "";
            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in postedFiles)
            {
                fileName = Path.GetFileName(postedFile.FileName);
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                }
            }

            using (StreamReader reader = new StreamReader(Path.Combine(path, fileName)))
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(path, "Compare.csv")))
                {
                    string headerLine = reader.ReadLine();
                    string[] headerLineSplits = headerLine.Split(",");
                    int oddsIndex=99;
                    for(int i=0; i<headerLineSplits.Length;i++)
                    {
                        if(headerLineSplits[i].ToUpper()=="ODDS") { oddsIndex = i; break; }
                    }
                    writer.WriteLine(headerLine + ",Close-Open, MFE, MAE");
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] lineSplit = line.Split(",");
                        string symbol = line.Split(',')[0];
                        StringBuilder linee = new StringBuilder();
                        linee.Append(line).Append(",");

                        try
                        {
                            decimal? open = stocks.MasterStockData.Where(x => x.Symbol == symbol).Where(x => x.Date == date).First().Open;
                            decimal? high = stocks.MasterStockData.Where(x => x.Symbol == symbol).Where(x => x.Date == date).First().High;
                            decimal? low = stocks.MasterStockData.Where(x => x.Symbol == symbol).Where(x => x.Date == date).First().Low;
                            decimal? close = stocks.MasterStockData.Where(x => x.Symbol == symbol).Where(x => x.Date == date).First().Close;

                            //close-open
                            if (close != null && open != null) linee.Append((Convert.ToDecimal(close) - Convert.ToDecimal(open)).ToString("#.##")); linee.Append(",");

                            //ODDS >=50
                            if (Convert.ToDouble(lineSplit[oddsIndex]) >= 50.0)
                            {
                                //MFE
                                if (high != null && open != null) linee.Append((Convert.ToDecimal(high) - Convert.ToDecimal(open)).ToString("#.##")); linee.Append(",");

                                //MAE
                                if (low != null && open != null) linee.Append((Convert.ToDecimal(low) - Convert.ToDecimal(open)).ToString("#.##"));
                            }

                            //ODDS <50
                            else
                            {
                                //MFE
                                if (high != null && open != null) linee.Append((Convert.ToDecimal(open) - Convert.ToDecimal(low)).ToString("#.##")); linee.Append(",");

                                //MAE
                                if (low != null && open != null) linee.Append((Convert.ToDecimal(open) - Convert.ToDecimal(high)).ToString("#.##"));
                            }
                        }
                        catch (Exception e) { }
                        writer.WriteLine(linee.ToString());
                    }
                }
            }
            ViewBag.a = "Download New File";

            if (System.IO.File.Exists(Path.Combine(path, fileName)))
            {
                System.IO.File.Delete(Path.Combine(path, fileName));
            }

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
