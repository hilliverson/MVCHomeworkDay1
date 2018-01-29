using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MVCHomeworkDay1.Models.ViewModel;

public class AccountBookService
{
    private string _ConnStr;
    public AccountBookService()
	{
        _ConnStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        // _ConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HILL.HUANG\SOURCE\REPOS\MVCHOMEWORKDAY1\MVCHOMEWORKDAY1\MVCHOMEWORKDAY1\APP_DATA\SKILLTREEHOMEWORK.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    }

    public List<BillViewModel> Get()
    {
        using (var conn = new SqlConnection(_ConnStr))
        {
            List<BillViewModel> list = conn.Query<BillViewModel>("select Id,Categoryyy,Amounttt,Dateee,Remarkkk from AccountBook").ToList();
            var ModelList = list.Select(x => new BillViewModel
            {
                Id = x.Id,
                Categoryyy = (x.Categoryyy == "0") ? "支出" : "收入",
                Amounttt = x.Amounttt,
                Dateee = x.Dateee,
                Remarkkk = x.Remarkkk
            }).ToList();

            return ModelList;
        }
    }
}
