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
        #region Category Services

        List<Category> GetCategory();
        Category GetCategoryById(int categoryId);
        int GetCategoryIdByGroupId(int groupId);
        void AddCategory(string categoryName);
        void RemoveCategoryById(int categoryId);
        void EditCategory(int categoryId, string newCategoryName);

        #endregion

        #region Group Services

        List<Group> GetGroupsByCategoryId(int categoryId);
        List<Group> GetGroups();
        public Group GetGroupById(int GroupId);
        void AddSubGroups(int groupId, string subGroupName);
        Group GetGroupBySubGroupId(int subGroupId);
        void RemoveGroupById(int groupId);
        void RemoveGroups(List<Group> groups);
        void EditGroup(int groupId, int categoryId, string newGroupName);
        void AddNewGroup(string name, int categoryId);
        #endregion


        #region SubGroup Services

        List<SubGroup> GetSubGroupsByGroupId(int groupId);

        List<SubGroup> GetSubGroups();
        List<SubGroup> GetSubGroupsByCategoryId(int categoryId);
        SubGroup GetSubGroupById(int subGroupId);
        void EditSubGroup(int groupId, int subGroupId, string subGroupName);
        void RemoveSubGroups(List<SubGroup> subGroups);
        void RemoveSubGroup(SubGroup subGroup); //Remove single SubGroup

        #endregion


        #region Products 
        int AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productId);
        List<Product> GetProductBySubGroupId(int subGroupId);
        void RemoveProduct(Product product);
        void AddProductImage(string imageName, int productId);
        List<ProductImage> GetProductImage(int productId);
        void RemoveImage(int imgId, int productId);
        List<Product> SearchProducts(string filter);

        List<Product> GetProductByCategoryId(int categoryId);

        List<Product> GetProductByGroupId(int groupId);

        void AddFavorite(int productId,int userId);

        #endregion

        #region Brand

        string GetBrandNameById(int brandId);
        IEnumerable<int?> GetDistinctBrands(List<Product> products);


        IQueryable<Brands> GetDistinctBrandsByGroupId(int groupId);
        IQueryable<Brands> GetDistinctBrandsBySubGroupId(int GsubroupId);
            #endregion

        #region Filter 


        List<Product> FilterProduct(int? categoryId);
        List<Product> FilterProduct(int? categoryId, int? groupId);
        List<Product> FilterProduct(int? categoryId, int? groupId, int? subGroupId);

        #endregion

        void AddColors(List<ProductColors> productColors);
        void EditProductColors(int productId, List<string> colorName, List<string> colorCode);
        void RemoveProductColors(int productId);

        #region ShowProductForProductsMain

        IEnumerable<Product> ProductShowMethod(int id,string showMethod);
        IEnumerable<Product> SortProducts(IEnumerable<Product> products, string sortMethod);

        IEnumerable<Product> GetProductByBrand(IEnumerable<Product> products,List<int> brandId);

        IEnumerable<Product> GetProductsByName(string searchWord);

        #endregion

        #region DropDown Items
        List<SelectListItem> GetCategoryForFilterItems();
        List<SelectListItem> GetGroupsForFilterItems(int categoryId);
        List<SelectListItem> GetSubGroupsForFilterItems(int groupId);
        public List<SelectListItem> GetBrandSelectListItems(int groupId);

        #endregion
































    }
}
