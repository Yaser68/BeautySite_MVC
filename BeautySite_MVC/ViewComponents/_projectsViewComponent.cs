using BeautySite_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BeautySite_MVC.ViewComponents
{
    public class _projectsViewComponent : ViewComponent

    {

        private readonly List<Service> _services= new List<Service> {

            new Service
            { Title="عنوان 1", Image="beauty1.jpeg", Description="لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون" },

            new Service
            { Title="عنوان 2", Image="beauty2.jpeg", Description="لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون" },

            new Service
            { Title="عنوان 3", Image="beauty3.jpeg", Description="لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون" },

              new Service
            { Title="عنوان 4", Image="beauty4.jpeg", Description="لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون" },


        };


        public IViewComponentResult Invoke()
        {
            return View("_projects",_services);
        }


    }
}
