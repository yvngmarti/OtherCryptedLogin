using OtherCryptedLogin.Domain.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace OtherCryptedLogin.Infrastructure.Repositories
{
    public class UserRepository
    {
        private readonly string xmlFilePath;

        public UserRepository()
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string dataFolderPath = Path.Combine(projectPath, "Data");
            xmlFilePath = Path.Combine(dataFolderPath, "user_data.xml");

            if (!Directory.Exists(dataFolderPath))
            {
                Directory.CreateDirectory(dataFolderPath);
            }

            if (!File.Exists(xmlFilePath))
            {
                new XDocument(new XElement("Users")).Save(xmlFilePath);
            }
        }

        public void Save(User user)
        {
            XElement userData = XElement.Load(xmlFilePath);
            var usersElement = userData.Element("Users");
            if (usersElement == null)
            {
                usersElement = new XElement("Users");
                userData.Add(usersElement);
            }

            usersElement.Add(new XElement("User",
                            new XElement("Email", user.Email),
                            new XElement("Password", user.Password)));
            userData.Save(xmlFilePath);
        }

        public IEnumerable<User> GetAll()
        {
            XElement userData = XElement.Load(xmlFilePath);
            var usersElement = userData.Element("Users");
            if (usersElement == null)
            {
                return new List<User>();
            }

            return usersElement.Elements("User").Select(x => new User
            {
                Email = x.Element("Email")?.Value,
                Password = x.Element("Password")?.Value
            }).ToList();
        }
    }
}
