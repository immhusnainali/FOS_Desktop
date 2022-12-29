using FOS.DL;
using FOS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.BL
{
    class Modrator_BL
    {
         Modrator_DL _modratorDL;

        public Modrator_BL()
        {
            _modratorDL = new Modrator_DL();
        }
        public bool addItemin_BL(Item_DTO additem_dto)
        {
            return (_modratorDL.addFoodin_DB(additem_dto));
        }
        public DataTable getMenuitems_BL()
        {
            return _modratorDL.getMenuItemsfrom_db();
        }
        public DataTable getorderlistINBL()
        {
            return _modratorDL.getorderlistINDL();
        }
        public bool addtotalbillInBL(GenrateOrderBill_DTO gob_dto)
        {
            return _modratorDL.addtotalbillInDB(gob_dto);
        }
        public void updateiteminBL(Item_DTO updt_dto)
        {
            _modratorDL.updateitemINDL(updt_dto);
        }
        public void deleteiteminBL(Item_DTO del_dto)
        {
            _modratorDL.delectitemINDL(del_dto);
        }
        public Item_DTO checkItem(string text)
        {
            return _modratorDL.checkItem(text);
        }
        public DataTable gethistoryfrom_Db(string userid)
        {
            return _modratorDL.gethistoryin_DL(userid);
        }
    }
}
