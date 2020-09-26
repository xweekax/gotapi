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

namespace gameofthronesassessment.Models
{
    public class gotcharacter
    {
        public int CharacterID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Culture { get; set; }
        public string Born { get; set; }
        public string Died { get; set; }
       // public Titles[] title { get; set; }
      //  public Alias[] Alias {get; set;}
        public string House { get; set; }
        public string Allegiance { get; set; }
        public string Book { get; set; }
      //  public namesearch[] name { get; set; }
        
        public static void Create(string name, string gender, string culture, string born, string died, string house, string book)
        {
            gotcharacter picked = new gotcharacter() { Name = name, Gender = gender, Culture= culture, Born = born, Died=died, House=house, Book=book};
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=gameofthrones;user id=newuser;password=abc123;");
            db.Insert(picked);
        } 
    }

}

