using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class LeftNavigationViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var items = new[]
        {
            new { Controller = "Home", Action = "Index", Text = "Home" },
            new { Controller = "Employee", Action = "Index", Text = "Employees" },
            new { Controller = "Home", Action = "Privacy", Text = "Privacy" }
        };

        return View("Default", items);
    }
}
