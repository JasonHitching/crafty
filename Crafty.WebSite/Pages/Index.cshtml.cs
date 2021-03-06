﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crafty.WebSite.Models;
using Crafty.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Crafty.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
