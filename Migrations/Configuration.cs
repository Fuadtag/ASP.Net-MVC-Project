namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AspNetFinalProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetFinalProject.Data.JoobsyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetFinalProject.Data.JoobsyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Advices.AddOrUpdate(a => a.Id,
                new Advice() { Id = 1, CreatedAt = DateTime.Now, Title = "Aenean vulputate eleifend tellus", Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam", Photo = "img-1.jpg" },
                new Advice() { Id = 2, CreatedAt = DateTime.Now, Title = "Aenean vulputate eleifend tellus", Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam", Photo = "img-1.jpg" },
                new Advice() { Id = 3, CreatedAt = DateTime.Now, Title = "Aenean vulputate eleifend tellus", Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam", Photo = "img-1.jpg" }

            );
            context.Categories.AddOrUpdate(c => c.Id,
                new Category() { Id = 1, Name = "Developer", Icon = "account" },
                new Category() { Id = 2, Name = "Technology", Icon = "desktop-classic" },
                new Category() { Id = 3, Name = "Government", Icon = "bank" }

            );
            context.HowItWorks.AddOrUpdate(h => h.Id,
                new HowItWork() { Id = 1, Text = "Donec pede justo fringilla vel aliquet nec vulputate eget arcu. In enim justo rhoncus ut a, venenatis vitae justo.", Title = "Register an account", Photo = "img-h-1.png" },
                new HowItWork() { Id = 2, Text = "Aliquam lorem ante dapibus in, viverra feugiatquis a tellus. Phasellus viverra nulla ut metus varius Quisque rutrum.", Title = "Search your job", Photo = "img-3.png" },
                new HowItWork() { Id = 3, Text = "Donec pede justo fringilla vel aliquet nec vulputate eget arcu. In enim justo rhoncus ut a, venenatis vitae justo.", Title = "Apply for job", Photo = "img-2.png" }
                );
            context.SuccessStories.AddOrUpdate(s => s.Id,
                new SuccessStory() { Id = 1, Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", Author = "Kevin Stewart", Position = "Web Designer at xyz Company", Photo = "img-1s.png" },
                new SuccessStory() { Id = 2, Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", Author = "Kevin Stewart", Position = "Web Designer at xyz Company", Photo = "img-1s.png" },
                new SuccessStory() { Id = 3, Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", Author = "Kevin Stewart", Position = "Web Designer at xyz Company", Photo = "img-1s.png" },
                new SuccessStory() { Id = 4, Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", Author = "Kevin Stewart", Position = "Web Designer at xyz Company", Photo = "img-1s.png" }
                );
            context.Clients.AddOrUpdate(c => c.Id,
                new Client() { Id = 1, Photo = "1.png" },
                 new Client() { Id = 2, Photo = "1.png" },
                  new Client() { Id = 3, Photo = "1.png" },
                   new Client() { Id = 4, Photo = "1.png" }



            );
            context.Companies.AddOrUpdate(c => c.Id,
                new Company()
                {
                    Id = 1,
                    Adress = "4102 Aviation Way Los Angeles, CA 90017",
                    WebSite = "Themescodeltd.co.in",
                    Email = "Themescodeltd2018@gmail.com",
                    Phone = "123 456 7890",
                    OverView = "At vero eos accusamus iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti that is atque corrupti dolores et quas molestias excepturi sint occaecati cupiditate non at provident similique sunt in culpa qui officia deserunt mollitia animi id est laboru at dolorum fuga Nam libero tempore cum soluta nobis est eligendi optio cumque nihil impedit quo minus quod maxime placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes nascetur ridiculus mus donec quam felis ultricies nec pellentesque eu pretium quis sem that phasellus viverra nulla ut metus varius laoreet.",
                    Service = "Aenean tellus metus bibendum sed posuere ac mattis non nunc estibulum fringilla pede sit amet augue n turpis Pellentesque posuere raesent turpis enean posuere tortor sed cursus feugiat nunc augue blandit nunc sollicitudin at dolor sagittis lacus estibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Sed aliquam nisi quis porttitor congue elit erat euismod orci ac placerat dolor lectus quis orci repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla hasellus consectetuer vestibulum elit.",
                    Details = new System.Collections.Generic.List<string> { "Morbi mattis ullamcorper velit hasellus gravida semper nisi nullam vel sem.", "Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet.", "Etiam ultricies nisi vel augue Curabitur ullamcorper ultricies nisi am eget dui tiam rhoncus.", "Donec mollis hendrerit risus hasellus nec sem in justo pellentesque facilisis." },
                    OpeningHours = new System.Collections.Generic.List<string> { "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "closed" },
                    ExperienceYears = "1 To 3 Years",
                    IsVerified = true,
                    CompanyType = "Create Website",
                    Photo = "img-4.png"
                },
            new Company()
                {
                    Id = 2,
                    Adress = "4102 Aviation Way Los Angeles, CA 90017",
                    WebSite = "Themescodeltd.co.in",
                    Email = "Themescodeltd2018@gmail.com",
                    Phone = "123 456 7890",
                    OverView = "At vero eos accusamus iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti that is atque corrupti dolores et quas molestias excepturi sint occaecati cupiditate non at provident similique sunt in culpa qui officia deserunt mollitia animi id est laboru at dolorum fuga Nam libero tempore cum soluta nobis est eligendi optio cumque nihil impedit quo minus quod maxime placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes nascetur ridiculus mus donec quam felis ultricies nec pellentesque eu pretium quis sem that phasellus viverra nulla ut metus varius laoreet.",
                    Service = "Aenean tellus metus bibendum sed posuere ac mattis non nunc estibulum fringilla pede sit amet augue n turpis Pellentesque posuere raesent turpis enean posuere tortor sed cursus feugiat nunc augue blandit nunc sollicitudin at dolor sagittis lacus estibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Sed aliquam nisi quis porttitor congue elit erat euismod orci ac placerat dolor lectus quis orci repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla hasellus consectetuer vestibulum elit.",
                    Details = new System.Collections.Generic.List<string> { "Morbi mattis ullamcorper velit hasellus gravida semper nisi nullam vel sem.", "Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet.", "Etiam ultricies nisi vel augue Curabitur ullamcorper ultricies nisi am eget dui tiam rhoncus.", "Donec mollis hendrerit risus hasellus nec sem in justo pellentesque facilisis." },
                    OpeningHours = new System.Collections.Generic.List<string> { "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "closed" },
                    ExperienceYears = "1 To 3 Years",
                    IsVerified = true,
                    CompanyType = "Create Website",
                    Photo = "img-4.png"
                },
            new Company()
            {
                Id = 3,
                Adress = "4102 Aviation Way Los Angeles, CA 90017",
                WebSite = "Themescodeltd.co.in",
                Email = "Themescodeltd2018@gmail.com",
                Phone = "123 456 7890",
                OverView = "At vero eos accusamus iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti that is atque corrupti dolores et quas molestias excepturi sint occaecati cupiditate non at provident similique sunt in culpa qui officia deserunt mollitia animi id est laboru at dolorum fuga Nam libero tempore cum soluta nobis est eligendi optio cumque nihil impedit quo minus quod maxime placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes nascetur ridiculus mus donec quam felis ultricies nec pellentesque eu pretium quis sem that phasellus viverra nulla ut metus varius laoreet.",
                Service = "Aenean tellus metus bibendum sed posuere ac mattis non nunc estibulum fringilla pede sit amet augue n turpis Pellentesque posuere raesent turpis enean posuere tortor sed cursus feugiat nunc augue blandit nunc sollicitudin at dolor sagittis lacus estibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Sed aliquam nisi quis porttitor congue elit erat euismod orci ac placerat dolor lectus quis orci repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla hasellus consectetuer vestibulum elit.",
                Details = new System.Collections.Generic.List<string> { "Morbi mattis ullamcorper velit hasellus gravida semper nisi nullam vel sem.", "Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet.", "Etiam ultricies nisi vel augue Curabitur ullamcorper ultricies nisi am eget dui tiam rhoncus.", "Donec mollis hendrerit risus hasellus nec sem in justo pellentesque facilisis." },
                OpeningHours = new System.Collections.Generic.List<string> { "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "9AM - 7PM", "closed" },
                ExperienceYears = "1 To 3 Years",
                IsVerified = true,
                CompanyType = "Create Website",
                Photo = "img-4.png"
            });
            context.Countries.AddOrUpdate(c => c.Id,
                new Country() { Id = 1, Name = "Azerbaijan"},
                new Country() { Id = 2, Name = "Georgia" },
                new Country() {Id = 3, Name = "Russia" }
            
            
            
            );

            context.Jobs.AddOrUpdate(j => j.Id,
                new Job() { Id = 1, Name = "Web Developer", TitleText = "Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    CreatedAt = DateTime.Now,
                    CountryId = 1,
                    City = "Baku",
                    Gender = Genders.Female,
                    Shift = Shifts.Evening,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    Qualifications = new System.Collections.Generic.List<string> { "Morbi mattis ullamcorper velit. Phasellus gravida semper nisi nullam vel sem.", "Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet.", "Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus.", "Donec mollis hendrerit risus. Phasellus nec sem in justo pellentesque facilisis." },
                    Responsibilities = new System.Collections.Generic.List<string> { "HTML, CSS & Scss", "Javascript", "PHP", "Photoshop" },
                    IsAcceptedByAdmin = true,
                    CompanyId =1,
                    CategoryId = 1,
                    MinSalary = 400,
                    MaxSalary = 700

                },
                new Job()
                {
                    Id = 2,
                    Name = "Web Developer",
                    TitleText = "Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    CreatedAt = DateTime.Now,
                    CountryId = 1,
                    City = "Baku",
                    Gender = Genders.Female,
                    Shift = Shifts.Evening,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    Qualifications = new System.Collections.Generic.List<string> { "Morbi mattis ullamcorper velit. Phasellus gravida semper nisi nullam vel sem.", "Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet.", "Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus.", "Donec mollis hendrerit risus. Phasellus nec sem in justo pellentesque facilisis." },
                    Responsibilities = new System.Collections.Generic.List<string> { "HTML, CSS & Scss", "Javascript", "PHP", "Photoshop" },
                    IsAcceptedByAdmin = true,
                    CompanyId = 1,
                    MinSalary = 400,
                    MaxSalary = 700,
                    CategoryId = 1

                },
                new Job()
                {
                    Id = 3,
                    Name = "Web Developer",
                    TitleText = "Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    CreatedAt = DateTime.Now,
                    CountryId = 3,
                    City = "Baku",
                    Gender = Genders.Female,
                    Shift = Shifts.Evening,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    Qualifications = new System.Collections.Generic.List<string> { "Morbi mattis ullamcorper velit. Phasellus gravida semper nisi nullam vel sem.", "Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet.", "Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus.", "Donec mollis hendrerit risus. Phasellus nec sem in justo pellentesque facilisis." },
                    Responsibilities = new System.Collections.Generic.List<string> { "HTML, CSS & Scss", "Javascript", "PHP", "Photoshop" },
                    IsAcceptedByAdmin = true,
                    CompanyId = 1,
                    MinSalary = 400,
                    MaxSalary = 700,
                    CategoryId = 1

                },
                new Job()
                {
                    Id = 4,
                    Name = "Web Developer",
                    TitleText = "Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    CreatedAt = DateTime.Now,
                    CountryId = 2,
                    City = "Baku",
                    Gender = Genders.Female,
                    Shift = Shifts.Evening,
                    Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.",
                    Qualifications = new System.Collections.Generic.List<string> { "Morbi mattis ullamcorper velit. Phasellus gravida semper nisi nullam vel sem.", "Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet.", "Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus.", "Donec mollis hendrerit risus. Phasellus nec sem in justo pellentesque facilisis." },
                    Responsibilities = new System.Collections.Generic.List<string> { "HTML, CSS & Scss", "Javascript", "PHP", "Photoshop" },
                    IsAcceptedByAdmin = true,
                    CompanyId = 1,
                    MinSalary = 400,
                    MaxSalary = 700,
                    CategoryId = 1

                }


            );
            context.Clients.AddOrUpdate(c => c.Id,

                new Client() { Id = 1, Photo = "1.png" },
                new Client() { Id = 2, Photo = "1.png" },
                new Client() { Id = 3, Photo = "1.png" }

            );
            context.Employees.AddOrUpdate(e => e.Id,
                new Employee()
                {
                    Id = 1,
                    Name = "Kyle Jones",
                    Surname = "Jones",
                    UserName = "KyleJones",
                    Qualifications = new System.Collections.Generic.List<string> { "Web Delveloper", "Graphic Desingner" },
                    EmailAdress = "KyleJones@email.com",
                    Photo = "img-2 (1).png",
                    Password = "123456",
                    Rating = 5,
                    Adress = "419 Lakeland Terrace Detroit, MI 48226",
                    RememberMe = true,
                    Star = 5,
                    CompanyId = 1



                },
                new Employee()
                {
                    Id = 2,
                    Name = "Kyle Jones",
                    Surname = "Jones",
                    UserName = "KyleJones",
                    Qualifications = new System.Collections.Generic.List<string> { "Web Delveloper", "Graphic Desingner" },
                    EmailAdress = "KyleJones@email.com",
                    Photo = "img-2 (1).png",
                    Password = "123456",
                    Rating = 5,
                    Adress = "419 Lakeland Terrace Detroit, MI 48226",
                    RememberMe = true,
                    Star = 5,
                    CompanyId = 1


                },
                new Employee()
                {
                    Id = 3,
                    Name = "Kyle Jones",
                    Surname = "Jones",
                    UserName = "KyleJones",
                    Qualifications = new System.Collections.Generic.List<string> { "Web Delveloper", "Graphic Desingner" },
                    EmailAdress = "KyleJones@email.com",
                    Photo = "img-2 (1).png",
                    Password = "123456",
                    Rating = 5,
                    Adress = "419 Lakeland Terrace Detroit, MI 48226",
                    RememberMe = true,
                    Star = 5,
                    CompanyId = 1


                },
                new Employee()
                {
                    Id = 4,
                    Name = "Kyle Jones",
                    Surname = "Jones",
                    UserName = "KyleJones",
                    Qualifications = new System.Collections.Generic.List<string> { "Web Delveloper", "Graphic Desingner" },
                    EmailAdress = "KyleJones@email.com",
                    Photo = "img-2 (1).png",
                    Password = "123456",
                    Rating = 5,
                    Adress = "419 Lakeland Terrace Detroit, MI 48226",
                    RememberMe = true,
                    Star = 5,
                    CompanyId = 1


                });
            context.CompanyReviews.AddOrUpdate(c => c.Id,
                new CompanyReview()
                {
                    Id = 1,
                    EmployeeId = 1,
                    CompanyId = 1,
                    CreatedAt = DateTime.Now,
                    Text = "Phasellus viverra nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui."

                },
                new CompanyReview()
                {
                    Id = 2,
                    EmployeeId = 2,
                    CompanyId = 2,
                    CreatedAt = DateTime.Now,
                    Text = "Phasellus viverra nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui."

                },
                new CompanyReview()
                {
                    Id = 3,
                    EmployeeId = 2,
                    CompanyId = 3,
                    CreatedAt = DateTime.Now,
                    Text = "Phasellus viverra nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui."

                }

            );

            context.Blogs.AddOrUpdate(b => b.Id,
                new Blog()
                {
                    Id = 1,
                    BlogCategoryId = 1,
                    
                    CreatedAt = DateTime.Now,
                    Author = "Maude J. McDowell",
                    Title = "A small river named Duden flows by their place and supplies regelialia.",
                    Text = "The Big Oxmox advised her not to do so because there were thousands of bad Commas as wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way But nothing the copy said could convince her and s didn’t take long until a few insidious Copy Writers ambushed made her drunk with Longe and Parole and dragged a into their agency where they abused her for their projects again and again. And if hasn’t been rewritten.",
                    FooterText = "It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave."
                },
                 new Blog()
                 {
                     Id = 2,
                     BlogCategoryId = 1,
                     CreatedAt = DateTime.Now,
                     Author = "Maude J. McDowell",
                     Title = "A small river named Duden flows by their place and supplies regelialia.",
                     Text = "The Big Oxmox advised her not to do so because there were thousands of bad Commas as wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way But nothing the copy said could convince her and s didn’t take long until a few insidious Copy Writers ambushed made her drunk with Longe and Parole and dragged a into their agency where they abused her for their projects again and again. And if hasn’t been rewritten.",
                     FooterText = "It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave."
                 },
                  new Blog()
                  {
                      Id = 3,
                      BlogCategoryId = 2,
                      CreatedAt = DateTime.Now,
                      Author = "Maude J. McDowell",
                      Title = "A small river named Duden flows by their place and supplies regelialia.",
                      Text = "The Big Oxmox advised her not to do so because there were thousands of bad Commas as wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way But nothing the copy said could convince her and s didn’t take long until a few insidious Copy Writers ambushed made her drunk with Longe and Parole and dragged a into their agency where they abused her for their projects again and again. And if hasn’t been rewritten.",
                      FooterText = "It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave."
                  },
                   new Blog()
                   {
                       Id = 3,
                       BlogCategoryId = 1,
                       CreatedAt = DateTime.Now,
                       Author = "Maude J. McDowell",
                       Title = "A small river named Duden flows by their place and supplies regelialia.",
                       Text = "The Big Oxmox advised her not to do so because there were thousands of bad Commas as wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way But nothing the copy said could convince her and s didn’t take long until a few insidious Copy Writers ambushed made her drunk with Longe and Parole and dragged a into their agency where they abused her for their projects again and again. And if hasn’t been rewritten.",
                       FooterText = "It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave."
                   }





                );

            context.BlogCategories.AddOrUpdate(b => b.Id,
                new BlogCategory()
                {
                    Id = 1,
                    Name = "Software Developer"
                },
                new BlogCategory()
                {
                    Id = 2,
                    Name = "Accounting"
                },
                new BlogCategory()
                {
                    Id = 3,
                    Name = "Marketing Job"
                },
                new BlogCategory()
                {
                    Id = 4,
                    Name = "Web Developer"
                }

                );

            context.Experiences.AddOrUpdate(e=>e.Id,
                new Experience() {
                    Id = 1,
                     CandidateId = 1,
                    Salary = 500,
                     StartDate = new DateTime(2017, 10, 19),
                     EndDate = new DateTime(2018, 10, 10),
                     Position = "PHP Developer",
                     





                }
                
                );


            context.Candidates.AddOrUpdate(c => c.Id,
                new Candidate() {
                Id = 1,
                CountryId =1,
                Name = "Michael",
                Surname = "Brown",
                Marriage = Marriages.single,
                Password = "22222",
                City = "",
                Phone = "",
                WebSite = "",
               Email = "",
               Photo = "",
               Skills = new List<string> { "HTML / CSS", "Javascript", "PHP" }
                MiddleName = "Brown",
                BirthDate = new DateTime(1998, 12, 12),
                Overview ="",
                AboutUs = "",
                Address = "",
                

                  
                });


            context.BlogReviews.AddOrUpdate(b => b.Id,
                new BlogReview()
                {
                    Id = 1,
                    BlogId =1,
                    CandidateId = 1,
                    EmployeeId=1,
                    CreatedAt = DateTime.Now,
                    Text = "The Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",
                     


                },
                 new BlogReview()
                 {
                     Id = 2,
                     BlogId = 1,
                     CandidateId = 1,
                     EmployeeId = 1,
                     CreatedAt = DateTime.Now,
                     Text = "The Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",



                 },
                  new BlogReview()
                  {
                      Id = 3,
                      BlogId = 1,
                      CandidateId = 1,
                      EmployeeId = 1,
                      CreatedAt = DateTime.Now,
                      Text = "The Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",



                  }



                );
            context.Blogs.AddOrUpdate(b => b.Id,
                new Blog()
                {
                    Id = 1,
                    Title = "Quis autem at eum illum at fugiat dolor diam sagittis ligula ac felis quis tortor.",
                    CreatedAt = DateTime.Now,
                    Text = "At vero this accusamus iusto dignissimos corrupti ducim qui blanditiis voluptatum deleniti atque corrupti dolores molestias that excepturi a cupiditate non provident sunt i culpa.",
                    FooterText = "It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave.",
                    Author = "Maude J. McDowell",
                    BlogCategoryId = 1,
                    
                    
                }


                );

            


            














        }
    }
}
