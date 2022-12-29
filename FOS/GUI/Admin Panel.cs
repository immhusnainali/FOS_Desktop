using FOS.BL;
using FOS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOS.GUI
{
    public partial class Admin_GUI : Form
    {
        Modrator_BL _modratorBL;
        Item_DTO _additemDTO;
        User_DTO userDTO;
        public Admin_GUI(User_DTO ud)
        {
            InitializeComponent();

            _additemDTO = new Item_DTO();
            _modratorBL = new Modrator_BL();
            userDTO = ud;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_itemname.Text == "" || txt_itemPrice.Text == "" || txt_itemtype.Text == ""))
                {
                    _additemDTO.Name = txt_itemname.Text;
                    _additemDTO.Price = txt_itemPrice.Text;
                    _additemDTO.Type = txt_itemtype.Text;
                    if (_modratorBL.addItemin_BL(_additemDTO))
                    {
                        MessageBox.Show("Your Item is Successfully added!", "Notify!", MessageBoxButtons.OK);
                        txt_itemname.Text = "";
                        txt_itemPrice.Text = "";
                        txt_itemtype.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Please Input all feilds", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dish With Same name already Exsists", "Error", MessageBoxButtons.OK);
            }
        }

        private void Admin_GUI_Load(object sender, EventArgs e)
        {
            this.Size = new Size(914,539);
            try
            {

                gdv_orderlist.DataSource = _modratorBL.getorderlistINBL();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No Orders are Available Due to " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Item_DTO itemDTO = new Item_DTO();
            if (!(txt_updtitemname.Text == ""))
            {
                itemDTO.Name=txt_updtitemname.Text.ToString();
                itemDTO.Type=txt_updateitemtype.Text.ToString();
                itemDTO.Price = txt_updateprice.Text.ToString();
                try
                {
                    _modratorBL.updateiteminBL(itemDTO);
                    MessageBox.Show("Your Items are updated Successfully", "Notify!", MessageBoxButtons.OK);
                    txt_updtitemname.Clear();
                    txt_updateitemtype.Clear();
                    txt_updateprice.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Record not update due to "+ ex.Message);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!(txt_updtitemname.Text == ""))
            {
                try
                {
                    _additemDTO = _modratorBL.checkItem(txt_updtitemname.Text);
                    if (_additemDTO != null)
                    {
                        txt_updtitemname.Text=_additemDTO.Name;
                        txt_updateitemtype.Text = _additemDTO.Type;
                        txt_updateprice.Text = _additemDTO.Price;
                        
                    }
                    else
                    {
                        MessageBox.Show(txt_updtitemname.Text + " is not in Menu.", "Warning!!", MessageBoxButtons.OK);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Record not found due to "+ex.Message);
                }

            }
        }

        private void btn_searchfordelete_Click(object sender, EventArgs e)
        {
            if (!(txt_itemnametodelete.Text == ""))
            {
                try
                {
                    _additemDTO = _modratorBL.checkItem(txt_itemnametodelete.Text);
                    if (_additemDTO != null)
                    {
                        txt_itemnametodelete.Text = _additemDTO.Name;
                        txt_itemtypetodelete.Text = _additemDTO.Type;
                        txt_itempricetodelete.Text = _additemDTO.Price;

                    }
                    else
                    {
                        MessageBox.Show(txt_itemnametodelete.Text + " is not in Menu.", "Warning!!", MessageBoxButtons.OK);
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Record not found due to "+ex.Message);
                }

            }
        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            Item_DTO itemDTO = new Item_DTO();
            if (!(txt_itemnametodelete.Text == ""))
            {
                itemDTO.Name = txt_itemnametodelete.Text.ToString();
                try
                {
                    _modratorBL.deleteiteminBL(itemDTO);
                    MessageBox.Show("Your "+itemDTO.Name+" is Successfully Deleted!", "Info", MessageBoxButtons.OK);
                    txt_itemnametodelete.Clear();
                    txt_itemtypetodelete.Clear();
                    txt_itempricetodelete.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Record not update due to "+ex.Message);
                }
            }
        }

        private void txt_updateitemtype_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_itemnametodelete.Clear();
            txt_itemtypetodelete.Clear();
            txt_itempricetodelete.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_updtitemname.Clear();
            txt_updateitemtype.Clear();
            txt_updateprice.Clear();
        }
    }
}
