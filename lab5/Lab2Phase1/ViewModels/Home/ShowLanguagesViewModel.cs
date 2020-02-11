using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab2Phase1.Models;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab2Phase1.ViewModels.Home
{
    public class ShowLanguagesViewModel
    {
        public ShowLanguagesViewModel(CultureInfo[] cultures)
        {
            CulturesList = cultures.Select(c => new SelectListItem() {Text = c.EnglishName});
        }
        public IEnumerable<SelectListItem> CulturesList{ get; private set;}
    }
}