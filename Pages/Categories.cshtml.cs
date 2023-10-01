using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages;

public class Categories : PageModel
{
    public List<Category> CategoryList { get; set; } = new();
    
    public async Task OnGet(int skip = 0, 
                            int take = 25)
    {
        var temp = new List<Category>();
        await Task.Delay(1000);
        for (var i = 0; i < 1700 ; i++)
        {
            temp.Add(
                new Category(i,
                    $"Categoria {i}",
                    i * 18.95M
                )
            );
        }
        CategoryList = temp.Skip(skip)
                           .Take(take)
                           .ToList();
    }
}
public record Category(
    int id,
    string Title,
    decimal Price);
