using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.ViewComponents.ToDoListPanel
{
    public class ToDoListPanel:ViewComponent
    {
        ToDoListManager manager = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
           var values= manager.GetList();
            return View(values);
        }
    }
}
