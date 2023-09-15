// Projects.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeTemplater.Models;

namespace ResumeTemplater.Pages
{
	public class ProjectsModel : PageModel
	{
  
		public List<Project> Projects { get; set; }
    public string GithubUsername { get; set; }
    
		public void OnGet()
		{
      GithubUsername = "christopher-spencer";

			Projects = new List<Project> {
				new Project()
				{
					Title = "City Tour Website",
					Description = "A full-stack application created with Agile/Scrum Methodologies, featuring a GUI (Graphical User Interface) built via Vue.js, which dynamically accesses/modifies information in the pgAdmin database based on user selection. A user can create an itinerary for a trip, plan routes, browse locations, see those locations dynamically pinned to their personal itinerary map (accessed via a Google Maps API) and upload vacation photos (accessed via a Cloudinary API).",
					Year = 2023
				},
				new Project()
				{
					Title = "Candy Store Cash Register",
					Description = "Created a command line interface that kept track of the customer's balance, the store's inventory and cash register sales. Utilized pair programming and Object-Oriented Programming via Java, Git, IntelliJ, file I/O, and Unit Testing.",
					Year = 2023
				},
				new Project()
				{
					Title = "Choose Your Adventure Framework",
					Description = "Applying Polymorphism, Encapsulation, and Inheritance to construct a Java-based, interactive game. The framework offers various pathways to mini-projects, such as a Rock-Paper-Scissors game, based on user input.",
					Year = 2023
				},
        new Project()
				{
					Title = "Money Transfer Application",
					Description = "A Client/Server CLI application that utilizes the MVC and DAO design patterns to connect to a local server and access a local database. This application was built end to end to view all users on the application, and track the signed-in users transfer history which included both sent and received transfers as well as the ability to display a single transaction by a specific Transaction ID.",
					Year = 2023
			};
		}
	}
}
