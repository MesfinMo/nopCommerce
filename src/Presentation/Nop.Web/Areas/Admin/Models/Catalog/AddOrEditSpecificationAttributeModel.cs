﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a specification attribute model to add to the product
    /// </summary>
    public partial class AddOrEditSpecificationAttribute : BaseNopEntityModel
    {
        #region Ctor

        public AddOrEditSpecificationAttribute()
        {
            AvailableOptions = new List<SelectListItem>();
            ShowOnProductPage = true;
            Value = string.Empty;
            ValueRaw = string.Empty;
        }

        #endregion

        #region Properties

        public int SpecificationId { get; set; }

        public int AttributeTypeId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AttributeType")]
        public string AttributeTypeName { get; set; }

        public int AttributeId { get; set; }

        public int ProductId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttribute")]
        public string AttributeName { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
        public string ValueRaw { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
        public string Value { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AllowFiltering")]
        public bool AllowFiltering { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.ShowOnProductPage")]
        public bool ShowOnProductPage { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttributeOption")]
        public int SpecificationAttributeOptionId { get; set; }

        public IList<SelectListItem> AvailableOptions { get; set; }

        #endregion
    }
}