using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using MyEshop.Data;

namespace JShope.Services.Interface
{
    public class PoroductService : IProductService
    {
        private JShopeContext _context;

        public PoroductService(JShopeContext context)
        {
            _context = context;
        }


        #region category
        public List<Category> GetCategory()
        {
            return _context.Categories
                .Include(g => g.Groups)
                .ThenInclude(s => s.SubGroups)
                .ToList();
        }
        public void AddCategory(string categoryName)
        {
            var category = new Category()
            {
                CategoryName = categoryName
            };
            _context.Add(category);
            _context.SaveChanges();
        }

        public void RemoveCategoryById(int categoryId)
        {
            var cat = _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            _context.Remove(cat);
            _context.SaveChanges();
        }

        public void EditCategory(int categoryId, string newCategoryName)
        {

            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (category != null)
            {
                category.CategoryName = newCategoryName;
                _context.SaveChanges();
            }



        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }
        public int GetCategoryIdByGroupId(int groupId)
        {
            var group = _context.Groups.FirstOrDefault(g => g.GroupId == groupId);
            return @group?.CategoryId ?? 0;
        }

        #endregion
        #region Group
        public List<Group> GetGroupsByCategoryId(int categoryId)
        {
            return _context.Groups.Where(g => g.CategoryId == categoryId).ToList();
        }
        public List<Group> GetGroups()
        {
            return _context.Groups.ToList();
        }



        public void RemoveGroupById(int groupId)
        {
            var grp = _context.Groups.FirstOrDefault(g => g.GroupId == groupId);
            _context.Remove(grp);
            _context.SaveChanges();
        }

        public Group GetGroupById(int GroupId)
        {
            return _context.Groups.FirstOrDefault(g => g.GroupId == GroupId);
        }
        public void RemoveGroups(List<Group> groups)
        {
            foreach (var item in groups)
            {
                _context.Remove(item);
            }

            _context.SaveChanges();
        }
        public void EditGroup(int groupId, int categoryId, string newGroupName)
        {
            var group = _context.Groups.FirstOrDefault(g => g.GroupId == groupId);
            if (group != null)
            {
                group.GroupName = newGroupName;
                group.CategoryId = categoryId;
                _context.SaveChanges();
            }

        }

        public void AddNewGroup(string name, int categoryId)
        {
            Group group = new Group()
            {
                GroupName = name,
                CategoryId = categoryId
            };
            _context.Add(group);
            _context.SaveChanges();
        }
        public Group GetGroupBySubGroupId(int subGroupId)
        {
            var group = _context.SubGroups.FirstOrDefault(s => s.SubGroupId == subGroupId)?.Group;
            return group;
        }
        #endregion
        #region SubGroup

        public List<SubGroup> GetSubGroupsByGroupId(int groupId)
        {
            return _context.SubGroups.Where(s => s.GroupId == groupId).ToList();
        }
        public List<SubGroup> GetSubGroups()
        {
            return _context.SubGroups.ToList();
        }
        public SubGroup GetSubGroupById(int subGroupId)
        {
            return _context.SubGroups.FirstOrDefault(s => s.SubGroupId == subGroupId);
        }

        public void RemoveSubGroup(SubGroup subGroup)
        {
            var sub = _context.SubGroups.Find(subGroup);
            if (sub != null)
            {
                _context.SubGroups.Remove(sub);
                _context.SaveChanges();
            }

        }

        public void AddSubGroups(int groupId, string subGroupName)
        {
            SubGroup sub = new SubGroup()
            {
                GroupId = groupId,
                SubGroupName = subGroupName
            };
            _context.SubGroups.Add(sub);
            _context.SaveChanges();
        }

        public void EditSubGroup(int groupId, int subGroupId, string subGroupName)
        {
            var sub = _context.SubGroups.FirstOrDefault(s => s.SubGroupId == subGroupId);
            if (sub != null)
            {
                sub.GroupId = groupId;
                sub.SubGroupName = subGroupName;

            }

            _context.SaveChanges();

        }
        public void RemoveSubGroups(List<SubGroup> subGroups)
        {
            foreach (var item in subGroups)
            {
                _context.Remove(item);
            }

            _context.SaveChanges();
        }

