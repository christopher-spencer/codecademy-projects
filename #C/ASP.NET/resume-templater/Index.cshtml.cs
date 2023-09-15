// Index.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeTemplater.Pages
{
	public class IndexModel : PageModel
	{
    public string FullName {get; set;}
    public string LinkedInUsername {get; set;}
    public int YearsOfExperience {get; set;}
    public List<string> Languages {get; set;}

    public void OnGet() {

      FullName = "Christopher Spencer";
      LinkedInUsername = "christopher-dale-spencer";
      YearsOfExperience = 1;
      Languages = new List<string> {"Java", "JavaScript", "C#", "PHP"};

    }
		
  }
}