using first.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace first.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Hobbies> MyHobbies { get; set; } = new List<Hobbies>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            MyHobbies.Add(new Hobbies() { Id = 1, Name = "Лижі", Description = "Катання з шаленою швидкістю" });
            MyHobbies.Add(new Hobbies() { Id = 2, Name = "Tesla", Description = "Катання з шаленим прискоренням" });
            MyHobbies.Add(new Hobbies() { Id = 3, Name = "Подорож", Description = "Пізнання нових країн" });
            MyHobbies.Add(new Hobbies() { Id = 4, Name = "Город)))", Description = "Копання в землі" });

        }
    }
}