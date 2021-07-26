using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JShope.Services.Interface
{
    public interface IProductService
    {
        int AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

        List<Category> GetCategory();
        Category GetCategoryById(int categoryId);

        List<Group> GetGroupsByCategoryId(int categoryId);
        List<SubGroup> GetSubGroupsByGroupId(int groupId);
        List<Group> GetGroups();
        public Group GetGroupById(int GroupId);
        List<SubGroup> GetSubGroups();
        List<SubGroup> GetSubGroupsByCategoryId(int categoryId);
        List<Product> GetProduct();
        Product GetProductById(int productId);
        List<Product> GetProductBySubGroupId(int subGroupId);

        SubGroup GetSubGroupById(int subGroupId);
        int GetCategoryIdByGroupId(int groupId);
        
        void RemoveProduct(Product product);

        void AddSubGroups(int groupId, string subGroupName);

        void EditSubGroup(int groupId,int subGroupId,string subGroupName);
        Group GetGroupBySubGroupId(int subGroupId);
        void AddProductImage(string imageName, int productId);

        List<ProductImage> GetProductImage(int productId);

        void RemoveImage(int imgId, int productId);

        List<Product> SearchProducts(string filter);

        void RemoveGroupById(int groupId);

        void AddCategory(string categoryName);


        void RemoveCategoryById(int categoryId);
        void RemoveGroups(List<Group> groups);
        void RemoveSubGroups(List<SubGroup> subGroups);
        void RemoveSubGroup(SubGroup subGroup);

        void EditCategory(int categoryId, string newCategoryName);

        void EditGroup(int groupId, int categoryId, string newGroupName);

       List<Product>  FilterProduct(int? categoryId);
       List<Product>  FilterProduct(int? categoryId, int? groupId);
       List<Product>  FilterProduct(int? categoryId, int? groupId, int? subGroupId);

       List<SelectListItem> GetCategoryForFilterItems();

       List<SelectListItem> GetGroupsForFilterItems(int categoryId);
       List<SelectListItem> GetSubGroupsForFilterItems(int groupId);

       void AddNewGroup(string name, int categoryId);



       
    }
}
