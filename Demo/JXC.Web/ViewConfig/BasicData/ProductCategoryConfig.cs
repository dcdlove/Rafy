﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建日期：20130821
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20130821 15:29
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rafy.MetaModel;
using Rafy.MetaModel.View;

namespace JXC.Web.ViewConfig.BasicData
{
    internal class ProductCategoryConfig : WebViewConfig<ProductCategory>
    {
        protected override void ConfigView()
        {
            View.DomainName("商品类别").HasDelegate(ProductCategory.NameProperty);

            View.UseDefaultCommands();

            using (View.OrderProperties())
            {
                View.Property(ProductCategory.TreeIndexProperty).HasLabel("编码").ShowIn(ShowInWhere.ListDropDown)
                    .Readonly();
                View.Property(ProductCategory.NameProperty).HasLabel("名称").ShowIn(ShowInWhere.All);
            }
        }
    }
}