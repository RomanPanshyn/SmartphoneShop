using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartphoneShop.Data;
using SmartphoneShop.Services;
using SmartphoneShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SmartphoneShop.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly ISmartphoneRepository _repository;

        public AppController(IMailService mailService, ISmartphoneRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send the email
                _mailService.SendMessage("romanpanshyn@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }

        public IActionResult Shop()
        {
            ViewBag.Title = "Shop";

            return View();
        }

    }
}
