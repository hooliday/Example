using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using grid.Models;
using OfficeOpenXml;
using NonFactors.Mvc.Grid;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace grid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepository repository;

        public HomeController(ILogger<HomeController> logger, IRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult Index(String search)
        {


            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("_Index", repository.GetPeople());

            return View(repository.GetPeople());
        }


        [HttpGet]
        public FileContentResult ExportIndex()
        {
            IGrid<Person> ddd = new Grid<Person>(repository.GetPeople());
            ddd.ViewContext = new ViewContext { HttpContext = HttpContext };
            ddd.Query = Request.Query;

            // Using EPPlus from nuget
            using (ExcelPackage package = new ExcelPackage())
            {
                Int32 row = 2;
                Int32 col = 1;

                package.Workbook.Worksheets.Add("Data");
                IGrid<Person> grid = CreateExportableGrid();
                ExcelWorksheet sheet = package.Workbook.Worksheets["Data"];

                foreach (IGridColumn column in grid.Columns)
                {
                    sheet.Cells[1, col].Value = column.Title;
                    sheet.Column(col++).Width = 18;

                    column.IsEncoded = false;
                }

                foreach (IGridRow<Person> gridRow in grid.Rows)
                {
                    col = 1;
                    foreach (IGridColumn column in grid.Columns)
                        sheet.Cells[row, col++].Value = column.ValueFor(gridRow);

                    row++;
                }

                return File(package.GetAsByteArray(), "application/unknown", "Export.xlsx");
            }
        }

        private IGrid<Person> CreateExportableGrid()
        {
            IGrid<Person> grid = new Grid<Person>(repository.GetPeople());
            grid.ViewContext = new ViewContext { HttpContext = HttpContext };
            grid.Query = Request.Query;

            grid.Columns.Add(model => model.FirstName).Titled("Name");
            grid.Columns.Add(model => model.LastName).Titled("Surname");
            grid.Columns.Add(model => model.Age).Titled("Age");

            foreach (IGridColumn column in grid.Columns)
            {
                column.Filter.IsEnabled = true;
                column.Sort.IsEnabled = true;
            }

            return grid;
        }










        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
