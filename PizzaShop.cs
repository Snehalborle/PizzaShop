using Pizzashop.Wellknowns;
using System;
using System.Windows.Forms;

namespace Pizzashop
{
    public partial class PizzaShop : Form
    {
        public PizzaShop()
        {
            InitializeComponent(); 
            InitializaPizzaItems();   
        }
        private void InitializaPizzaItems()
        {
            cbSelectPizza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectPizza.Items.Add(PizzaTypeEnum.Margherita);
            cbSelectPizza.Items.Add(PizzaTypeEnum.Hawaiian);
            cbSelectPizza.Items.Add(PizzaTypeEnum.Pepperoni);
        }
 
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
           
            OrderPizza orderPizza = new OrderPizza();
            if (Enum.TryParse(cbSelectPizza.SelectedItem.ToString(), out PizzaTypeEnum selectedPizza))
            {
                lblMessageToUser.Text=orderPizza.Order(selectedPizza);
            }
        }

    }
}
