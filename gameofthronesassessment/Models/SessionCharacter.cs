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
    public class SessionCharacter
    {
        public List<gotcharacter> charactersList;

        public IDbConnection GetConnection()
        {
            return new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=gameofthrones;user id=newuser;password=abc123");
        }
        public SessionCharacter(string sessionID)
        {
            charactersList = GetConnection().Query<gotcharacter>($"SELECT * from gotcharacters where sessionID = '{sessionID}'").AsList();
        }

    }
}
