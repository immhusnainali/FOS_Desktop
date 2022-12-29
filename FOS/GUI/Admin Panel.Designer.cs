namespace FOS.GUI
{
    partial class Admin_GUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.txt_itemtype = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.gdv_orderlist = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_updateitemtype = new System.Windows.Forms.TextBox();
            this.btn_serach = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_updateprice = new System.Windows.Forms.TextBox();
            this.txt_updtitemname = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_itemtypetodelete = new System.Windows.Forms.TextBox();
            this.btn_searchfordelete = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_itempricetodelete = new System.Windows.Forms.TextBox();
            this.txt_itemnametodelete = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_orderlist)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.BackgroundImage = global::FOS.Properties.Resources.OIP__3_;
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_itemPrice);
            this.tabPage1.Controls.Add(this.txt_itemtype);
            this.tabPage1.Controls.Add(this.txt_itemname);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Item";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(210, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(663, 81);
            this.label10.TabIndex = 8;
            this.label10.Text = "ADD ITEMS IN MENU";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(531, 345);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 77);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(330, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(330, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(314, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Name";
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_itemPrice.Location = new System.Drawing.Point(440, 276);
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(241, 27);
            this.txt_itemPrice.TabIndex = 2;
            // 
            // txt_itemtype
            // 
            this.txt_itemtype.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_itemtype.Location = new System.Drawing.Point(440, 229);
            this.txt_itemtype.Name = "txt_itemtype";
            this.txt_itemtype.Size = new System.Drawing.Size(241, 27);
            this.txt_itemtype.TabIndex = 0;
            // 
            // txt_itemname
            // 
            this.txt_itemname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_itemname.Location = new System.Drawing.Point(440, 183);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(241, 27);
            this.txt_itemname.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::FOS.Properties.Resources.OIP__2_;
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.gdv_orderlist);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(8, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(452, 62);
            this.label11.TabIndex = 1;
            this.label11.Text = "VIEW ALL ORDERS";
            // 
            // gdv_orderlist
            // 
            this.gdv_orderlist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gdv_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_orderlist.Location = new System.Drawing.Point(2, 77);
            this.gdv_orderlist.Name = "gdv_orderlist";
            this.gdv_orderlist.RowHeadersWidth = 51;
            this.gdv_orderlist.RowTemplate.Height = 29;
            this.gdv_orderlist.Size = new System.Drawing.Size(1022, 557);
            this.gdv_orderlist.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.BackgroundImage = global::FOS.Properties.Resources.OIP;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.txt_updateitemtype);
            this.tabPage3.Controls.Add(this.btn_serach);
            this.tabPage3.Controls.Add(this.btn_update);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txt_updateprice);
            this.tabPage3.Controls.Add(this.txt_updtitemname);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1023, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Items";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(339, 391);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 69);
            this.button2.TabIndex = 16;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_updateitemtype
            // 
            this.txt_updateitemtype.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_updateitemtype.Location = new System.Drawing.Point(368, 219);
            this.txt_updateitemtype.Name = "txt_updateitemtype";
            this.txt_updateitemtype.Size = new System.Drawing.Size(241, 27);
            this.txt_updateitemtype.TabIndex = 15;
            this.txt_updateitemtype.TextChanged += new System.EventHandler(this.txt_updateitemtype_TextChanged);
            // 
            // btn_serach
            // 
            this.btn_serach.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_serach.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_serach.Location = new System.Drawing.Point(626, 88);
            this.btn_serach.Name = "btn_serach";
            this.btn_serach.Size = new System.Drawing.Size(130, 77);
            this.btn_serach.TabIndex = 14;
            this.btn_serach.Text = "Search";
            this.btn_serach.UseVisualStyleBackColor = false;
            this.btn_serach.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.Location = new System.Drawing.Point(497, 391);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 69);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(182, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Update Item Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(183, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Update Item Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(182, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Update Item Name";
            // 
            // txt_updateprice
            // 
            this.txt_updateprice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_updateprice.Location = new System.Drawing.Point(368, 299);
            this.txt_updateprice.Name = "txt_updateprice";
            this.txt_updateprice.Size = new System.Drawing.Size(241, 27);
            this.txt_updateprice.TabIndex = 9;
            // 
            // txt_updtitemname
            // 
            this.txt_updtitemname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_updtitemname.Location = new System.Drawing.Point(368, 135);
            this.txt_updtitemname.Name = "txt_updtitemname";
            this.txt_updtitemname.Size = new System.Drawing.Size(241, 27);
            this.txt_updtitemname.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.BackgroundImage = global::FOS.Properties.Resources.OIP;
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.txt_itemtypetodelete);
            this.tabPage4.Controls.Add(this.btn_searchfordelete);
            this.tabPage4.Controls.Add(this.btn_deleteItem);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txt_itempricetodelete);
            this.tabPage4.Controls.Add(this.txt_itemnametodelete);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1023, 635);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete items";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(327, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 57);
            this.button1.TabIndex = 24;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_itemtypetodelete
            // 
            this.txt_itemtypetodelete.Enabled = false;
            this.txt_itemtypetodelete.Location = new System.Drawing.Point(413, 244);
            this.txt_itemtypetodelete.Name = "txt_itemtypetodelete";
            this.txt_itemtypetodelete.Size = new System.Drawing.Size(255, 27);
            this.txt_itemtypetodelete.TabIndex = 23;
            // 
            // btn_searchfordelete
            // 
            this.btn_searchfordelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_searchfordelete.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_searchfordelete.Location = new System.Drawing.Point(595, 377);
            this.btn_searchfordelete.Name = "btn_searchfordelete";
            this.btn_searchfordelete.Size = new System.Drawing.Size(144, 56);
            this.btn_searchfordelete.TabIndex = 21;
            this.btn_searchfordelete.Text = "Search";
            this.btn_searchfordelete.UseVisualStyleBackColor = false;
            this.btn_searchfordelete.Click += new System.EventHandler(this.btn_searchfordelete_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_deleteItem.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteItem.Location = new System.Drawing.Point(446, 377);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(143, 57);
            this.btn_deleteItem.TabIndex = 22;
            this.btn_deleteItem.Text = "Delete";
            this.btn_deleteItem.UseVisualStyleBackColor = false;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(336, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(337, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Type";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(79, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(333, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Please input dish name to delete";
            // 
            // txt_itempricetodelete
            // 
            this.txt_itempricetodelete.Enabled = false;
            this.txt_itempricetodelete.Location = new System.Drawing.Point(416, 288);
            this.txt_itempricetodelete.Name = "txt_itempricetodelete";
            this.txt_itempricetodelete.Size = new System.Drawing.Size(252, 27);
            this.txt_itempricetodelete.TabIndex = 17;
            // 
            // txt_itemnametodelete
            // 
            this.txt_itemnametodelete.Location = new System.Drawing.Point(416, 193);
            this.txt_itemnametodelete.Name = "txt_itemnametodelete";
            this.txt_itemnametodelete.Size = new System.Drawing.Size(252, 27);
            this.txt_itemnametodelete.TabIndex = 16;
            // 
            // Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin_GUI";
            this.Text = "Admin Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_GUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_orderlist)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TextBox txt_itemPrice;
        private TextBox txt_itemname;
        private TabPage tabPage2;
        private Button btn_add;
        private Label label3;
        private Label label2;

        private DataGridView gdv_orderlist;
        private TabPage tabPage3;
        private Button btn_update;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_updateprice;
        private TextBox txt_updtitemname;
        private TabPage tabPage4;
        private Button btn_serach;
        private TextBox txt_updateitemtype;
        private TextBox txt_itemtypetodelete;
        private Button btn_searchfordelete;
        private Button btn_deleteItem;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_itempricetodelete;
        private TextBox txt_itemnametodelete;
        private TextBox txt_itemtype;
        private Label label10;
        private Label label11;
        private Button button1;
        private Button button2;
        //  private TextBox txt_itemtype;
    }
}