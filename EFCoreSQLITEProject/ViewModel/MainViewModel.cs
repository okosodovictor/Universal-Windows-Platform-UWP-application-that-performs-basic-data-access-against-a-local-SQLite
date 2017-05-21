using EFCoreSQLITEProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
namespace EFCoreSQLITEProject.ViewModel
{
    [ImplementPropertyChanged]
    public class MainViewModel
    {
        public ObservableCollection<CategoryViewModel> Categories { get; set; }

        public void GetData()
        {
            using (var db = new EntityContext())
            {
                var itemList = db.Categories.ToList();
                var categoryViewModel = itemList.Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Count = x.Count,
                    IconUrl = x.IconUrl
                }).ToList();
                Categories = new ObservableCollection<CategoryViewModel>(categoryViewModel);
            }
        }
    }
}
