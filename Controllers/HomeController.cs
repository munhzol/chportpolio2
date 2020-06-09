using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioDJ2
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects() {

            List<Project> projects = new List<Project>() {
                new PortfolioDJ2.Project("Project 1","image/pro1.jpg","Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quia veritatis sit placeat voluptates earum labore doloribus doloremque assumenda, ratione nisi blanditiis, ullam temporibus voluptatibus. Saepe id rerum perferendis impedit dicta?"),
                new PortfolioDJ2.Project("Project 2","image/pro2.jpg","Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quia veritatis sit placeat voluptates earum labore doloribus doloremque assumenda, ratione nisi blanditiis, ullam temporibus voluptatibus. Saepe id rerum perferendis impedit dicta?"),
                new PortfolioDJ2.Project("Project 3","image/pro3.jpg","Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quia veritatis sit placeat voluptates earum labore doloribus doloremque assumenda, ratione nisi blanditiis, ullam temporibus voluptatibus. Saepe id rerum perferendis impedit dicta?"),
                new PortfolioDJ2.Project("Project 4","image/pro4.jpeg","Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quia veritatis sit placeat voluptates earum labore doloribus doloremque assumenda, ratione nisi blanditiis, ullam temporibus voluptatibus. Saepe id rerum perferendis impedit dicta?")
            };

            ViewBag.projects = projects;
            
            return View();
        }

        [HttpGet("contacts")]
        public ViewResult Contacts() {
            return View();
        }

    }
}
