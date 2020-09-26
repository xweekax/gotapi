using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using gameofthronesassessment.Models;
using System.Data;

namespace gameofthronesassessment.Controllers
{
   // [Table("characters")]
    public class Character : Controller
    {
        public IDbConnection GetConnection()
        {
            return new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=gameofthrones;user id=newuser;password=abc123");
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetTheCharacter()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://anapioficeandfire.com");
            var response = await client.GetAsync("/api/characters/583");//this will return john snow, #583
            gotcharacter newCharacter = await response.Content.ReadAsAsync<gotcharacter>();

            return View(newCharacter);
        }
        /*
        [HttpPost]
        public async Task<IActionResult> GetTheCharacter(string name)
        {
            new namesearch() { Name=name};
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://anapioficeandfire.com");
            var response = await client.GetAsync($"/api/characters?={name}");
            //var response = await client.GetAsync("/api/characters/583");//this will return john snow, #583
            namesearch newCharacter = await response.Content.ReadAsAsync<namesearch>();

            return View(newCharacter);
        }
        */
        public IActionResult PickCharacter(string name, string gender, string culture, string born, string died, string house, string book)
        {
            gotcharacter.Create(name, gender, culture, born, died, house, book);

            return View();
        }


    }
}
