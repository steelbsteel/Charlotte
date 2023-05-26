using Amazon.Runtime.Documents;
using Charlotte.Pages;
using Microsoft.Win32;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Xml.Linq;

namespace Charlotte.DateBase
{
    public class DBMethods
    {
        //public User? currentUser;

        public static MongoClient client = new MongoClient("mongodb://localhost");
        public static IMongoDatabase database = client.GetDatabase("Charlotte");
        public User GetCurrentUser(string login)
        {
            var collection = database.GetCollection<User>("Users");
            return collection.Find(x => x.Login == login).First();
        }
        public User GetCurrentUser(int id)
        {
            var collection = database.GetCollection<User>("Users");
            return collection.Find(x => x.IdUser == id).First();
        }

        public async Task ChangePassword(string login, string password)
        {
            var collection = database.GetCollection<User>("Users");
            User user = GetCurrentUser(login);
            user.Password = password;
            var filter = Builders<User>.Filter.Eq("Login", login);
            await collection.ReplaceOneAsync(filter, user);
        }

        public async Task UpdateUserPhoto(byte[] photo, string login)
        {
            var collection = database.GetCollection<User>("Users");
            User user = GetCurrentUser(login);
            user.Photo = photo;
            var filter = Builders<User>.Filter.Eq("Login", login);
            await collection.ReplaceOneAsync(filter, user);
        }
        public int GetUserCommentaries(string login)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            User user = GetCurrentUser(login);
            List<Commentary> comments = new List<Commentary>();
            try
            {
                comments = collection.Find(x => x.idUser == user.IdUser).ToList();
            }
            catch
            {
                return 0;
            }

            return comments.Count;
        }

