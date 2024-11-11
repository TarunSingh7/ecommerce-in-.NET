using CourseStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CourseStore.DataAccess.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Category>().HasData(
	 new Category { Id = 1, Name = "Coding", DisplayOrder = 1 },
	 new Category { Id = 2, Name = "Soft Skills", DisplayOrder = 2 },
	 new Category { Id = 3, Name = "Photography", DisplayOrder = 3 },
	 new Category { Id = 4, Name = "Video Editing", DisplayOrder = 4 },
	 new Category { Id = 5, Name = "Digital Marketing", DisplayOrder = 5 },
	 new Category { Id = 6, Name = "Creative Writing", DisplayOrder = 6 },
	 new Category { Id = 7, Name = "Graphic Design", DisplayOrder = 7 },
	 new Category { Id = 8, Name = "Finance & Accounting", DisplayOrder = 8 },
	 new Category { Id = 9, Name = "Business Management", DisplayOrder = 9 },
	 new Category { Id = 10, Name = "Health & Wellness", DisplayOrder = 10 }
 );


		modelBuilder.Entity<Company>().HasData(
	new Company
	{
		Id = 1,
		Name = "Tech Solution",
		StreetAddress = "123 Innovation Road",
		City = "Silicon Valley",
		State = "California",
		PhoneNumber = "1234567890",
		PostalCode = "94025",
	},
	new Company
	{
		Id = 2,
		Name = "Big Tech",
		StreetAddress = "456 High Tech Ave",
		City = "Austin",
		State = "Texas",
		PhoneNumber = "9876543210",
		PostalCode = "73301",
	},
	new Company
	{
		Id = 3,
		Name = "Data Insights",
		StreetAddress = "789 Data Drive",
		City = "New York",
		State = "New York",
		PhoneNumber = "5555555555",
		PostalCode = "10001",
	},
	new Company
	{
		Id = 4,
		Name = "Creative Minds",
		StreetAddress = "101 Creative Lane",
		City = "Los Angeles",
		State = "California",
		PhoneNumber = "4444444444",
		PostalCode = "90001",
	},
	new Company
	{
		Id = 5,
		Name = "Skill Academy",
		StreetAddress = "202 Skill Road",
		City = "Boston",
		State = "Massachusetts",
		PhoneNumber = "3333333333",
		PostalCode = "02108",
	}
);

        modelBuilder.Entity<Product>().HasData(
            // Coding Courses
            new Product
            {
                Id = 1,
                Title = "Introduction to Python Programming",
                Instructor = "John Doe",
                Description = "Learn the basics of Python programming, including syntax, variables, loops, and functions. Perfect for beginners.",
                Duration = 20, // Duration in hours
                Level = "Beginner",
                Content = "This course covers the fundamentals of Python programming.", // Added Content
                StandardPrice = 100,
                Price = 90,
                Price50 = 85,
                Price100 = 80,
                CategoryId = 1, // Coding category
            },
            new Product
            {
                Id = 2,
                Title = "Web Development with HTML, CSS, and JavaScript",
                Instructor = "Jane Smith",
                Description = "A comprehensive course on building modern websites using HTML, CSS, and JavaScript. Includes hands-on projects.",
                Duration = 30,
                Level = "Intermediate",
                Content = "This course provides a complete guide to web development.", // Added Content
                StandardPrice = 120,
                Price = 110,
                Price50 = 100,
                Price100 = 90,
                CategoryId = 1, // Coding category
            },

            // Soft Skill Courses
            new Product
            {
                Id = 3,
                Title = "Effective Communication Skills",
                Instructor = "Mark Robinson",
                Description = "Develop your communication skills to improve personal and professional interactions, including active listening and feedback.",
                Duration = 10,
                Level = "Beginner",
                Content = "This course focuses on enhancing communication abilities.", // Added Content
                StandardPrice = 50,
                Price = 45,
                Price50 = 40,
                Price100 = 35,
                CategoryId = 2, // Soft skills category
            },
            new Product
            {
                Id = 4,
                Title = "Leadership and Team Management",
                Instructor = "Sarah Johnson",
                Description = "Master leadership skills, team management, and conflict resolution techniques to become an effective leader.",
                Duration = 15,
                Level = "Advanced",
                Content = "This course teaches essential leadership strategies.", // Added Content
                StandardPrice = 80,
                Price = 75,
                Price50 = 70,
                Price100 = 65,
                CategoryId = 2, // Soft skills category
            },

            // Photography Courses
            new Product
            {
                Id = 5,
                Title = "Photography for Beginners",
                Instructor = "Julian Button",
                Description = "Learn the basics of photography, including camera settings, composition, and lighting techniques. Perfect for aspiring photographers.",
                Duration = 12,
                Level = "Beginner",
                Content = "This course introduces fundamental photography concepts.", // Added Content
                StandardPrice = 55,
                Price = 50,
                Price50 = 40,
                Price100 = 35,
                CategoryId = 3, // Photography category
            },
            new Product
            {
                Id = 6,
                Title = "Advanced Portrait Photography",
                Instructor = "Emily Watson",
                Description = "Enhance your portrait photography skills with advanced lighting setups, posing techniques, and editing tips.",
                Duration = 20,
                Level = "Advanced",
                Content = "This course covers advanced techniques in portrait photography.", // Added Content
                StandardPrice = 100,
                Price = 95,
                Price50 = 85,
                Price100 = 75,
                CategoryId = 3, // Photography category
            },

            // Video Editing Courses
            new Product
            {
                Id = 7,
                Title = "Basic Video Editing with Adobe Premiere Pro",
                Instructor = "Chris Evans",
                Description = "Learn the fundamentals of video editing using Adobe Premiere Pro, including cutting, transitions, and adding effects.",
                Duration = 15,
                Level = "Beginner",
                Content = "This course covers basic video editing techniques.", // Added Content
                StandardPrice = 70,
                Price = 65,
                Price50 = 60,
                Price100 = 55,
                CategoryId = 4, // Video Editing category
            },
           new Product
           {
               Id = 8,
               Title = "Creative Video Editing Techniques",
               Instructor = "Laura Stone",
               Description = "Master advanced video editing techniques, including color correction, motion graphics, and sound design.",
               Duration = 25,
               Level = "Intermediate",
               Content = "This course teaches advanced video editing methods.", // Added Content
               StandardPrice = 120,
               Price = 110,
               Price50 = 100,
               Price100 = 90,
               CategoryId = 4, // Video Editing category
           },

           // Other Courses
           new Product
           {
               Id = 9,
               Title = "Introduction to Digital Marketing",
               Instructor = "Daniel Craig",
               Description = "Explore the basics of digital marketing, including SEO, social media marketing, and content creation strategies.",
               Duration = 18,
               Level = "Beginner",
               Content = "This course introduces digital marketing fundamentals.", // Added Content
               StandardPrice = 90,
               Price = 85,
               Price50 = 80,
               Price100 = 75,
               CategoryId = 5, // Marketing category
           },
           new Product
           {
               Id = 10,
               Title = "Creative Writing for Beginners",
               Instructor = "Olivia Brown",
               Description = "Develop your creative writing skills with this beginner course covering storytelling, character development, and editing.",
               Duration = 10,
               Level = "Beginner",
               Content = "This course focuses on developing creative writing skills.", // Added Content
               StandardPrice = 50,
               Price = 45,
               Price50 = 40,
               Price100 = 35,
               CategoryId = 6, // Writing category
           }
        );

    }
}
