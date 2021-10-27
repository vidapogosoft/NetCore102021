using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using MVC1.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;

namespace MVC1.Controllers
{
    public class RegistradoController : Controller
    {

        string Baseurl = "http://localhost:3849/";

        public async Task<ActionResult> Index()
        {

            var ListRegistrados = new List<Registrado>();

            using (var client  = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Registrado/");

                if(Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;

                    ListRegistrados = JsonConvert.DeserializeObject<List<Registrado>>(Response);

                }

            }

            return View(ListRegistrados);
        }

        public async Task<ActionResult> Details(int IdRegistrado)
        {
            var registrados = new Registrado();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                HttpResponseMessage Res = await client.GetAsync("api/Registrado/Datos2/" + IdRegistrado);

                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    registrados = JsonConvert.DeserializeObject<Registrado>(Response);
                }
            
            }

            return View(registrados);
        }

        public async Task<ActionResult> Edit(int IdRegistrado)
        {
            var registrados = new Registrado();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                HttpResponseMessage Res = await client.GetAsync("api/Registrado/Datos2/" + IdRegistrado);

                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    registrados = JsonConvert.DeserializeObject<Registrado>(Response);
                }

            }

            return View(registrados);
        }

        [HttpPost]
        public ActionResult Edit(Registrado collection)
        {

            try
            {
                // TODO: Add update logic here
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var json = JsonConvert.SerializeObject(collection);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage Res = client.PutAsync("api/Registrado", content).GetAwaiter().GetResult();
                    if (Res.IsSuccessStatusCode)
                    {
                        var empResponse = Res.Content.ReadAsStringAsync().Result;
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Registrado/Create
        [HttpPost]
        public ActionResult Create(Registrado collection)
        {
            try
            {
                // TODO: Add insert logic here
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

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
