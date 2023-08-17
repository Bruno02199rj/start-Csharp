using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Views.Contato
{
    public class Apagar : PageModel
    {
        private readonly ILogger<Apagar> _logger;

        public Apagar(ILogger<Apagar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}