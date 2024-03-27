using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.DesignPatterns.CreationalPatterns.Prototype;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Product")]
    public class Product : CommonAbstract, ProductPrototype
    {
        public Product()
        {
            this.ProductImage = new HashSet<ProductImage>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Alias { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }
        public string Description { get; set; }

        [AllowHtml]
        public string Detail { get; set; }

        [StringLength(250)]
        public string Image { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceSale { get; set; }
        public int Quantity { get; set; }
        public int ViewCount { get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; }
        public bool IsHot { get; set; }
        public bool IsActive { get; set; }
        public int ProductCategoryId { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }
        [StringLength(500)]
        public string SeoDescription { get; set; }
        [StringLength(250)]
        public string SeoKeywords { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public ProductPrototype Clone()
        {
            Product newProduct = new Product();
            newProduct.Title = Title;
            newProduct.ProductCode = ProductCode;
            newProduct.Description = Description;
            newProduct.Detail = Detail;
            newProduct.Image = Image;
            newProduct.Price = Price;
            newProduct.PriceSale = PriceSale;
            newProduct.Quantity = Quantity;
            newProduct.IsHome = IsHome;
            newProduct.IsSale = IsSale;
            newProduct.IsFeature = IsFeature;
            newProduct.IsHot = IsHot;
            newProduct.ProductCategoryId = ProductCategoryId;
            newProduct.SeoTitle = SeoTitle;
            newProduct.SeoDescription = SeoDescription;
            newProduct.SeoKeywords = SeoKeywords;
            newProduct.CreatedBy = CreatedBy;
            newProduct.CreatedDate = CreatedDate;
            newProduct.ModifiedDate = ModifiedDate;
            newProduct.Modifiedby = Modifiedby;
            newProduct.Alias = Alias;
            newProduct.IsActive = IsActive;
            newProduct.ViewCount = ViewCount;
            newProduct.OriginalPrice = OriginalPrice;

            return newProduct;
        }
    }
}