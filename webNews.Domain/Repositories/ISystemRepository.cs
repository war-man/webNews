﻿using webNews.Models.Common;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using webNews.Models;
using ServiceStack.OrmLite;
using webNews.Domain.Entities;

namespace webNews.Domain.Repositories
{
    public interface ISystemRepository
    {
        HomePageInfo GetPageInfo();
        List<System_Menu> GetMenu();
        List<News> GetNews(int categoryId = -1);
        List<NewsCategory> GetNewCategories();
        List<ProjectCategory> GetProjectCategories();
        List<Project> GetProjects(int categoryId = -1);
        List<System_Menu> GetMenuUser();
        List<Security_Function> GetListFunctions();
        List<Security_Permission> GetListSecurity_Permission();
        List<Security_VwRoleService> GetMarkPermission(List<Security_UserRole> listRole);
        bool Security_Permission_Update(Security_Permission request);
        int Security_Permission_Delete(int id);
        //string CodeGen(ObjectType objectType, string name = "Z", int number = 10);

        Task<PagingObject<T>> PagingAsync<T>(SqlExpression<T> query, int? pageIndex = null, int? pageSize = null);
        PagingObject<T> Paging<T>(SqlExpression<T> query, int? pageIndex = null, int? pageSize = null);

            //List object
        PagingObject<T> Paging<T>(List<T> list, int? pageIndex = null, int? pageSize = null);
    }
}