        public List<SubGroup> GetSubGroupsByCategoryId(int categoryId)
        {
            return _context.SubGroups.Where(s => s.Group.CategoryId == categoryId).ToList();
        }
        #endregion
        #region Product
        public int AddProduct(Product product)
        {

            _context.Products.Add(product);
            _context.SaveChanges();
            return product.ProductId;
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products
                .Include(i => i.ProductImages)
                .Include(c => c.ProductColors)
                .Include(c => c.SubGroups)
                .Include(b => b.Brand)
                .Include(g => g.Group)
                .ThenInclude(c => c.Category);
        }

        public Product GetProductById(int productId)
        {
            return _context.Products
                .Include(i => i.ProductImages)
                .Include(b => b.Brand)
                .Include(s => s.Specifications)
                .ThenInclude(t => t.Titles)
                .Include(f => f.UserFavorites)
                .Include(c => c.ProductColors)
                .Include(c => c.SubGroups)
                .Include(g => g.Group)
                .ThenInclude(c => c.Category)
                .SingleOrDefault(p => p.ProductId == productId);
        }

        public void RemoveProduct(Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }



        public void AddProductImage(string imageName, int productId)
        {
            var productImage = new ProductImage()
            {
                Names = imageName,
                ProductId = productId

            };

            _context.ProductImages.Add(productImage);
            _context.SaveChanges();
        }

        public List<ProductImage> GetProductImage(int productId)
        {
            return _context.ProductImages.Where(i => i.ProductId == productId).ToList();
        }

        public void RemoveImage(int imgId, int productId)
        {

            var productImage = _context.ProductImages.FirstOrDefault(i => i.ProductId == productId && i.ImageId == imgId);



            if (productImage != null)
            {
                string deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/product/", productImage.Names);
                if (File.Exists(deleteImagePath))
                {
                    File.Delete(deleteImagePath);

                }
                _context.ProductImages.Remove(productImage);
                _context.SaveChanges();
            }
        }

        public List<Product> SearchProducts(string filter)
        {
            return _context.Products.Where(p => p.ProductName.Contains(filter)).ToList();

        }


        public IEnumerable<Product> GetProductByCategoryId(int categoryId)
        {
            return GetProducts().Where(c => c.CategoryId == categoryId);
        }
        public IEnumerable<Product> GetProductByGroupId(int groupId)
        {
            return GetProducts().Where(g => g.GroupId == groupId);

        }
        public IEnumerable<Product> GetProductBySubGroupId(int subGroupId)
        {
            return GetProducts().Where(s => s.SubGroupId == subGroupId);
        }
        #endregion

        #region Brand

        public List<Brands> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<int?> GetDistinctBrands(List<Product> products)
        {
            return products.Select(p => p.BrandId).Distinct();

        }

        public void AddBrand(string brandName)
        {
            Brands brand = new Brands()
            {
                BrandName = brandName
            };
            _context.Brands.Add(brand);
            _context.SaveChanges();
        }

        public IQueryable<Brands> GetDistinctBrandsByGroupId(int groupId)
        {
            return _context.Groups.Where(g => g.GroupId == groupId)
                .SelectMany(g => g.Brands)
                .Distinct();
        }
        public IQueryable<Brands> GetDistinctBrandsBySubGroupId(int subGroupId)
        {
            var a = _context.SubGroups.Where(g => g.SubGroupId == subGroupId)
                .Select(g => g.Group)
                .SelectMany(g => g.Brands)
                .Distinct();
            return a;
        }

        #endregion


        public void AddProductSpecificationTitle(int productId, string headLine, List<Titles> titlesList)
        {
            Specifications specifications = new Specifications()
            {
                HeadLine = headLine,
                Titles = titlesList,
                ProductId = productId
            };
            _context.Specifications.Add(specifications);
            _context.SaveChanges();
        }

        public ProductColors GetProductColor(int productId, int colorId)
        {
            return _context.ProductColors.FirstOrDefault(p => p.ProductId == productId && p.ColorId == colorId);

        }
        #region FilterItems

        public List<Product> FilterProduct(int? categoryId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> FilterProduct(int? categoryId, int? groupId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId && p.GroupId == groupId).ToList();
        }