        public List<AddictionalImage> GetCurrentPageAddictionalImages(string idPage)
        {
            try
            {
                var collection = database.GetCollection<AddictionalImage>("AddictionalImages");
                return collection.Find(x => x.idPage == idPage).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Commentary> GetCurrentCharacterCommentaries(string idPage)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            List<Commentary> list = collection.Find(x => x.idCharacter == idPage).ToList();
            return list;
        }
        public List<Commentary> GetCurrentSuperPowerCommentaries(string idPage)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            List<Commentary> list = collection.Find(x => x.idSuperPower == idPage).ToList();
            return list;
        }
        public List<Commentary> GetCurrentEpisodeCommentaries(string idPage)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            List<Commentary> list = collection.Find(x => x.idEpisode == idPage).ToList();
            return list;
        }

        public User CheckUserSignedIn(string login, string passoword)
        {
            var collection = database.GetCollection<User>("Users");

            try
            {
                User user = collection.Find(x => x.Login == login).FirstOrDefault();

                if (user != null)
                {
                    if (user.Password == passoword)
                    {
                        return user;
                    }
                }
            }

            catch
            {
                return null;
            }

            return null;
        }

        public async Task CreateNewUser(string login, string password, string email)
        {
            var collection = database.GetCollection<User>("Users");
            User user = new User();
            User _user = new User();
            try
            {
                _user = collection.Find(x => x.IdUser >= 0).ToList().Last();
            }

            catch
            {
                user.IdUser = 0;
                user.Email = email;
                user.Password = password;
                user.Login = login;
                collection.InsertOne(user);
                return;
            }

            user.IdUser = _user.IdUser + 1;
            user.Email = email;
            user.Password = password;
            user.Login = login;
            await  collection.InsertOneAsync(user);
        }

        public bool CheckUserExists(string login)
        {
            var collection = database.GetCollection<User>("Users");

            User user = collection.Find(x => x.Login == login).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            else
                return false;
        }

        public static List<Character> RemoveCharacterDublicatesList(List<Character> items)
        {
            List<Character> result = new List<Character>();
            for (int i = 0; i < items.Count; i++)
            {
                bool duplicate = false;
                for (int z = 0; z < i; z++)
                {
                    if (items[z].IdCharacter == items[i].IdCharacter)
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }

        public static List<SuperPower> RemoveSuperPowerDublicatesList(List<SuperPower> items)
        {
            List<SuperPower> result = new List<SuperPower>();
            for (int i = 0; i < items.Count; i++)
            {
                // Assume not duplicate.
                bool duplicate = false;
                for (int z = 0; z < i; z++)
                {
                    if (items[z].IdSuperPower == items[i].IdSuperPower)
                    {
                        // This is a duplicate.
                        duplicate = true;
                        break;
                    }
                }
                // If not duplicate, add to result.
                if (!duplicate)
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }

        public static List<Episode> RemoveEpisodeDublicatesList(List<Episode> items)
        {
            List<Episode> result = new List<Episode>();
            for (int i = 0; i < items.Count; i++)
            {
                // Assume not duplicate.
                bool duplicate = false;
                for (int z = 0; z < i; z++)
                {
                    if (items[z].IdEpisode == items[i].IdEpisode)
                    {
                        // This is a duplicate.
                        duplicate = true;
                        break;
                    }
                }
                // If not duplicate, add to result.
                if (!duplicate)
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }

        public List<Character> GetBestCharacters()
        {
            try
            {
                var collection = database.GetCollection<Character>("Characters");
                var _collection = database.GetCollection<Commentary>("Commentaries");
                List<Commentary> _commentaries = _collection.Find(x => x.idCharacter[0] == 'H').ToList();
                List<Character> _bestCharacters = new List<Character>();

                foreach (Commentary comm in _commentaries)
                {
                    _bestCharacters.Add(GetCurrentCharacter(comm.idCharacter));
                }

                return RemoveCharacterDublicatesList(_bestCharacters);
            }
            catch
            {
                return new List<Character>();
            }
        }

        public List<SuperPower> GetBestSuperpowers()
        {
            try
            {
                var collection = database.GetCollection<SuperPower>("Superpowers");
                var _collection = database.GetCollection<Commentary>("Commentaries");
                List<Commentary> _commentaries = _collection.Find(x => x.idSuperPower[0] == 'S').ToList();
                List<SuperPower> _bestSuperpowers = new List<SuperPower>();
                foreach (Commentary comm in _commentaries)
                {
                    _bestSuperpowers.Add(GetCurrentSuperPower(comm.idSuperPower));
                }
                return RemoveSuperPowerDublicatesList(_bestSuperpowers);
            }
            catch
            {
                return new List<SuperPower>();
            }
        }

        public List<Episode> GetBestEpisodes()
        {
            try
            {
                var collection = database.GetCollection<Episode>("Episodes");
                var _collection = database.GetCollection<Commentary>("Commentaries");
                List<Commentary> _commentaries = _collection.Find(x => x.idEpisode[0] == 'E').ToList();
                List<Episode> _bestEpisodes = new List<Episode>();
                foreach (Commentary comm in _commentaries)
                {
                    _bestEpisodes.Add(GetCurrentEpisode(comm.idEpisode));
                }
                return RemoveEpisodeDublicatesList(_bestEpisodes);
            }
            catch
            {
                return new List<Episode>();
            }
        }

        public List<Character> GetCharacters()
        {
            try
            {
                var collection = database.GetCollection<Character>("Characters");
                List<Character> _characters = collection.Find(new BsonDocument()).ToList();
                return _characters;
            }
            catch
            {
                return new List<Character>();
            }
        }
        public List<Episode> GetEpisodes()
        {
            try
            {
                var collection = database.GetCollection<Episode>("Episodes");
                List<Episode> _episodes = collection.Find(new BsonDocument()).ToList();
                return _episodes;
            }
            catch
            {
                return new List<Episode>();
            }
        }
        public List<SuperPower> GetSuperPowers()
        {
            try
            {
                var collection = database.GetCollection<SuperPower>("Superpowers");
                List<SuperPower> _superPowers = collection.Find(new BsonDocument()).ToList();
                return _superPowers;
            }
            catch
            {
                return new List<SuperPower>();
            }
        }

        public async Task CreateCommentary(string login, string description, string idPage)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            Commentary commentary = new Commentary();
            int userId = GetCurrentUser(login).IdUser;
            int idComm;
            commentary.idUser = userId;
            commentary.Description = description;
            commentary.Date =  DateTime.Today.ToString("dd/MM/yyyy");
            commentary.Time = DateTime.Now.ToString("HH:mm");
            commentary.nameUser = GetCurrentUser(userId).Login;
            switch (idPage[0])
            {
                case 'H':
                    {
                        commentary.idCharacter = idPage;
                        break;
                    }
                case 'E':
                    {
                        commentary.idEpisode = idPage;
                        break;
                    }
                case 'S':
                    {
                        commentary.idSuperPower = idPage;
                        break;
                    }
            }
            try
            {
                idComm = collection.Find(x => x.IdCommentary >= 0).ToList().Last().IdCommentary;
            }

            catch
            {
                idComm = 0;
            }

            commentary.IdCommentary = idComm;
            await collection.InsertOneAsync(commentary);
        }

        public string GetIdPage(string name)
        {
            string idPage = "";
            switch (name[0])
            {
                case 'H':
                    {
                        var collection = database.GetCollection<Character>("Characters");
                        idPage = collection.Find(x => x.Name == name).ToList().First().IdCharacter;
                    }
                    break;
                case 'S':
                    {
                        var collection = database.GetCollection<SuperPower>("Superpowers");
                        idPage = collection.Find(x => x.Name == name).ToList().First().IdSuperPower;
                    }
                    break;
                case 'E':
                    {
                        var collection = database.GetCollection<Episode>("Episodes");
                        idPage = collection.Find(x => x.Title == name).ToList().First().IdEpisode;
                    }
                    break;
            }
            return idPage;
        }

        public Character GetCurrentCharacter(string idPage)
        {
            var collection = database.GetCollection<Character>("Characters");
            Character character = collection.Find(x => x.IdCharacter == idPage).First();
            return character;
        }

        public SuperPower GetCurrentSuperPower(string idPage)
        {
            var collection = database.GetCollection<SuperPower>("Superpowers");
            SuperPower superpower = collection.Find(x => x.IdSuperPower == idPage).First();
            return superpower;
        }
        public Episode GetCurrentEpisode(string idPage)
        {
            var collection = database.GetCollection<Episode>("Episodes");
            Episode episode = collection.Find(x => x.IdEpisode == idPage).First();
            return episode;
        }

        public string GetCharacterSuperpowers(string idHero)
        {
            try
            {
                var collection = database.GetCollection<SuperPower>("Superpowers");
                List<SuperPower> superpowers = collection.Find(x => x.idCharacter == idHero).ToList();
                string superpowersString = string.Empty;
                if (superpowers.Count > 1)
                {
                    foreach (SuperPower superpower in superpowers)
                    {
                        superpowersString += superpower.Name + ",";
                    }
                }
                else
                {
                    return superpowers[0].Name.ToString();
                }
                return superpowersString;
            }

            catch
            {
                return "Отсутствуют";
            }
        }

        public SuperPower SearchSuperPower(string Name)
        {
            var collection = database.GetCollection<SuperPower>("Superpowers");
            return collection.Find(x => x.Name == Name).First();

        }

        public string SearchIdCharacterBySuperpower(string idSuperpower)
        {
            var collection = database.GetCollection<SuperPower>("Superpowers");
            return collection.Find(x => x.IdSuperPower == idSuperpower).First().idCharacter;

        }
    }
}
