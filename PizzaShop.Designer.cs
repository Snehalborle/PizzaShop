namespace Pizzashop
{
    partial class PizzaShop
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
            this.lblPizzaShopTitle = new System.Windows.Forms.Label();
            this.lblSelectPizza = new System.Windows.Forms.Label();
            this.cbSelectPizza = new System.Windows.Forms.ComboBox();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.lblMessageToUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPizzaShopTitle
            // 
            this.lblPizzaShopTitle.AutoSize = true;
            this.lblPizzaShopTitle.Location = new System.Drawing.Point(294, 40);
            this.lblPizzaShopTitle.Name = "lblPizzaShopTitle";
            this.lblPizzaShopTitle.Size = new System.Drawing.Size(89, 20);
            this.lblPizzaShopTitle.TabIndex = 0;
            this.lblPizzaShopTitle.Text = "Pizza Shop";
            // 
            // lblSelectPizza
            // 
            this.lblSelectPizza.AutoSize = true;
            this.lblSelectPizza.Location = new System.Drawing.Point(17, 104);
            this.lblSelectPizza.Name = "lblSelectPizza";
            this.lblSelectPizza.Size = new System.Drawing.Size(96, 20);
            this.lblSelectPizza.TabIndex = 1;
            this.lblSelectPizza.Text = "Select Pizza";
            // 
            // cbSelectPizza
            // 
            this.cbSelectPizza.FormattingEnabled = true;
            this.cbSelectPizza.Location = new System.Drawing.Point(167, 104);
            this.cbSelectPizza.Name = "cbSelectPizza";
            this.cbSelectPizza.Size = new System.Drawing.Size(228, 28);
            this.cbSelectPizza.TabIndex = 3;
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(167, 159);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(228, 35);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // lblMessageToUser
            // 
            this.lblMessageToUser.AutoSize = true;
            this.lblMessageToUser.Location = new System.Drawing.Point(174, 246);
            this.lblMessageToUser.Name = "lblMessageToUser";
            this.lblMessageToUser.Size = new System.Drawing.Size(184, 20);
            this.lblMessageToUser.TabIndex = 5;
            this.lblMessageToUser.Text = "Enjoy our Delicious pizza";
            // 
            // PizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessageToUser);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.cbSelectPizza);
            this.Controls.Add(this.lblSelectPizza);
            this.Controls.Add(this.lblPizzaShopTitle);
            this.Name = "PizzaShop";
            this.Text = "PizzaShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzaShopTitle;
        private System.Windows.Forms.Label lblSelectPizza;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Label lblMessageToUser;
        private System.Windows.Forms.ComboBox cbSelectPizza;
    }
}