using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MVCHomeworkDay1.Models.DataModel;
using MVCHomeworkDay1.Models.ViewModel;

public class AccountBookService
{
    private string _ConnStr;
    public AccountBookService()
	{
        _ConnStr = @"(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HILL.HUANG\DOWNLOADS\SESSION2\HOMEWORKDB\HOMEWORKDB\APP_DATA\SKILLTREEHOMEWORK.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
	}

    public List<AccountBook> Get()
    {
        using (var conn = new SqlConnection(_ConnStr))
        {
            List<AccountBook> list = conn.Query<AccountBook>("select * from AccountBook").ToList();
            return list;
        }
    }
}
