using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Views
{
    public class IndexContatos : PageModel
    {
        private readonly ILogger<IndexContatos> _logger;

        public IndexContatos(ILogger<IndexContatos> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}