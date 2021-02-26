using Stamps.Data;
using Stamps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stamps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationDbContext dbContext;
        User NewUser = new User();
        Stamp NewStamp = new Stamp();

        public MainWindow(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            InitializeDb.Initialize(dbContext);
            GetUsers();
            GetStamps();

            AddNewUsersGrid.DataContext = NewUser;
            AddNewStampGrid.DataContext = NewStamp;
        }

        #region Users
        // getting users 
        private void GetUsers()
        {
            UserDG.ItemsSource = dbContext.Users.ToList();
        }
          // adding a new user to database 
        private void AddUser(object s, RoutedEventArgs e)
        {
            dbContext.Users.Add(NewUser);
            dbContext.SaveChanges();
            GetUsers();
            NewUser = new User();
            AddNewUsersGrid.DataContext = NewUser;
        }
        // selecting and editing a user 
        User selectedUser = new User();
        private void UpdateUserForEdit(object s, RoutedEventArgs e)
        {
            selectedUser = (s as FrameworkElement).DataContext as User;
            UpdateUserGrid.DataContext = selectedUser;
        }

        private void UpdateUser(object s, RoutedEventArgs e)
        {
            dbContext.Update(selectedUser);
            dbContext.SaveChanges();
            GetUsers();
        }
        // deleting user 
        private void DeleteUser(object s, RoutedEventArgs e)
        {
            var userToBeDeleted = (s as FrameworkElement).DataContext as User;
            dbContext.Users.Remove(userToBeDeleted);
            dbContext.SaveChanges();
            GetUsers();
        }

        #endregion

        #region STAMP
        /// <summary>
        ///  CRUD operations on stamp
        /// </summary>
        
        //Read
        private void GetStamps()
        {
            StampDG.ItemsSource = dbContext.Stamps.ToList();
        }
        //Create
        private void AddStamp(object s, RoutedEventArgs e)
        {
            dbContext.Stamps.Add(NewStamp);
            dbContext.SaveChanges();
            GetStamps();
            NewStamp = new Stamp();
            AddNewStampGrid.DataContext = NewStamp;
        }
        //Update
        Stamp selectedStamp = new Stamp();
        private void UpdateStampForEdit(object s, RoutedEventArgs e)
        {
            selectedStamp = (s as FrameworkElement).DataContext as Stamp;
            UpdateStampGrid.DataContext = selectedStamp;
        }

        private void UpdateStamp(object s, RoutedEventArgs e)
        {
            dbContext.Update(selectedStamp);
            dbContext.SaveChanges();
            GetStamps();
        }
        //Delete
        private void DeleteStamp(object s, RoutedEventArgs e)
        {
            var stampToBeDeleted = (s as FrameworkElement).DataContext as Stamp;
            dbContext.Stamps.Remove(stampToBeDeleted);
            dbContext.SaveChanges();
            GetStamps();
        }

        #endregion
    }
}
