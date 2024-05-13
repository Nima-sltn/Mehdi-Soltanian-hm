namespace Products
{
    partial class Frm_Main
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
            this.btn_ShowProduct = new System.Windows.Forms.Button();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lbl_Products = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_ShowUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ShowProduct
            // 
            this.btn_ShowProduct.Location = new System.Drawing.Point(566, 211);
            this.btn_ShowProduct.Name = "btn_ShowProduct";
            this.btn_ShowProduct.Size = new System.Drawing.Size(82, 34);
            this.btn_ShowProduct.TabIndex = 0;
            this.btn_ShowProduct.TabStop = false;
            this.btn_ShowProduct.Text = "Show";
            this.btn_ShowProduct.UseVisualStyleBackColor = true;
            this.btn_ShowProduct.Click += new System.EventHandler(this.btn_ShowProduct_Click);
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Users.Location = new System.Drawing.Point(195, 133);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(76, 29);
            this.lbl_Users.TabIndex = 1;
            this.lbl_Users.Text = "Users";
            // 
            // lbl_Products
            // 
            this.lbl_Products.AutoSize = true;
            this.lbl_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Products.Location = new System.Drawing.Point(510, 133);
            this.lbl_Products.Name = "lbl_Products";
            this.lbl_Products.Size = new System.Drawing.Size(108, 29);
            this.lbl_Products.TabIndex = 2;
            this.lbl_Products.Text = "Products";
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(478, 211);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(82, 34);
            this.btn_AddProduct.TabIndex = 0;
            this.btn_AddProduct.TabStop = false;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_ShowUser
            // 
            this.btn_ShowUser.Location = new System.Drawing.Point(235, 211);
            this.btn_ShowUser.Name = "btn_ShowUser";
            this.btn_ShowUser.Size = new System.Drawing.Size(82, 34);
            this.btn_ShowUser.TabIndex = 0;
            this.btn_ShowUser.TabStop = false;
            this.btn_ShowUser.Text = "Show";
            this.btn_ShowUser.UseVisualStyleBackColor = true;
            this.btn_ShowUser.Click += new System.EventHandler(this.btn_ShowUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(147, 211);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(82, 34);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.TabStop = false;
            this.btn_AddUser.Text = "Add";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.btn_ShowUser);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.lbl_Products);
            this.Controls.Add(this.lbl_Users);
            this.Controls.Add(this.btn_ShowProduct);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowProduct;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.Label lbl_Products;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_ShowUser;
        private System.Windows.Forms.Button btn_AddUser;
    }
}

