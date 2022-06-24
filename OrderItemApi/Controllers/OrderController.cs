using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderItem.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace OrderItem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetCartBy(int id)
        {

            using (HttpClient client = new HttpClient())
            {
               
                // Pass the handler to httpclient(from you are calling api)
                

                client.BaseAddress = new Uri("https://localhost:7088/api/");
                var responseTask = client.GetAsync("MenuItem");
                responseTask.Wait();
                var result = responseTask.Result;


                List<Cart> ltems = new List<Cart>();


                if (result.IsSuccessStatusCode)
                {

                    string jsonData = result.Content.ReadAsStringAsync().Result;


#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    ltems = JsonConvert.DeserializeObject<List<Cart>>(jsonData);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    Cart obj1 = ltems.SingleOrDefault(item => item.Id == id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


                    //Cart obj = new Cart();
                    obj1.MenuItemId = 1;
                    obj1.UserId = 1;


                    return Ok(obj1);

                }
                else
                {

                    return BadRequest();

                }

            };



        }




    }


}