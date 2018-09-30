﻿using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.Catalog.ViewModels;
using System.Collections.Generic;

namespace SimplCommerce.Module.Search.Components
{
    public class CategoriesTreeItemViewComponent : ViewComponent
    {
        #region Ctor

        public CategoriesTreeItemViewComponent()
        {
        }

        #endregion Ctor

        #region Action

        public IViewComponentResult Invoke(IList<CategoriesTree> categories, SearchOption currentSearchOption)
        {
            TempData["currentSearchOption"] = currentSearchOption;
            return View(categories);
        }

        #endregion Action
    }
}