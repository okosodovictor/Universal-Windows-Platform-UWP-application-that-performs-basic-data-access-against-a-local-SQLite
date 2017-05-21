using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSQLITEProject.Model
{
    [ImplementPropertyChanged]
    public class Category
    {
        public Category()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string IconUrl { get; set; }
    }
}
