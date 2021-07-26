﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JShope.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public List<Category> GetCategory()
        {
            return _context.Categories.ToList();
        }

        public List<Group> GetGroupsByCategoryId(int categoryId)
        {
            return _context.Groups.Where(g => g.CategoryId == categoryId).ToList();
        }

        public List<SubGroup> GetSubGroupsByGroupId(int groupId)
        {
            return _context.SubGroups.Where(s => s.GroupId == groupId).ToList();
        }

        public List<SubGroup> GetSubGroups()
        {
            return _context.SubGroups.ToList();
        }

        public List<Product> GetProduct()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.SingleOrDefault(p => p.ProductId == productId);
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

            var productImage = _context.ProductImages.FirstOrDefault(i =>
                  i.ProductId == productId && i.ImageId == imgId);


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

        public Group GetGroupById(int GroupId)
        {
            return _context.Groups.FirstOrDefault(g => g.GroupId == GroupId);
        }

        public List<Product> FilterProduct(int? categoryId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> FilterProduct(int? categoryId, int? groupId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId&&p.GroupId==groupId).ToList();
        }

        public List<Product> FilterProduct(int? categoryId, int? groupId, int? subGroupId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId && p.GroupId == groupId&&p.SubGroupId==subGroupId).ToList();
        }

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
                .Where(g=>g.CategoryId==categoryId)
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

        public List<Product> GetProductBySubGroupId(int subGroupId)
        {
            return _context.Products.Where(p => p.SubGroupId == subGroupId).ToList();
        }

        public void RemoveGroups(List<Group> groups)
        {
            foreach (var item in groups)
            {
                _context.Remove(item);
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

        public int GetCategoryIdByGroupId(int groupId)
        {
           var group=_context.Groups.FirstOrDefault(g => g.GroupId == groupId);
           return @group?.CategoryId ?? 0;
        }

        public void EditGroup(int groupId, int categoryId, string newGroupName)
        {
            var group = _context.Groups.FirstOrDefault(g => g.GroupId == groupId);
            if (group!=null)
            {
                group.GroupName = newGroupName;
                group.CategoryId = categoryId;
                _context.SaveChanges();
            }
           
        }

        public SubGroup GetSubGroupById(int subGroupId)
        {
            return _context.SubGroups.FirstOrDefault(s => s.SubGroupId == subGroupId);
        }

        public void RemoveSubGroup(SubGroup subGroup)
        {
            _context.SubGroups.Remove(subGroup);
            _context.SaveChanges();
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
            if (sub!=null)
            {
                sub.GroupId = groupId;
                sub.SubGroupName = subGroupName;

            }

            _context.SaveChanges();

        }

        public Group GetGroupBySubGroupId(int subGroupId)
        {
           var group= _context.SubGroups.FirstOrDefault(s => s.SubGroupId == subGroupId)?.Group;
           return group;
        }
    }
}