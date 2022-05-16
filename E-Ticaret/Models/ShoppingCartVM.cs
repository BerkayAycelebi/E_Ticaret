using System.Collections.Generic;

namespace E_Ticaret.Models
{
    public class ShoppingCartVM
    {

        public IEnumerable<ShoppingCart> ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