        public List<Product> FilterProduct(int? categoryId, int? groupId, int? subGroupId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId && p.GroupId == groupId && p.SubGroupId == subGroupId).ToList();
        }

        public void AddColors(List<ProductColors> productColors)
        {
            _context.ProductColors.AddRange(productColors);
            _context.SaveChanges();
        }

        public void EditProductColors(int productId, List<string> colorName, List<string> colorCode)
        {
            var productColorsList = _context.ProductColors.Where(c => c.ProductId == productId);
            _context.ProductColors.RemoveRange(productColorsList);
            var newColorsList = new List<ProductColors>();
            for (int i = 0; i < colorCode.Count; i++)
            {
                var newColor = new ProductColors()
                {
                    ColorCode = colorCode[i],
                    ColorName = colorName[i],
                    ProductId = productId
                };
                newColorsList.Add(newColor);
            }
            _context.ProductColors.AddRange(newColorsList);
            _context.SaveChanges();
        }

        public void RemoveProductColors(int productId)
        {
            var productColors = _context.ProductColors.Where(p => p.ProductId == productId);
            _context.RemoveRange(productColors);
            _context.SaveChanges();
        }

        public IEnumerable<Product> SortProducts(IEnumerable<Product> products, string sortMethod)
        {
            switch (sortMethod)
            {

                case "Visits":

                    return products.OrderByDescending(p => p.Visits);
                case "Newest":
                    return products.OrderByDescending(p => p.CreateDate);

                case "Cheapest":
                    return products.OrderBy(p => p.Price);
                case "Expensive":
                    return products.OrderByDescending(p => p.Price);


                default:
                    return products;
            }
        }

        #endregion


        #region Get Items For DropDown
        public List<SelectListItem> GetCategoryForFilterItems()
        {
            return _context.Categories
                .Select(c => new SelectListItem()
                {
                    Text = c.CategoryName,
                    Value = c.CategoryId.ToString()

                }).ToList();
        }

        public List<SelectListItem> GetGroupsForFilterItems(int categoryId)
        {
            return _context.Groups
                .Where(g => g.CategoryId == categoryId)
                .Select(g => new SelectListItem()
                {
                    Value = g.GroupId.ToString(),
                    Text = g.GroupName
                }).ToList();
        }

        public List<SelectListItem> GetSubGroupsForFilterItems(int groupId)
        {
            return _context.SubGroups.Where(s => s.GroupId == groupId)
                .Select(s => new SelectListItem()
                {
                    Text = s.SubGroupName,
                    Value = s.SubGroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetBrandSelectListItems()
        {
            return _context.Brands
                .Select(b => new SelectListItem()
                {
                    Text = b.BrandName,
                    Value = b.BrandId.ToString()
                }).ToList();
        }





        #endregion

        #region Show Product Method For ProductMain 

        public IEnumerable<Product> ProductShowMethod(int id, string showMethod)
        {
            var pro = GetProducts();
            switch (showMethod)
            {

                case "ByCategory":
                    return pro.Where(p => p.CategoryId == id);


                case "ByGroup":
                    return pro.Where(p => p.GroupId == id);
                case "BySubGroup":
                    return pro.Where(p => p.SubGroupId == id);
                default:
                    return null;
            }

        }

        public IEnumerable<Product> GetProductByBrand(IEnumerable<Product> products, List<int> brandIds)  //***********************
        {

            var pro = GetProducts().Where(b => b.BrandId != null && brandIds.Contains((int)b.BrandId));



            return pro;
        }

        public List<Product> GetProductByBrandId(int brandId)
        {
            return _context.Products.Where(b => b.BrandId == brandId)
                .Include(i => i.ProductImages)
                .ToList();
        }

        public IEnumerable<Product> GetProductsByName(string searchWord)
        {
            return _context.Products.Where(p => p.ProductName.Contains(searchWord));
        }

        public void AddFavorite(int productId, int userId)
        {

            var favor = new UserFavorites()
            {
                UserId = userId,
                ProductId = productId
            };
            _context.UserFavorites.Add(favor);
            _context.SaveChanges();
        }



        #endregion


    }
}
