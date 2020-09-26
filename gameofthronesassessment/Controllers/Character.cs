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
        [HttpPost]
        public async Task<IActionResult> GetTheCharacter(string id)
        {            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://anapioficeandfire.com");
            var response = await client.GetAsync($"/api/characters/{id}");//this will return the character based on their id
            gotcharacter newCharacter = await response.Content.ReadAsAsync<gotcharacter>();

            newCharacter.Create();

            return View(newCharacter);
        }
        
        public async Task<IActionResult> PickCharacter()
        {
            House house = await GetHouse(378);

            return View(house);
        }

        public async Task<IActionResult> FavoriteCharacter()
        {

            //get session data

            //get api data
            
            //get database list


            return View();
        }

        public async Task<House> GetHouse(int houseID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://anapioficeandfire.com");
            var response = await client.GetAsync($"/api/houses/{houseID}");//this will return the character based on their id
            House house = await response.Content.ReadAsAsync<House>();

            List<gotcharacter> characterList = new List<gotcharacter>();


            foreach (string url in house.SwornMembers)
            {
                gotcharacter character = await GetTheCharacterByurl(url);
                characterList.Add(character);
            }

            house.characters = characterList.ToArray();

            return house;

        }

        public async Task<gotcharacter> GetTheCharacterByurl(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            return await response.Content.ReadAsAsync<gotcharacter>();
        }
    }
}
