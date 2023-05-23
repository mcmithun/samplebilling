using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace WSyBillApp
{
    class OrganizationDetails
    {
        public string orgpreferenceStr;
        public OrganizationDetails(string preferenceString, int index)
        {
            //Get organization details from settings
            orgpreferenceStr = preferenceString.Split(";")[index].Split("=")[1];
            Name = orgpreferenceStr.Split(",")[0];
            Road = orgpreferenceStr.Split(",")[1];
            Place = orgpreferenceStr.Split(",")[2];
            Phone = orgpreferenceStr.Split(",")[3];
            Pin = orgpreferenceStr.Split(",")[4];
        }
        string name;
        string road;
        string place;
        string phone;
        string pin;

        public string Name { get => name; set => name = value; }
        public string Road { get => road; set => road = value; }
        public string Place { get => place; set => place = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Pin { get => pin; set => pin = value; }

        public List<string> GetOrganizationGetFilled()
        {
            List<string> data = new List<string>();
            data.Add(Name);
            data.Add(Road);
            data.Add(Place);
            data.Add(Phone);
            data.Add(Pin);

            return data;
        }
    }

    class SettingsUtilityWSBilling
    {
        private string preferenceString;
        public OrganizationDetails orgDetails;
        public List<string> taxSlabPreferences;
        public static SettingsUtilityWSBilling instance = null;
        public static string UriFile = @"URI=file:";
        private static readonly string DatabaseFile = "billing.db";
        public static string databaseFileCompletepath = System.IO.Directory.GetCurrentDirectory() + "\\" + SettingsUtilityWSBilling.DatabaseFile;

        public static string ExceptionStr = "exception";

        public static string CreateTable = "CREATE TABLE ";
        public static string InsertTable = "INSERT INTO ";
        public static string ValueTag = " VALUES ";
        public static string DateTimeSqlFuncTag = " datetime"; // datetime('<date as fmt>')
        public static string UpdateTable = "UPDATE ";
        public static string SetTag = " SET ";
        public static string SelectAllFromTable = "SELECT * FROM ";
        public static string WhereTag = " WHERE ";
        public static string EqualTag = " = ";
        public static string AndTag = " AND ";
        public static string QueryEndTag = " ; ";
        public static string DateFormatForQuery = "yyyy-MM-dd";
        public static string DateTimeFormatForQuery = "yyyy-MM-dd HH:mm:ss";

        //Tables
        public static string TableBillSale = "SALE_BILL";

        // the below are must available tags in the bill format.
        public static string BillHtml = "BillInvoice.html";
        public static string BillInvoice = "<!-- INVOICE# -->";
        public static string BillDate = "<!-- BILLDATE# -->";
        public static string BillOrganization = "<!-- ORGANIZATION# -->";
        public static string BillOrgRoad = "<!-- ORGROAD# -->";
        public static string BillPlace = "<!-- ORGPLACE# -->";
        public static string BillPhones = "<!-- ORGPHONE# -->";
        public static string BillOrgPin = "<!-- ORGPIN# -->";
        public static string BillDealerName = "<!-- DEALERNAME# -->";
        public static string BillDealerPhone = "<!-- DEALERPHONE# -->";
        public static string BillDealerAddress = "<!-- DEALERADDRESS# -->";
        public static string BillTagItemsAdd = "<!-- Add items -->";
        public static string BillItemDetails = "<!-- ITEMNAMEDETAILS# -->";
        public static string BillItemQuantities = "<!-- QUANTITYITEM# -->";
        public static string BillItemTax = "<!-- ITEMTAX# -->";
        public static string BillItemMrp = "<!-- ITEMMRP# -->";
        public static string BillItemTaxValue = "<!-- ITEMTAXVALUE# -->";
        public static string BillItemTaxableValue = "<!-- ITEMTAXABLEVALUE# -->";
        public static string BillItemPrice = "<!-- ITEMPRICE# -->";
        public static string SumTaxes = "<!-- SUM TAX# -->";
        public static string SumItems = "<!-- SUM ITEMS# -->";
        public static string SumItemsTaxes = "<!-- SUM ITEMS TAX# -->";
        public static string ItemAddTagSlot_default = "<tr>\n" +
                                            "<td style =\"width:313px\"><!-- ITEMNAMEDETAILS# --></td>\n" +
                                            "<td style=\"text-align:center; width:63px\"><!-- ITEMMRP# --></td>\n" +
                                            "<td style=\"text-align:center; width:61px\"><!-- ITEMTAX# --></td>\n" +
                                            "<td style=\"text-align:center; width:66px\"><!-- ITEMTAXVALUE# --></td>\n" +
                                            "<td style=\"text-align:center; width:86px\"><!-- ITEMTAXABLEVALUE# --></td>\n" +
                                            "<td style=\"text-align:center; width:100px\"><!-- QUANTITYITEM# --></td>\n" +
                                            "<td style=\"text-align:center; width:100px\"><!-- ITEMPRICE# --></td>\n" +
                                        "</tr>\n" +
                                        "<!-- Add items -->";
        public static string InitiateSqlDataBaseFile = "InitiateTables.sql";
        public static string PreferenceFile = "Preferences.ini";

        public static long NanoTime()
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return nano;
        }

        private SettingsUtilityWSBilling()
        {
            preferenceString = File.ReadAllText(PreferenceFile).ToString();
            Console.WriteLine($" this preferenceString: {preferenceString}");
            orgDetails = new OrganizationDetails(preferenceString, 0);
            Console.WriteLine($" this orgDetails: {orgDetails.orgpreferenceStr}");
            taxSlabPreferences = new List<string>(preferenceString.Split(";")[1].Split("=")[1].Split(","));
            Console.WriteLine($" this are the taxes: {taxSlabPreferences[0]} {taxSlabPreferences[1]} {taxSlabPreferences[2]} {taxSlabPreferences[3]} {taxSlabPreferences[4]}");
        }

        public static SettingsUtilityWSBilling Instance()
        {
            return (instance == null) ? new SettingsUtilityWSBilling() : instance;
        }
    }
}
