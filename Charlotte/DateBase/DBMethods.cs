using Amazon.Runtime.Documents;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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

        public void UpdateUserPhoto(byte[] photo, string login)
        {
            var collection = database.GetCollection<User>("Users");
            User user = GetCurrentUser(login);
            user.Photo = photo;
            var filter = Builders<User>.Filter.Eq("Login", login);
            collection.ReplaceOne(filter, user);
        }

        public void GetCurrentPageAddictionalImages(int idPage, List<AddictionalImage> list)
        {
            var collection = database.GetCollection<AddictionalImage>("AddictionalImages");
            list = collection.Find(x => x.idPage == idPage).ToList();
        }

        public void GetCurrentCharacterCommentaries(int idPage, List<Commentary> list)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            list = collection.Find(x => x.idCharacter == idPage).ToList();
        }
        public void GetCurrentSuperPowerCommentaries(int idPage, List<Commentary> list)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            list = collection.Find(x => x.idSuperPower == idPage).ToList();
        }
        public void GetCurrentEpisodeCommentaries(int idPage, List<Commentary> list)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            list = collection.Find(x => x.idEpisode == idPage).ToList();
        }

        public void CreateCommentary(int idPage, Commentary commentary)
        {
            var collection = database.GetCollection<Commentary>("Commentaries");
            collection.InsertOne(commentary);
        }
        public void CreateAddictionalImage(int idPage, AddictionalImage image)
        {
            var collection = database.GetCollection<AddictionalImage>("AddictionalImages");
            collection.InsertOne(image);
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

        public void CreateNewUser(string login, string password, string email)
        {
            var collection = database.GetCollection<User>("Users");
            if (!String.IsNullOrWhiteSpace(password) &&
                !String.IsNullOrWhiteSpace(login) &&
                !String.IsNullOrWhiteSpace(email))
            {
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
                collection.InsertOne(user);
            }
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

        
        public List<Character> GetBestCharacters()
        {
            var collection = database.GetCollection<Character>("Characters");
            List<Character> _characters = collection.Find(x => x.CommentarysCount > 0).ToList();
            return _characters.Distinct().ToList();
        }
        

        /*
            public Projector SearchPrjByName(string name)
            {
                var client = new MongoClient("mongodb://localhost");
                var database = client.GetDatabase("BuildingCompany");
                var collection = database.GetCollection<Projector>("ProjectorCollection");
                return (collection.Find(x => x.Designation == name).FirstOrDefault());
            }

            public static void AddUserToDataBase(User user)
            {
                var client = new MongoClient("mongodb://localhost");
                var database = client.GetDatabase("BuildingCompany");
                var collection = database.GetCollection<User>("UserCollection");
                collection.InsertOne(user);
            }

            public async Task UploadFileToDb(IBrowserFile file, Document document, Stream stream)
            {
                var gridFS = new GridFSBucket(database);
                await gridFS.UploadFromStreamAsync(file.Name, stream);
                document.FileName = file.Name;
                document.FileExtension =  file.Name.Split('.')[^1];
                document.data = GetByteArrayFromFile(file.Name);
            }

            public byte[] GetByteArrayFromFile(string fileName)
            {
                byte[] byteArray;
                var gridFS = new GridFSBucket(database);
                try
                {
                    byteArray = gridFS.DownloadAsBytesByName(fileName);
                }
                catch
                {
                    byteArray = null;
                }
                return byteArray;
            }
        */
    }
}
