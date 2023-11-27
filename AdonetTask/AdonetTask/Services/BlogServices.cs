using AdonetTask.Helpers;
using AdonetTask.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetTask.Services
{
    internal class BlogServices : IBaseServices<Blogs>
    {
        public int Create(Blogs data)
        {
            string query = $"INSERT INTO Blogs VALUES (N'{data.Title}', N'{data.Description}',{data.Id} )";
            return SqlHelpers.Exec(query);
        }


        public ICollection<Blogs> GetAll()
        {
            DataTable dt = SqlHelpers.GetDatas("SELECT * FROM Blogs");
            ICollection<Blogs> list = new List<Blogs>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Blogs
                {
                    Id = (int)row["Id"],
                    Title = (string)row["Title"],
                    Description = (string)row["Description"],
                    UserId = (int)row["UserId"]
                });
            }
            return list;
        }
        public Blogs GetById(int id)
        {
            DataTable dt = SqlHelpers.GetDatas($"SELECT * FROM Blogs Where Id={id}");
            foreach (DataRow row in dt.Rows)
            {
                Blogs blog = new Blogs
                {
                    Id = (int)row["Id"],
                    Title = (string)row["Title"],
                    Description = (string)row["Description"],
                    UserId = (int)row["UserId"]
                };
                return blog;
            }
            return null;
        }
    }
}
