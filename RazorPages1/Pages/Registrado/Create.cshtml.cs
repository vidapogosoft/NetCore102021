using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace RazorPages1.Pages.Registrado
{
    public class CreateModel : PageModel
    {
        string Baseurl = "http://localhost:3849/";

        [BindProperty]
        public Models.Registrado collection { get; set; }

       
        public void OnGet()
        {
        }

        public IActionResult OnPostAsync()
        {
            try
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var json = JsonConvert.SerializeObject(collection);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage Res = client.PostAsync("api/Registrado", content).GetAwaiter().GetResult();
                    if (Res.IsSuccessStatusCode)
                    {
                        var empResponse = Res.Content.ReadAsStringAsync().Result;
                    }
                }


                //return this.StatusCode(200);

                return RedirectToPage("/Registrado/Index");

            }
            catch
            {

                return Page();
              
            }
        }
    }
}
