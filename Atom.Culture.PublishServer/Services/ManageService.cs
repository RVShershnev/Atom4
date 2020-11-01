using Atom.Culture.App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atom.Culture.PublishServer.Services
{
    public class ManageService
    {
        public ManageService()
        {
           
        }
        public async Task<Atom.CultureShared.Person> UpdatePerson(Atom.CultureShared.Person message)
        {
            var a = message;
            return a;
        }
        public async Task<Atom.CultureShared.Person> FindPerson(string id)
        {
            // если пользователь не найден, то 
            bool IsFound = false;                        
            if (true)
            {
                IsFound = true;
                Atom.CultureShared.Person person = new Atom.CultureShared.Person();
                return person;
            }
            return null;
        }

        public async Task<IEnumerable<string>> FamousTags(string id)
        {
            List<string> tags = new List<string>();

            // если пользователь не найден, то 
            bool IsFound = false;
            if (true)
            {
                IsFound = true;
                Atom.CultureShared.Person person = new Atom.CultureShared.Person();
               
            }
            return null;
        }

        public async Task<IEnumerable<string>> GetMetro(string id)
        {
            return Metro.GetMetro;                        
        }

    }
}
