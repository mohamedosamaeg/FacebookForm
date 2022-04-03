using facebook.Const;
using facebook.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using facebook.Services;
using facebook.Repository;

namespace facebook.ConsoleServices
{
    public static class ConsoleService
    {

        public static StoriesService StoriesService { get; set; }


        public static void UserDealing()
        {
            Console.WriteLine($"Welcome {ProjectDetails.ProjectName}\n" +
                $"{ProjectDetails.Version}\n" +
                $"{ProjectDetails.ProjectDescription}\n\n");
            SeedData(UserRoleService);
            Console.WriteLine("Are you current user? true or false");
            bool IsCurrent = Convert.ToBoolean(Console.ReadLine());
            User user = new User();
            if (IsCurrent)
            {
                user = LoginForm();
                if (user.userRole.Name == Admin.AdminRole)
                {
                    AdminUserDealing(user);
                }
                else
                {
                    GeneralUserDealing(user, stories: StoriesService);
                }
            }
            else
            {
                user = RegisterUser();
            }
        }

        private static void GeneralUserDealing(User user, StoriesService stories)
        {
            throw new NotImplementedException();
        }

        
        private static void SeedData(UserRoleService userRoleService)
        {
            GroupsService groupsService = new GroupsService();
            UserService userService = new UserService();

            User user = new User();
            UserRoleService userRoleService = new UserRoleService();

            UserRole UserAmin = new UserRole();
            UserAmin.Name = Admin.AdminRole;
            userRoleService.Add(UserAmin);

            UserRole GeneralRole = new UserRole();
            GeneralRole.Name = "GeneralRole";
            userRoleService.Add(GeneralRole);

            if (!userService.IsExist(Admin.AdminName, Admin.AdminPassword))
            {
                user.UserName = Admin.AdminName;
                user.FirstName = Admin.AdminName;
                user.LastName = Admin.AdminName;
                user.Password = Admin.AdminPassword;
                user.ConfirmPassword = Admin.AdminPassword;
                user.Email = Admin.AdminEmail;
                user.UserRoleId = 1;
                userService.Add(user);
            }
            GroupsService Groups = new GroupsService();
            Groups groups = new Groups();
        
            groupsService.Add(groups);
        }
        #region User
        private static User RegisterUser()
        {
            UserService userService = new UserService();
            User user = new User();
            for (; ; )
            {
                Console.WriteLine("please fill register form\n");

                #region Register form
                Console.WriteLine("Insert your first name");
                user.FirstName = Console.ReadLine();
                Console.WriteLine("Insert your last name");
                user.LastName = Console.ReadLine();
                Console.WriteLine("Insert your email");
                user.Email = Console.ReadLine();
                Console.WriteLine("Insert your username");
                user.UserName = Console.ReadLine();
                Console.WriteLine("Insert your password");
                user.Password = Console.ReadLine();
                Console.WriteLine("Please Confirm password");
                user.ConfirmPassword = Console.ReadLine();
                user.UserRoleId = 2;
                #endregion
                userService.Add(user);
                user = userService.LogIn(user.UserName, user.Password);

       
                #endregion
                userService.Add(user);
                user = userService.LogIn(user.UserName, user.Password);
                if (user == null)
                {
                    Console.WriteLine("Some thing is wrong please try again");
                }
                else
                {
                    Console.WriteLine($"you has been registered successfuly{user.FullName}");
                    break;
                }
            }
            return user;
        }
        private static void GeneralUserDealing(User user, Stories stories)
        {
            for (; ;)
            {
                if (user == null)
                {

                }
                else
                {
                    Console.WriteLine($"Hello {user.FullName}\n");
                    Console.WriteLine("Please insert number of action\n" +
                        "1. view products\n" +
                        "2. update profile\n" +
                        "3. view card");
                    int ActionNumber = Convert.ToInt32(Console.ReadLine());
                    switch (ActionNumber)
                    {
                        case 1:
                            ViewStories(stories);
                            break;
                        case 2:
                            UpdateProfile(user);
                            break;
                        
                        default:
                            break;
                    }

                }
            }
        }
        private static User LoginForm()
        {
            UserService userService = new UserService();
            User user;
            Console.WriteLine("Insert your username");
            string Username = Console.ReadLine();
            Console.WriteLine("Insert your password");
            string Password = Console.ReadLine();

            user = userService.LogIn(Username, Password);
            return user;
        }
        private static void AdminUserDealing(User user)
        {

            Console.WriteLine($"Wellcome {user.FullName}!");
            for (; ; )
            {
                Console.WriteLine("Please choose number of action\n-----\n" +
                    "1.View analatix\n" +
                    "2.Add Warning\n" +
                    "3. Seen Stories\n" +
                    "4.Play Story\n" +
                    "5.Close actions");
                int Action = Convert.ToInt16(Console.ReadLine());

                switch (Action)
                {
                    case 1:
                        Viewanalatix();
                        break;
                    case 2:
                        Warning();
                        break;
                    case 3:
                        SeenStories();
                        break;
                    case 4:
                        PlayStory();
                        break;
                    default:
                        break;
                }
                if (Action == 5)
                {
                    break;
                }
            }
        }

        private static void Viewanalatix()
        {
            throw new NotImplementedException();
        }

        private static void ViewProfile(User user)
        {
            Console.WriteLine($"first name {user.FirstName}\n" +
                $"last name {user.LastName}\n" +
                $"user name {user.UserName}\n" +
                $"birthday {user.BirthDay}\n" +
                $"Email {user.Email}\n");
        }
        private static void UpdateProfile(User user)
        {
            ViewProfile(user);
        }

        
        
        private static void ViewStories(Stories Stories)
        {
            StoriesService StoriesService = new StoriesService();
            List<Stories> stories = StoriesService.Get();
            NewMethod(stories);

            static void NewMethod(List<Stories> stories)
            {
                foreach (var Stories in stories)
                {
                    
                }
            }
        }
        private static void PlayStory()
        {
            Console.WriteLine("Insert product id ");
            int id = Convert.ToInt16(Console.ReadLine());
            
        }

        private static void SeenStories()
        {
            Console.WriteLine("Insert Stories ");
            int Stories = Convert.ToInt16(Console.ReadLine());
            StoriesService storiesService = new StoriesService();
            IStoriesRepository StoriesService = (IStoriesRepository)storiesService;
            
        }

        private static void Warning()
        {
            Warning Warning = Warning();
            WarningService = new StoriesService();
            WarningService.Add();

        }

        

        private static void ShowStories()
        {
            StoriesService productService = new StoriesService();
            List<Stories> StoriesService = productService.Get();
            Console.WriteLine("All Stories\n_______________\n");
            foreach (Stories Stories in StoriesService)
            {
                
            }
             
       
            }

        

        
        }
        
    }



    
    




