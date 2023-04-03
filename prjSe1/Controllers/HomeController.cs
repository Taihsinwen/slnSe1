
using Microsoft.AspNetCore.Mvc;
using prjSe1.Models;
using System.Diagnostics;

namespace prjSe1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Content()
        {
            return View();
        }
        public IActionResult Conclude()
        {
            return View();
        }
        public IActionResult Conclude2()
        {
            return View();
        }
        public IActionResult questionary()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Result(Ques _ques)
        {
            Ques q1 = new Ques();
           // ViewBag.name = _ques.name;

            //String line;
            //line = _ques.name;
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Test.txt",true);
                //Write a line of text
                string line = _ques.site+","+_ques.sex + "," + _ques.know + "," + _ques.image + "," + _ques.awkward + "," + _ques.advantage + "," + _ques.benefit + "," + _ques.life + "," + _ques.element;

               // sw.WriteLine(_ques.sex,",",_ques.know,",",_ques.image,",",_ques.awkward,",",_ques.advantage,",",_ques.benefit,",",_ques.life,",",_ques.element);
                sw.WriteLine(line);
                //Write a second line of text
               // sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            return View(_ques);

        }

            //public IActionResult About(Records Date1)
            //{
            //    Records m5 = new Records();
            //    m5.STTime = Date1.STTime;
            //    m5.Site = Date1.Site;
            //    m5.DayChosen = Date1.DayChosen;
            //    ViewBag.STTime = Date1.STTime;
            //    ViewBag.Site = Date1.Site;
            //    ViewBag.DayChosen = Date1.DayChosen;
            //    Date2.STTime =
            //       MockQrcodeRepository mT = new MockQrcodeRepository();

            //    _qrcodeRepository.GetById(id)

            //    QrcodeCalTime m = new QrcodeCalTime();
            //    DateTime dateTime = _records.STTime;
            //    if (Date1.DayChosen == true)
            //        _records = m.Method_CalTime(m5);
            //    else
            //        _records = m.Method_CalTime(m5);
            //    var qrcodes = _qrcodeRepository.GetAll();
            //    return View(qrcodes);
            //    return View(_records);








            //    return View();
            //}
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}