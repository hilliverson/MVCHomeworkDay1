using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MVCHomeworkDay1.Models.ViewModel;

namespace MVCHomeworkDay1.Service
{

    public class AccountBookService
    {
        private string _ConnStr;
        public AccountBookService()
        {
            _ConnStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            // _ConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HILL.HUANG\SOURCE\REPOS\MVCHOMEWORKDAY1\MVCHOMEWORKDAY1\MVCHOMEWORKDAY1\APP_DATA\SKILLTREEHOMEWORK.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }

        public void Insert(BillViewModel data)
        {
            string sql = "INSERT INTO AccountBook (id,Categoryyy,Amounttt,Dateee,remarkkk) Values (@id,@category,@amount,@date,@remark);";

            using (var connection = new SqlConnection(_ConnStr))
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new
                {
                    id = new Guid(),
                    category = data.category,
                    amount = data.money,
                    date = data.date,
                    remark = data.description

                });

            }
        }

        public List<BillViewModel> Get()
        {
            using (var conn = new SqlConnection(_ConnStr))
            {
                var list = conn.Query<AccountBook>("select Id,Categoryyy,Amounttt,Dateee,Remarkkk from AccountBook").ToList();
                var ModelList = list.Select(x => new BillViewModel
                {
                    //Id = x.Id,
                    category = (x.Categoryyy ==0) ? "支出" : "收入",
                    money = x.Amounttt,
                    date = x.Dateee,
                    description = x.Remarkkk
                }).ToList();

                return ModelList;
            }
        }
    }
}
