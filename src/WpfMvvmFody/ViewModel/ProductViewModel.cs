using System.Collections.Generic;
using System.Windows.Input;
using WpfMvvmFody.Model;

namespace WpfMvvmFody.ViewModel
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Products = new List<Product>
            {
                new Product {Id = 1, Name = "Pro1", Price = 10},
                new Product {Id = 2, Name = "BAse2", Price = 12}
            };
        }

        public IList<Product> Products { get; set; }

        public ICommand UpdateCommand { get; } = new Updater();
    }
}
