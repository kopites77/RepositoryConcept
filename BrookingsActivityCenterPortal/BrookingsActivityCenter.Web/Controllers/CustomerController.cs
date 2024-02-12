using BrookingsActivityCenter.Web.Implementation;
using BrookingsActivityCenter.Web.Models;
using BrookingsActivityCenter.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BrookingsActivityCenter.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork  unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Add()
        {
             return View();
        }

        [HttpPost]
        public IActionResult Add(AddCustomerViewModel model)
        {
            var customer = new Customer
            {
                CustomerName = model.CustomerName,
                CustomerEmail = model.CustomerEmail,
                CustomerPhone = model.CustomerPhone,
                Address = model.Address,
            };
            
            
            _unitOfWork.CustomerRepository.Add(customer);
            _unitOfWork.Save();
            
            return View();
        }


    }
}
