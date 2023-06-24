using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
    public class ProductItem : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
