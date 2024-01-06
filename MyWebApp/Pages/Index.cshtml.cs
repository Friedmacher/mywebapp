using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class IndexModel : PageModel
{
    public string StudentName { get; private set; } = "PageModel in C#";
    private readonly ILogger<IndexModel> _logger;
    private readonly MyWebApp.Data.SchoolContext _context;

    public IndexModel(ILogger<IndexModel> logger, MyWebApp.Data.SchoolContext context)
    {
        _logger = logger;
        _context= context;
    }

    public void OnGet()
    {
        var s =_context.Students?.Where(d=>d.ID==1).FirstOrDefault();
        this.StudentName = $"{s?.FirstMidName} {s?.LastName}";
    }
}
