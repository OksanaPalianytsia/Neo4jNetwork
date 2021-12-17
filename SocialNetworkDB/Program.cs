using AppDependencies;
using DAL.Concrete;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using Neo4jClient;
using Neo4j.Driver;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;
using DTO.Neo4j;

namespace SocialNetworkDB
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dependencies d = new Dependencies();
            System.Windows.Forms.Application.Run(new LogInForm(d));


            //MongoClient client = new MongoClient();
            //IMongoDatabase db = client.GetDatabase("SocialNetwork");
            //UserDAL commands = new UserDAL(db);
            //PostDAL posts = new PostDAL(db);

            //UserDTO user = new UserDTO
            //{
            //    Email = "ann",
            //    Password = "1234",
            //    FirstName = "Ann",
            //    LastName = "Snow",
            //    Interests = new List<string>() { "reading", "playing the piano" },
            //    Subscribers = new List<UserDTO>(),
            //    Friends = new List<UserDTO>(),
            //    Posts = new List<PostDTO>(),

            //};
            //commands.AddNewUser(user);

            //PostDTO post = new PostDTO
            //{
            //    PostedBy = ObjectId.Parse("61bb465c336607b23b25cc74"),
            //    Text = "Architecture news!",
            //    Comments = new List<CommentDTO>(),
            //    Likes = new List<LikeDTO>()
            //};
            //posts.AddNewPost(post);
            //commands.CreateOwnPost(ObjectId.Parse("61bb465c336607b23b25cc74"), post);

            //PostDTO post1 = new PostDTO
            //{
            //    PostedBy = ObjectId.Parse("61bb465c336607b23b25cc74"),
            //    Text = "Autodesk CFD new version released!",
            //    Comments = new List<CommentDTO>(),
            //    Likes = new List<LikeDTO>()
            //};
            //posts.AddNewPost(post1);
            //commands.CreateOwnPost(ObjectId.Parse("61bb465c336607b23b25cc74"), post1);

            //var results = commands.GetAllUsers();

            //foreach (var result in results)
            //{
            //    Console.WriteLine(value: $"{result.Id} : {result.FirstName} {result.LastName}");
            //}

            //Console.WriteLine(commands.GetAllUsers().First().FirstName);
            // Console.ReadKey();

        }
    }
}
