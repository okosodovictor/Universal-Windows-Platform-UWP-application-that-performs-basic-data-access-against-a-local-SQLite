using EFCoreSQLITEProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EFCoreSQLITEProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddCategory : Page
    {
        public AddCategory()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            progress1.IsActive = true;
            progress1.Visibility = Visibility.Visible;
            Task.Delay(3000);
            using (var db = new EntityContext())
            {
                var category = new Category();
                category.Name = Name.Text;
                int result = 0;
                int.TryParse(Count.Text, out result);
                category.Count = result;
                category.IconUrl = IconUrl.Text;
                db.Categories.Add(category);
                db.SaveChanges();
                ClearPage();
                progress1.IsActive = false;
                progress1.Visibility = Visibility.Collapsed;           
            }
        }
        private void ClearPage()
        {
            Name.Text = string.Empty;
            IconUrl.Text = string.Empty;
            Count.Text = string.Empty;
        }

        private void SymbolIcon_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }
    }
}
