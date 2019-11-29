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
            //This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            context.Advices.AddOrUpdate(a => a.Id,
            new Advice() { CreatedAt = DateTime.Now, Title = "Aenean vulputate eleifend tellus", Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam", Photo = "img-1.jpg" },
            new Advice() { CreatedAt = DateTime.Now, Title = "Aenean vulputate eleifend tellus", Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam", Photo = "img-1.jpg" },
            new Advice() { CreatedAt = DateTime.Now, Title = "Aenean vulputate eleifend tellus", Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam", Photo = "img-1.jpg" }

            );


            context.Categories.AddOrUpdate(c => c.Id,
                new Category() { Name = "Developer", Icon = "account" },
                new Category() { Name = "Technology", Icon = "desktop-classic" },
                new Category() { Name = "Government", Icon = "bank" }

            );

            context.HowItWorks.AddOrUpdate(h => h.Id,
                new HowItWork() { Text = "donec pede justo fringilla vel aliquet nec vulputate eget arcu. in enim justo rhoncus ut a, venenatis vitae justo.", Title = "register an account", Photo = "img-h-1.png" },
                new HowItWork() { Text = "aliquam lorem ante dapibus in, viverra feugiatquis a tellus. phasellus viverra nulla ut metus varius quisque rutrum.", Title = "search your job", Photo = "img-3.png" },
                new HowItWork() { Text = "donec pede justo fringilla vel aliquet nec vulputate eget arcu. in enim justo rhoncus ut a, venenatis vitae justo.", Title = "apply for job", Photo = "img-2.png" }
                );

            context.SuccessStories.AddOrUpdate(s => s.Id,
                new SuccessStory() { Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", Author = "Kevin Stewart", Position = "Web Designer at xyz Company", Photo = "img-1s.png" },
                new SuccessStory() { Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", Author = "Kevin Stewart", Position = "Web Designer at xyz Company", Photo = "img-1s.png" },
                new SuccessStory() { Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", Author = "Kevin Stewart", Position = "Web Designer at xyz Company", Photo = "img-1s.png" },
                new SuccessStory() { Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo", Author = "Kevin Stewart", Position = "Web Designer at xyz Company", Photo = "img-1s.png" }
                );

            context.Clients.AddOrUpdate(c => c.Id,
                new Client() { Photo = "1.png" },
                 new Client() { Photo = "1.png" },
                  new Client() { Photo = "1.png" },
                   new Client() { Photo = "1.png" }



            );

            context.Companies.AddOrUpdate(c => c.Id,
                new Company()
                {
                    Name = "Company1",
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
                    Photo = "img-4.png",
                    FacebookLink = "Facebook.com",
                    TwitterLink = "Twitter.com",
                    InstagramLink = "Instagram.com"
                },
            new Company()
            {
                Name = "Company1",
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
                Photo = "img-4.png",
                FacebookLink = "Facebook.com",
                TwitterLink = "Twitter.com",
                InstagramLink = "Instagram.com"
            },
            new Company()
            {
                Name = "Company1",
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
                Photo = "img-4.png",
                FacebookLink = "Facebook.com",
                TwitterLink = "Twitter.com",
                InstagramLink = "Instagram.com"
            });

            context.Countries.AddOrUpdate(c => c.Id,
                new Country() { Name = "Azerbaijan" },
                new Country() { Name = "Georgia" },
                new Country() { Name = "Russia" }



            );

            context.Jobs.AddOrUpdate(j => j.Id,
                new Job()
                {

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
                    CategoryId = 1,
                    MinSalary = 400,
                    MaxSalary = 700,
                    //Notes = "languages only differ in their grammar.",
                    //Experience = "1 - 2 years"

                },
                new Job()
                {

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
                    CategoryId = 1,
                    //Notes = "languages only differ in their grammar.",
                    //Experience = "1 - 2 years"

                },
                new Job()
                {

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
                    CategoryId = 1,
                    //Notes = "languages only differ in their grammar.",
                    //Experience = "1 - 2 years"

                },
                new Job()
                {

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
                    CategoryId = 1,
                    //Notes = "languages only differ in their grammar.",
                    //Experience = "1 - 2 years"

                }


            );

            context.Clients.AddOrUpdate(c => c.Id,

                new Client() { Photo = "1.png" },
                new Client() { Photo = "1.png" },
                new Client() { Photo = "1.png" }

            );

            context.Employees.AddOrUpdate(e => e.Id,
                new Employee()
                {

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

                    EmployeeId = 1,
                    CompanyId = 1,
                    CreatedAt = DateTime.Now,
                    Text = "Phasellus viverra nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui."

                },
                new CompanyReview()
                {

                    EmployeeId = 2,
                    CompanyId = 2,
                    CreatedAt = DateTime.Now,
                    Text = "Phasellus viverra nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui."

                },
                new CompanyReview()
                {

                    EmployeeId = 2,
                    CompanyId = 3,
                    CreatedAt = DateTime.Now,
                    Text = "Phasellus viverra nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui."

                }

            );
            context.Candidates.AddOrUpdate(c => c.Id,
            new Candidate()
            {

                CountryId = 1,

                Name = "Michael",
                Surname = "Brown",
                Marriage = Marriages.single,
                Password = "22222",
                City = "Baku",
                Phone = "5555555555",
                WebSite = "amsms.com",
                Email = "brown@email.com",
                Photo = "img-4.png",
                Gender = Genders.Male,
                MiddleName = "Brown",
                BirthDate = new DateTime(1998, 12, 12),
                Overview = "Cras dapibus Vivamus elementum semper nisi Aenean vulputate eleifend tellus Aenean leo ligula porttitor eu consequat vitae eleifend ac enim aliquam lorem ante dapibus in viverra quis feugiat a tellus phasellus viverra nulla ut metus variuse laoreet quisque rutrum aenean imperdiet etiam ultricies nisi that is maecenas tempus tini tellus eget condimentum rhoncus sem semper libero sit amet adipiscing sem neque sed ipsum nam quam nunc blandit vel luctus pulvinar hendrerit lorem maecenas nec odio et ante tincidunt tempus donec vitae libero venenatis faucibus nullam quis ante etiam sit amet orci eget eros faucibus tincidunt Duis leo Sed fringilla a mauris sit amet nibh donec sodales sagittis magna vel augue curabitur ullamcorper ultricies nisi nam eget dui etiame rhoncus ut enim as minima veniam quis nostrum exercitationem ullam corporis suscipit laboriosam nisi ut aliquid commodi.",
                AboutUs = "Aliquam erat volutpat Etiam vitae tortor Morbi vestibulum volutpat enim Aliquam nunc Nunc sed turpis sed mollis eros et ultrices tempus mauris ipsum aliquam libero non adipiscing dolor urna a orci Nulla porta dolor. Class aptent taciti sociosqu ad litora torquent per conubia nostra inceptos hymenaeos pellentesque dapibus hendrerit tortor Praesent egestas tristique nibh sed a libero cras us varius donec vitae orci sed dolor rutrum auctor fusce egestas elit eget lorem.",
                Address = "3659 Turkey Pen Road Manhattan, NY 10016",



            });
            context.Skills.AddOrUpdate(s => s.Id,
                new Skill()
                {

                    Name = "Php",
                    CandidateId = 1
                }


                );

            context.BlogCategories.AddOrUpdate(b => b.Id,
                new BlogCategory()
                {
                    Name = "Web Development"
                }

                );

            context.Blogs.AddOrUpdate(b => b.Id,
                new Blog()
                {

                    BlogCategoryId = 1,

                    CreatedAt = DateTime.Now,
                    Author = "Maude J. McDowell",
                    Title = "A small river named Duden flows by their place and supplies regelialia.",
                    Text = "The Big Oxmox advised her not to do so because there were thousands of bad Commas as wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way But nothing the copy said could convince her and s didn’t take long until a few insidious Copy Writers ambushed made her drunk with Longe and Parole and dragged a into their agency where they abused her for their projects again and again. And if hasn’t been rewritten.",
                    FooterText = "It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave."
                },
             new Blog()
             {

                 BlogCategoryId = 1,
                 CreatedAt = DateTime.Now,
                 Author = "Maude J. McDowell",
                 Title = "A small river named Duden flows by their place and supplies regelialia.",
                 Text = "The Big Oxmox advised her not to do so because there were thousands of bad Commas as wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way But nothing the copy said could convince her and s didn’t take long until a few insidious Copy Writers ambushed made her drunk with Longe and Parole and dragged a into their agency where they abused her for their projects again and again. And if hasn’t been rewritten.",
                 FooterText = "It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave."
             }


            );
            context.BlogReviews.AddOrUpdate(b => b.Id,
                new BlogReview()
                {

                    BlogId = 12,
                    CandidateId = 1,

                    CreatedAt = DateTime.Now,
                    Text = "The Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",



                },
                  new BlogReview()
                  {

                      BlogId = 12,
                      CandidateId = 1,

                      CreatedAt = DateTime.Now,
                      Text = "The Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",



                  },
                   new BlogReview()
                   {

                       BlogId = 12,
                       CandidateId = 1,

                       CreatedAt = DateTime.Now,
                       Text = "The Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",



                   }



                 );

            context.Experiences.AddOrUpdate(e => e.Id,
                new Experience()
                {

                    Year = 2,
                    StartDate = new DateTime(2017, 10, 10),
                    EndDate = new DateTime(2018, 10, 10),
                    Position = "Software Engineer",
                    Salary = 500,
                    CandidateId = 1,
                    CompanyId = 1
                },
                new Experience()
                {

                    CandidateId = 1,
                    CompanyId = 1,
                    Salary = 500,
                    StartDate = new DateTime(2017, 10, 19),
                    EndDate = new DateTime(2018, 10, 10),
                    Position = "PHP Developer",
                    Year = 5
                }

                );





            context.Educations.AddOrUpdate(e => e.Id,
            new Education()
            {

                Name = "Bachelor",
                Icon = "school",
                StartDate = new DateTime(2010, 10, 10),
                EndDate = new DateTime(2014, 10, 10),
                University = "Oxford",
                Degree = "Diploma In Management Studies",
                Description = "Suspendisse faucibus et pellentesque egestas lacus ante convallis.",
                CandidateId = 1

            }
            );
            context.Settings.AddOrUpdate(s => s.Id,
                new Setting()
                {
                 Address= "2453 Clinton StreetLittle Rock, AR 72211",
                 Phone = "+1 800 123 45 67",
                 Email = " Support@mail.com",
                 FacebookLink = "Facebook.com",
                 InstagramLink = "Instagram.com",
                 TwitterLink = "Twitter.com",
                 GoogleLink ="Google.com",
                 Logo = "logo-light.png"
                }



                );
            context.Faqs.AddOrUpdate(f => f.Id,
                new Faq()
                {
                    Question = "Ut feugiat eleifend metus ?",
                    Answer = "Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab."
                },
                new Faq()
                {
                    Question = "Ut feugiat eleifend metus ?",
                    Answer = "Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab."
                },
                new Faq()
                {
                    Question = "Ut feugiat eleifend metus ?",
                    Answer = "Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab."
                }


                );
            context.Testimonials.AddOrUpdate(t => t.Id,
 
                new Testimonial()
                {
                    Name = "Company Testimonial",
                    
                    Text = "Maecenas tempus tellus et condimentum that as rhoncus sem quam semper adipiscing sem neque sed ipsum Nam quam nunc blandit at luctus at id lorem maecenas nec odio et ante tincidunt tempus Donec vitae venenatis faucibus quis ante.",
                    CompanyId = 12,

                }
                
                
                );

            context.TestimonialsPhotos.AddOrUpdate(t => t.Id,
                new TestimonialsPhoto() { TestimonialId = 1, Photo = "img-7.jpg"},
                new TestimonialsPhoto() { TestimonialId = 1, Photo = "img-7.jpg"}


                );
            context.Services.AddOrUpdate(s => s.Id,
                new Service()
                {
                    Icon = "account-multiple",
                    Title = "Awesome Support",
                    Text = "Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus."
                },
                new Service()
                {
                    Icon = "account-multiple",
                    Title = "Awesome Support",
                    Text = "Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus."
                },
                new Service()
                {
                    Icon = "account-multiple",
                    Title = "Awesome Support",
                    Text = "Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus."
                },
                new Service()
                {
                    Icon = "account-multiple",
                    Title = "Awesome Support",
                    Text = "Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus."
                }



                );

            context.ServiceInfos.AddOrUpdate(s=>s.Title,
                new ServiceInfo()
                {
                 Title = "Service Information",
                 Text = "Felis quis tortor malesuada pretium pellentesque auctor neque nec urna at sapien ipsum porta, auctor quis euismod aenean viverra rhoncus pede Pellentesque habitant morbi tristique."
                }
                
                );

            context.ServiceInfoPhotos.AddOrUpdate(s => s.Id,
                new ServiceInfoPhoto()
                {
                 Photo = "img-4.png",
                  ServiceId = 1
                },
                new ServiceInfoPhoto()
                {
                 Photo = "img-4.png",
                  ServiceId = 1
                }
                
                
                
                );

            context.Pricings.AddOrUpdate(p => p.Id,
                new Pricing()
                {
                 Name = "FREE",
                 Price = 0,
                 Bandwidth = "1GB",
                 Onlinespace = "50MB",
                 Support = true,
                 Domain = 5,
                 HiddenFees = false

                },
                new Pricing()
                {
                    Name = "FREE",
                    Price = 0,
                    Bandwidth = "1GB",
                    Onlinespace = "50MB",
                    Support = true,
                    Domain = 5,
                    HiddenFees = false

                },
                new Pricing()
                {
                    Name = "FREE",
                    Price = 0,
                    Bandwidth = "1GB",
                    Onlinespace = "50MB",
                    Support = true,
                    Domain = 5,
                    HiddenFees = false

                }


                );
            context.AboutUs.AddOrUpdate(a => a.Id,
                new AboutUs()
                {
                    Text = "Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit.",
                    Title = "Vestibulum ante primis faucibus ?"
                },
                new AboutUs()
                {
                    Text = "Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit.",
                    Title = "Vestibulum ante primis faucibus ?"
                }, new AboutUs()
                {
                    Text = "Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit.",
                    Title = "Vestibulum ante primis faucibus ?"
                }


                );

            context.Tags.AddOrUpdate(t => t.Text,
                new Tag()
                {
                 BlogId = 12,
                  Text = "Tag1"
                },
                new Tag()
                {
                    BlogId = 12,
                    Text = "Tag1"
                },
                new Tag()
                {
                    BlogId = 12,
                    Text = "Tag1"
                }
                );


            


























        }
    }
}
