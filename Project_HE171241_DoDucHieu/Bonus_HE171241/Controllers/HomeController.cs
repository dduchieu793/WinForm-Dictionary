using Microsoft.AspNetCore.Mvc;

namespace Bonus_HE171241.Controllers
{
    public class HomeController : Controller
    {
        string[] images = { "https://duhocvietglobal.com/wp-content/uploads/2018/12/dat-nuoc-va-con-nguoi-anh-quoc.jpg",
            "https://cdn2.cellphones.com.vn/x,webp,q100/media/wysiwyg/May-anh/may-anh-1.jpg", 
            "https://vuongquocanh.com/wp-content/uploads/2018/04/london.jpg" };
        static int index = 0;

        [HttpGet]
        public IActionResult Index()
        {
            string link = images[index];
            ViewBag.link = link;
            ViewBag.image = link;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string act)
        {
            Console.WriteLine(act);
            Console.WriteLine(index);
            if (act.Equals("minus"))
            {
                if (index == 0)
                {
                    index = 2;
                } else
                {
                    index--;
                }
            } else if (act.Equals("plus"))
            {
                if (index == 2)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            string link = images[index];
            ViewBag.link = link;
            ViewBag.image = link;
            return View();
        }
    }
}
