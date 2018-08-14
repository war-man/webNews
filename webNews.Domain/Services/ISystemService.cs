﻿using System.Collections.Generic;
using System.Threading.Tasks;
using webNews.Models;
using ServiceStack.OrmLite;
using webNews.Domain.Entities;

namespace webNews.Domain.Services
{
    public interface ISystemService
    {
        bool Security_Permission_Update(Security_Permission request);
        int Security_Permission_Delete(int id);
        string ReplaceStringWithToken(Dictionary<string, string> tokens, string input);
        Task<PagingObject<T>> PagingAsync<T>(SqlExpression<T> query, int? pageIndex = null, int? pageSize = null);
        PagingObject<T> Paging<T>(SqlExpression<T> query, int? pageIndex = null, int? pageSize = null);

        //List object
        PagingObject<T> Paging<T>(List<T> list, int? pageIndex = null, int? pageSize = null);
       
    }
}