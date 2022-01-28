using BeautySite_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BeautySite_MVC.ViewComponents
{

    public class _TestimonialViewComponent : ViewComponent

    {
        private readonly List<Testimonial> testimonial = new List<Testimonial>
        {
            new Testimonial
            {
             Title="یاسر",
             Description="لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و طراحان گرافیک است، چاپگرها و",
             Image="person1.jpg"
            },

             new Testimonial
            {
             Title="سحر",
             Description="لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و طراحان گرافیک است، چاپگرها و",
             Image="person2.jpg"
            },

              new Testimonial
            {
             Title="سمیرا",
             Description="لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و طراحان گرافیک است، چاپگرها و",
             Image="person3.jpeg"
            },


        };
            


        public IViewComponentResult Invoke()
        {
            return View("_Testimonial", testimonial);
        }
    }
}
