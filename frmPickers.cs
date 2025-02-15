using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyTekProjectSQL
{
    public static class PickItem    {

          public static System.Windows.Forms.DialogResult Show(int searchby,string lkstr,
                   ref long iditem, ref String itemdescription,ref String itemcode, ref String itemuom,
                   ref float itemlat_cost, ref String itemuompack, ref int itempackfactor,
                   ref float vatpercent, ref float srp1, ref float srp2, ref float srp3,
                   ref float srp4, ref float srp5)
        
           
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;

            using (frmPickItem PickItemfrm = new frmPickItem(searchby,lkstr))
            {
                  
                dlgResult = PickItemfrm.ShowDialog();

                if (dlgResult == System.Windows.Forms.DialogResult.OK)
                {
                    iditem = PickItemfrm.IdItem;
                    itemdescription = PickItemfrm.ItemDescription;
                    itemcode = PickItemfrm.ItemCode;
                    itemuom = PickItemfrm.ItemUom;
                    itemlat_cost = PickItemfrm.ItemLat_Cost;
                    itemuompack = PickItemfrm.ItemUomPack;
                    itempackfactor = PickItemfrm.ItemPackFactor;
                    vatpercent = PickItemfrm.VatPercent;
                    srp1 = PickItemfrm.Srp1;
                    srp2 = PickItemfrm.Srp2;
                    srp3 = PickItemfrm.Srp3;
                    srp4 = PickItemfrm.Srp4;
                    srp5 = PickItemfrm.Srp5;

                }
                else
                {
                    iditem = 0;
                    itemdescription = "";
                    itemuom = "";
                    itemlat_cost = 0;
                    itemuompack = "";
                    itempackfactor = 0;
                    vatpercent = 0;
                    srp1 = 0;
                    srp2 = 0;
                    srp3 = 0;
                    srp4 = 0;
                    srp5 = 0;


                }
            }
            return dlgResult;

        }

    }

    public static class PickDirectory
    {

        public static System.Windows.Forms.DialogResult Show(int dtype,String dtitle, 
                 ref long iddirectory,
                 ref String name)


        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;

            using (frmSearchDirectory SearchDirectoryfrm = new frmSearchDirectory(dtype,dtitle))
            {

                dlgResult = SearchDirectoryfrm.ShowDialog();

                if (dlgResult == System.Windows.Forms.DialogResult.OK)
                {
                    iddirectory = SearchDirectoryfrm.IdDirectory;
                    name = SearchDirectoryfrm.NameDirectory;
                }
                else
                {
                    iddirectory = 0;
                    name = "";
                   
                }
            }
            return dlgResult;

        }

    }
}
