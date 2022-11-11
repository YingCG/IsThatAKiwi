
namespace ConerDairy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shipping_method = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radio_Delivery = new System.Windows.Forms.RadioButton();
            this.radio_Pickup = new System.Windows.Forms.RadioButton();
            this.groupBox_admin = new System.Windows.Forms.GroupBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_store = new System.Windows.Forms.GroupBox();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.list_Inventory = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_chekout = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_cart = new System.Windows.Forms.ListBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.shipping_method.SuspendLayout();
            this.groupBox_admin.SuspendLayout();
            this.groupBox_store.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipping_method
            // 
            this.shipping_method.BackColor = System.Drawing.Color.White;
            this.shipping_method.Controls.Add(this.label5);
            this.shipping_method.Controls.Add(this.radio_Delivery);
            this.shipping_method.Controls.Add(this.radio_Pickup);
            this.shipping_method.Location = new System.Drawing.Point(516, 309);
            this.shipping_method.Name = "shipping_method";
            this.shipping_method.Size = new System.Drawing.Size(261, 62);
            this.shipping_method.TabIndex = 0;
            this.shipping_method.TabStop = false;
            this.shipping_method.Text = "Shipping Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "$8.99";
            // 
            // radio_Delivery
            // 
            this.radio_Delivery.AutoSize = true;
            this.radio_Delivery.Location = new System.Drawing.Point(143, 33);
            this.radio_Delivery.Name = "radio_Delivery";
            this.radio_Delivery.Size = new System.Drawing.Size(63, 17);
            this.radio_Delivery.TabIndex = 1;
            this.radio_Delivery.TabStop = true;
            this.radio_Delivery.Text = "Delivery";
            this.radio_Delivery.UseVisualStyleBackColor = true;
            // 
            // radio_Pickup
            // 
            this.radio_Pickup.AutoSize = true;
            this.radio_Pickup.Location = new System.Drawing.Point(17, 31);
            this.radio_Pickup.Name = "radio_Pickup";
            this.radio_Pickup.Size = new System.Drawing.Size(79, 17);
            this.radio_Pickup.TabIndex = 0;
            this.radio_Pickup.TabStop = true;
            this.radio_Pickup.Text = "Self-Pickup";
            this.radio_Pickup.UseVisualStyleBackColor = true;
            // 
            // groupBox_admin
            // 
            this.groupBox_admin.BackColor = System.Drawing.Color.White;
            this.groupBox_admin.Controls.Add(this.txt_quantity);
            this.groupBox_admin.Controls.Add(this.label4);
            this.groupBox_admin.Controls.Add(this.btn_create);
            this.groupBox_admin.Controls.Add(this.txt_price);
            this.groupBox_admin.Controls.Add(this.label2);
            this.groupBox_admin.Controls.Add(this.txt_product);
            this.groupBox_admin.Controls.Add(this.label1);
            this.groupBox_admin.Location = new System.Drawing.Point(25, 26);
            this.groupBox_admin.Name = "groupBox_admin";
            this.groupBox_admin.Size = new System.Drawing.Size(189, 385);
            this.groupBox_admin.TabIndex = 1;
            this.groupBox_admin.TabStop = false;
            this.groupBox_admin.Text = "Admin";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(66, 56);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(113, 20);
            this.txt_quantity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantities : ";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(66, 337);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Add to Store";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(66, 82);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(113, 20);
            this.txt_price.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price : ";
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(66, 28);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(113, 20);
            this.txt_product.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product : ";
            // 
            // groupBox_store
            // 
            this.groupBox_store.BackColor = System.Drawing.Color.White;
            this.groupBox_store.Controls.Add(this.btn_addToCart);
            this.groupBox_store.Controls.Add(this.list_Inventory);
            this.groupBox_store.Location = new System.Drawing.Point(233, 26);
            this.groupBox_store.Name = "groupBox_store";
            this.groupBox_store.Size = new System.Drawing.Size(267, 385);
            this.groupBox_store.TabIndex = 2;
            this.groupBox_store.TabStop = false;
            this.groupBox_store.Text = "Store";
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Location = new System.Drawing.Point(55, 337);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(75, 23);
            this.btn_addToCart.TabIndex = 5;
            this.btn_addToCart.Text = "Add to Cart";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // list_Inventory
            // 
            this.list_Inventory.BackColor = System.Drawing.Color.White;
            this.list_Inventory.FormattingEnabled = true;
            this.list_Inventory.Location = new System.Drawing.Point(12, 19);
            this.list_Inventory.Name = "list_Inventory";
            this.list_Inventory.Size = new System.Drawing.Size(242, 303);
            this.list_Inventory.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_remove);
            this.groupBox1.Controls.Add(this.lbl_chekout);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_checkout);
            this.groupBox1.Controls.Add(this.list_cart);
            this.groupBox1.Location = new System.Drawing.Point(516, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(17, 187);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(96, 23);
            this.btn_remove.TabIndex = 8;
            this.btn_remove.Text = "Remove Item";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_chekout
            // 
            this.lbl_chekout.AutoSize = true;
            this.lbl_chekout.Location = new System.Drawing.Point(211, 233);
            this.lbl_chekout.Name = "lbl_chekout";
            this.lbl_chekout.Size = new System.Drawing.Size(34, 13);
            this.lbl_chekout.TabIndex = 7;
            this.lbl_chekout.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price : ";
            // 
            // list_cart
            // 
            this.list_cart.BackColor = System.Drawing.Color.White;
            this.list_cart.FormattingEnabled = true;
            this.list_cart.Location = new System.Drawing.Point(15, 21);
            this.list_cart.Name = "list_cart";
            this.list_cart.Size = new System.Drawing.Size(231, 160);
            this.list_cart.TabIndex = 1;
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.LightCoral;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.Location = new System.Drawing.Point(651, 379);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(126, 32);
            this.btn_buy.TabIndex = 4;
            this.btn_buy.Text = "Buy Now";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // btn_total
            // 
            this.btn_total.AutoSize = true;
            this.btn_total.ForeColor = System.Drawing.Color.White;
            this.btn_total.Location = new System.Drawing.Point(569, 389);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(34, 13);
            this.btn_total.TabIndex = 10;
            this.btn_total.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(513, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total: ";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(147, 187);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(98, 23);
            this.btn_checkout.TabIndex = 6;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_store);
            this.Controls.Add(this.groupBox_admin);
            this.Controls.Add(this.shipping_method);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.shipping_method.ResumeLayout(false);
            this.shipping_method.PerformLayout();
            this.groupBox_admin.ResumeLayout(false);
            this.groupBox_admin.PerformLayout();
            this.groupBox_store.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox shipping_method;
        private System.Windows.Forms.RadioButton radio_Delivery;
        private System.Windows.Forms.RadioButton radio_Pickup;
        private System.Windows.Forms.GroupBox groupBox_admin;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_store;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.ListBox list_Inventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_chekout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_cart;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label btn_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_checkout;
    }
}

