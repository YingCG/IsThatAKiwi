using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConerDairy
{
    public partial class Form1 : Form
    {
        int productId = 1;
        Store cornerDairy = new Store();
        BindingSource productsBindingSource = new BindingSource();
        BindingSource shoppingBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("successfully add a product to the store");
          
            for (int i = 0; i < int.Parse(txt_quantity.Text); i++)
            {
                Product snack = new Product(productId, txt_product.Text, int.Parse(txt_quantity.Text), decimal.Parse(txt_price.Text));
                cornerDairy.ProductList.Add(snack);
                productId++;
            }
            productsBindingSource.ResetBindings(false);
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            Product selected = (Product)list_Inventory.SelectedItem;
            cornerDairy.ShoppingList.Add(selected);
            cornerDairy.ProductList.Remove(selected);

            shoppingBindingSource.ResetBindings(false);
            productsBindingSource.ResetBindings(false);
            decimal total = cornerDairy.Checkout();
            lbl_chekout.Text = "$" + total.ToString();
        }

       

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal checkout = cornerDairy.Checkout();
            lbl_chekout.Text = checkout.ToString();
            shoppingBindingSource.ResetBindings(false);
            productsBindingSource.ResetBindings(false);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Product removeItem = (Product)list_cart.SelectedItem;
            cornerDairy.ShoppingList.Remove(removeItem);
            cornerDairy.ProductList.Add(removeItem);

            shoppingBindingSource.ResetBindings(false);
            productsBindingSource.ResetBindings(false);

            decimal total = cornerDairy.Checkout();
            lbl_chekout.Text = "$" + total.ToString();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            decimal totalPrice = cornerDairy.Checkout();
            decimal deliveryFees = 8.99M;
            if (radio_Pickup.Checked)
                btn_total.Text = totalPrice.ToString();
            if (radio_Delivery.Checked)
                btn_total.Text = (totalPrice + deliveryFees).ToString();
            
            cornerDairy.ShoppingList.Clear();

            shoppingBindingSource.ResetBindings(false);
            productsBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsBindingSource.DataSource = cornerDairy.ProductList;
            list_Inventory.DataSource = productsBindingSource;
            list_Inventory.DisplayMember = ToString();

            shoppingBindingSource.DataSource = cornerDairy.ShoppingList;
            list_cart.DataSource = shoppingBindingSource;
            list_cart.DisplayMember = ToString();
        }

    }
}
