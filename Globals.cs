using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;
using Microsoft.Data.SqlClient;

using System.Configuration;
using System.Reflection;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace RoyTekProjectSQL
{
    static class Globals
    {
        // Connection Strings  
        public static String gdbServerName="";
        public static string gdbUser="";
        public static string gdbPassword="";
        public static string gdbPort="";
        public static string gdbDatabaseName="";

        public static string gsqlConnstr="";
        public static SqlConnection sqlconn= new SqlConnection();

        // directory types
        public static int gtypeBranch = 0;
        public static int gtypeVendor = 1;
        public static int gtypeCustomer = 2;
        public static int gtypeDepartment =3;

        // searchtypes
        public static int SearchbyName = 1;
        public static int SearchbyCode = 2;

        public static String gtitleBranch = "Branch";
        public static String gtitleVendor = "Vendor";
        public static String gtitleCustomer = "Customer";
        public static String gtitleDepartment = "Department";

        // User Profiles
        public static int gIdUser=0;
        public static string gLoginName="";
        public static int gIdBranch = 0;
        public static string gBranchName = "";

        // login result
       // public static int gLoginResult;

        // User has logged in
        public static bool gUserHasLoggedin=false;

        // default values for blank variables
        public static string gdefauldate = "1900/01/01";
        public static string gdefaultgender = "FEMALE";
        public static string gdefaultDateFormat = "MM/dd/yyyy";

        // colors
        public static Color gHighlightText = Color.Blue;
        public static Color gDetailBackgroundColor = SystemColors.ButtonFace;
        public static Color gDialogBackgroundColor = SystemColors.ButtonFace; //Color.OldLace;

        public static Color gFormBackGroundColor =  Color.OldLace;

        // grid colors
        public static Color gGridEvenRowColor =  Color.PapayaWhip;
        public static Color gGridOddRowColor = Color.White;
        public static Color gGridHeaderColor = Color.Tan;
        public static Color gGridFooterColor = Color.Tan;

        public static Color gGridEvenRowColor2 = Color.Beige;
        public static Color gGridOddRowColor2 = Color.White;
        public static Color gGridHeaderColor2 = Color.Khaki;
        public static Color gGridFooterColor2 = Color.Khaki;

        public static String gPurchaseOrderType = "PO";
        public static String gItemRequistionType = "IRS";
        public static String gReceivingType = "RR";
        public static String gPurchaseReturnsType = "PRS";
        public static String gWarehouseIssuanceType = "WIS";
        public static String gInventoryAdjustmentType = "IAS";
        public static String gStockTransferInType = "STI";
        public static String gStockTransferOutType = "STO";
        public static String gCashInvoiceType = "CAI";
        public static String gChargeInvoiceType = "CHI";

        public static String gPurchaseOrderTitle = "Purchase Order";
        public static String gItemRequistionTitle = "Inventory Request Slip";
        public static String gReceivingTitle = "Receiving Report";
        public static String gPurchaseReturnsTitle = "Purchase Return Slip";
        public static String gWarehouseIssuanceTitle = "Warehouse Issuance Slip";
        public static String gInventoryAdjustmentTitle = "Inventory Adjustment Slip";
        public static String gStockTransferInTitle = "Stock Transfer Incoming";
        public static String gStockTransferOutTitle = "Stock Transfer Outgoing";
        public static String gCashInvoiceTitle = "Cash Invoice";
        public static String gChargeInvoiceTitle = "Charge Invoice";


        // Initialize Variables
        public static void glInitializeVariables()
        {
            String sname;// = ConfigurationManager.AppSettings["server"];
            String dname;// = ConfigurationManager.AppSettings["database"];

            sname = "";// ConfigurationManager.AppSettings["server"];
            dname = "";//  ConfigurationManager.AppSettings["database"];

            if (sname != null && sname != "")
                gdbServerName = sname;
            else
                gdbServerName = @"ROY-PCNEW"; // "localhost";

            if (dname != null && dname != "")
                gdbDatabaseName = dname;
            else
                gdbDatabaseName = "inventorydb"; // "ROYTEKDB";

            gdbUser ="DEMOUSER";
            gdbPassword= "Demo123";
            gdbPort= "";
            
            Globals.gsqlConnstr = 
                   @"Server="+Globals.gdbServerName+";"+
                   @"Database="+Globals.gdbDatabaseName+";"+
                  "User ID="+Globals.gdbUser+";"+
                  "Password="+Globals.gdbPassword+";"+
                  "Encrypt = false";
            
            Globals.gUserHasLoggedin = false;

            // set the settings value
            var settings = ConfigurationManager.ConnectionStrings;
            var element = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            var collection = typeof(ConfigurationElementCollection).GetField("bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);

            // element.SetValue(settings, false);
            //collection.SetValue(settings, false);

         //   settings.Clear();
         //   settings.Add(new ConnectionStringSettings("inventorydbConnectionString",
          //      Globals.gsqlConnstr));

            // Repeat above line as necessary

            //collection.SetValue(settings, true);
           // element.SetValue(settings, true);


        }

        // Database Connections

        public static bool glOpenSqlConn()
        {
           
            if (sqlconn==null || sqlconn.State == ConnectionState.Closed)
            {
                bool result = true;

                sqlconn = new SqlConnection(gsqlConnstr);

                try
                {
                    sqlconn.Open();
                }
                catch (Exception ex)
                {
                    csMessageBox.Show("Exception Error:" + ex.Message,
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = false;
                }
                return result;
            }
            return true;
        }
        public static void glCloseSqlConn()
        {
            sqlconn.Close();          
        }

        //this function Converts to Encode Password
        public static string EncodePasswordToBase64(string password)
        {
            return HashPassword(password);
            /*
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
            */
        }
        //this function Converts to Decode Password
        public static string DecodeFrom64(string encodedData)
        {

            //  System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            //   System.Text.Decoder utf8Decode = encoder.GetDecoder();
            //  string todecode_byte = Encoding.UTF8.GetBytes(encodedData);

            // int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            //  char[] decoded_char = new char[charCount];
            //  utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            //  string result = new String(decoded_char);
            string result = "";
            return result;
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Hash the password using PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combine the salt and hash
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convert the bytes to base64 for storage
            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Extract the bytes from the stored hash
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            // Get the salt
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute the hash with the same salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Compare the hash
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

        // setting screen size
        static public void glSetSizeToScreen(this Form form)
        {
            int left = Screen.PrimaryScreen.Bounds.Left;
            int top = Screen.PrimaryScreen.Bounds.Top;
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            form.Location = new Point(left, top);
            form.Size = new Size(width, height);
        }

        static public void glSetSizeToDesktop(this Form form)
        {
            int left = SystemInformation.WorkingArea.Left;
            int top = SystemInformation.WorkingArea.Top;
            int width = SystemInformation.WorkingArea.Width;
            int height = SystemInformation.WorkingArea.Height;
            form.Location = new Point(left, top);
            form.Size = new Size(width, height);
        }

        // Qouting of strings
        static public String glQoutedstr(String str)
        {
            return "\"" + str + "\"";
        }

        static public String glQoutedSinglestr(String str)
        {
            return "'" + str + "'";
        }

        // convert blank dates to default date
        static public String glConvertBlankGender(String genderstr)
        {
            String trimmedstr = genderstr.Trim();
            if (trimmedstr == "")
                return Globals.gdefaultgender;
            else
                return trimmedstr;
        }

        // convert blank dates to default date
        static public DateTime glConvertBlankDate(String dtstr)
        {
            if (dtstr.Trim() == "")
                return Convert.ToDateTime(Globals.gdefauldate);
            else
                return Convert.ToDateTime(dtstr);
        }

        // convert a date into mysql date
        static public String glToMySqlDate(DateTime dt)
        {
            String yy, mm, dd;

            yy = DateTime.Parse(dt.ToString()).Year.ToString();
            mm = DateTime.Parse(dt.ToString()).Month.ToString();
            if (mm.Length<2) mm = "0" + mm;

            dd = DateTime.Parse(dt.ToString()).Day.ToString();
            if (dd.Length < 2) dd = "0" + dd;

            return yy.ToString() + "/" + mm.ToString() + "/" + dd.ToString()+" 00:00:00";

        }
        static public String glToMySqlDateMax(DateTime dt)
        {
            String yy, mm, dd;

            yy = DateTime.Parse(dt.ToString()).Year.ToString();
            mm = DateTime.Parse(dt.ToString()).Month.ToString();
            if (mm.Length < 2) mm = "0" + mm;

            dd = DateTime.Parse(dt.ToString()).Day.ToString();
            if (dd.Length < 2) dd = "0" + dd;

            return yy.ToString() + "/" + mm.ToString() + "/" + dd.ToString() + " 23:59:59";

        }

        // convert a date into mysql datetime
        static public String glToMySqlDateTime(DateTime dt)
        {
            String yy, mm, dd, hh, nn, ss;

            yy = DateTime.Parse(dt.ToString()).Year.ToString();
            mm = DateTime.Parse(dt.ToString()).Month.ToString();
            if (mm.Length < 2) mm = "0" + mm;

            dd = DateTime.Parse(dt.ToString()).Day.ToString();
            if (dd.Length < 2) dd = "0" + dd;

            hh = DateTime.Parse(dt.ToString()).Hour.ToString();
            if (hh.Length < 2) hh = "0" + hh;

            nn = DateTime.Parse(dt.ToString()).Minute.ToString();
            if (nn.Length < 2) nn = "0" + nn;

            ss = DateTime.Parse(dt.ToString()).Second.ToString();
            if (ss.Length < 2) ss = "0" + ss;

            return yy.ToString() + "/" + mm.ToString() + "/" + dd.ToString() + " "
                +hh.ToString()+":"+ nn.ToString()+":"+ss.ToString();

        }

        static public String glMySqlYearBeginDate()
        {
            String yy;
            DateTime dt;
            dt=Globals.glServerDatetime();
           
            yy = DateTime.Parse(dt.ToString()).Year.ToString();
        
            
            return  yy+"/01/01/ 00:00:00";

        }

        static public String glMSSqlYearBeginDate()
        {
            String yy;
            DateTime dt;
            dt = Globals.glServerDatetime();

            yy = DateTime.Parse(dt.ToString()).Year.ToString();


            return "01/01/" + yy +" 00:00:00";

        }

        // convert a date into MSSql date
        static public String glToMSSqlDate(DateTime dt)
        {
            String yy, mm, dd;

            yy = DateTime.Parse(dt.ToString()).Year.ToString();
            mm = DateTime.Parse(dt.ToString()).Month.ToString();
            if (mm.Length < 2) mm = "0" + mm;

            dd = DateTime.Parse(dt.ToString()).Day.ToString();
            if (dd.Length < 2) dd = "0" + dd;

            return dd.ToString() + "/" + mm.ToString() + "/" + yy.ToString() + " 00:00:00";

        }

        static public String glToMSSqlDateMax(DateTime dt)
        {
            String yy, mm, dd;

            yy = DateTime.Parse(dt.ToString()).Year.ToString();
            mm = DateTime.Parse(dt.ToString()).Month.ToString();
            if (mm.Length < 2) mm = "0" + mm;

            dd = DateTime.Parse(dt.ToString()).Day.ToString();
            if (dd.Length < 2) dd = "0" + dd;

            return dd.ToString() + "/" + mm.ToString() + "/" + yy.ToString() + " 23:59:59";

        }


        // convert a date into MSSql datetime
        static public String glToMSSqlDateTime(DateTime dt)
        {
            String yy, mm, dd, hh, nn, ss;

            yy = DateTime.Parse(dt.ToString()).Year.ToString();
            mm = DateTime.Parse(dt.ToString()).Month.ToString();
            if (mm.Length < 2) mm = "0" + mm;

            dd = DateTime.Parse(dt.ToString()).Day.ToString();
            if (dd.Length < 2) dd = "0" + dd;

            hh = DateTime.Parse(dt.ToString()).Hour.ToString();
            if (hh.Length < 2) hh = "0" + hh;

            nn = DateTime.Parse(dt.ToString()).Minute.ToString();
            if (nn.Length < 2) nn = "0" + nn;

            ss = DateTime.Parse(dt.ToString()).Second.ToString();
            if (ss.Length < 2) ss = "0" + ss;

            return dd.ToString() + "/" + mm.ToString() + "/" + yy.ToString() + " "
                + hh.ToString() + ":" + nn.ToString() + ":" + ss.ToString();

        }

        public static DateTime glServerDatetime()
        {
            DateTime resultval;

            resultval = DateTime.Now;

            if (Globals.glOpenSqlConn())
            {

                
                SqlCommand cmd = new SqlCommand("select getdate() ",Globals.sqlconn);
                cmd.Connection = Globals.sqlconn;
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    IDataRecord dr=(IDataRecord) reader;
                    resultval = DateTime.Parse(dr[0].ToString());
                }
                reader.Close();


            }

            Globals.glCloseSqlConn();
            return resultval;
        }


        public static bool gCheckUserRole(long iduser, ref String[] roles)
        {

            bool resultval = false;

            if (Globals.glOpenSqlConn())
            {
                String inRoles="", qrystr;

                // stitch all roles together;
                foreach(String r in roles )
                {
                    if (inRoles.Length == 0)
                        inRoles += Globals.glQoutedSinglestr(r.ToUpper());
                    else
                        inRoles += "," + Globals.glQoutedSinglestr(r.ToUpper()); ;
                }

               inRoles = "(" + inRoles + ")";

               qrystr = "select ur.iduser,r.name "+
                     " from dbo.userroles ur left join dbo.roles r " +
                       " on ur.idrole = r.id " +
                       " where ur.iduser = " + iduser.ToString() + " " +
                       "and UPPER(r.name) in "+inRoles;

              //  csMessageBox.Show(qrystr, "result", MessageBoxButtons.OK,
               //     MessageBoxIcon.Information);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;
                cmd.CommandText = qrystr;
                                                                         
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) resultval = true;
                reader.Close();
                
                          
            }

            Globals.glCloseSqlConn();
            return resultval;

        }

        public static void  gstrAlignRight(ref String str, int mlength)
        {
            String bstring = "                                                " +
                             "                                                ";
            int l = str.Length;

            if (mlength > l)

                str = bstring.Substring(0, mlength - l) + str;

        }

        public static void GetUserEmail(long uid, ref String uemail,
            ref String usmtphost, ref String usmtpport)
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spGetUserEmail",
                    Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid",uid);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    uemail = reader["email"].ToString();
                    usmtphost = reader["smtphost"].ToString();
                    usmtpport = reader["smtpport"].ToString();
                                  

                }
                reader.Close();
                
            }
            Globals.glCloseSqlConn();

        }

        public static void glUserMustChangePwd(long uid, ref bool result)
        {
            String vread = "";
            result = true;
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spUserMustChangePwd",
                    Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", uid);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    vread =reader["mustchangepwd"].ToString().Trim().ToLower();
                    //csMessageBox.Show("mustchange:" + vread,
                    //    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (vread == "false") result = false;

                }

                reader.Close();
            }
            Globals.glCloseSqlConn();

        }

        public static void glRemoveMustChangePwd(long uid)
        {
            if (Globals.glOpenSqlConn())
            {
                try
                {


                    SqlCommand cmd = new SqlCommand("spRemoveMustChangePwd", Globals.sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@uid", uid);

                    
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    csMessageBox.Show("Exception Error:" + ex.Message,
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            Globals.glCloseSqlConn();
        }


        public static string glNormalizeNo(long vl, int ln)
        {
            String resultval = vl.ToString().Trim();
            String zerostr = "000000000000000000000000000000";
            int l1 = resultval.Length;

            if (l1 < ln)
                resultval = zerostr.Substring(0, ln - l1) + resultval;
            return resultval;
        }
        public static void glSetUserInitialBranch()
        {
            
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("exec dbo.spGetUserDefaultBranch " +
                    Globals.gIdUser.ToString(),
                    Globals.sqlconn);
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Globals.gIdBranch = int.Parse(reader["idbranch"].ToString());
                    Globals.gBranchName = reader["name"].ToString().Trim().ToUpper();

                }

                reader.Close();
            }
            Globals.glCloseSqlConn();


        }

        public static float glStringtoFloat(String vl)
        {
            float result = 0.0f;

            result = (float)(vl == "" ? 0.0 : float.Parse(vl));

            return result;
        }

        public static int glStringtoInt(String vl)
        {
            int result = 0;

            result = (int)(vl == "" ? 0 : int.Parse(vl));

            return result;
        }

        public static DateTime glStringtoDateTime(String vl)
        {
            DateTime result = new DateTime(1900,1,1);
            DateTime blankdate = new DateTime(1900,1,1);
            CultureInfo ci = CultureInfo.InvariantCulture;

            result = (vl == "" ? blankdate : DateTime.ParseExact(vl, "MM/dd/yyyy", ci));

            return result;
        }


        public static Color glGetStatusColor(String status)
        {
            Color retvalue=Color.Black;

            if (status == "DRAFT")
            {
                retvalue= Color.Gray;
            }
            else if (status == "ENDORSED")
            {
                retvalue = Color.Black;
            }
            else if (status == "CANCELLED")
            {
                retvalue = Color.Red;

            }
            else   // final or approved
            {
                retvalue = Color.Blue;
            }

            return retvalue;


        }
    }
}
