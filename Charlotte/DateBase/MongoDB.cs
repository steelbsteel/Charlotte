using Amazon.Runtime.Documents;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charlotte.DateBase
{
        public class MongoDb
        {
            public User? currentUser;

            static MongoClient client = new MongoClient("mongodb://localhost");
            static IMongoDatabase database = client.GetDatabase("Charlotte");
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
        }
    }
}
