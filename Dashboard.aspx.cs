using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Dashboard : System.Web.UI.Page
{
    Fetch Fetch = new Fetch();
    private static DataTable dt;
    Properties P = new Properties();
    protected void Page_Load(object sender, EventArgs e)
    {
        dt = new DataTable();

        dt = Fetch.AdminFetchNewConsumers();
        if (dt.Rows.Count > 0)
        {
            AdminAllConsumer.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchPostingVoucher();
        if (dt.Rows.Count > 0)
        {
            Adminsbpposteddaily.InnerHtml = dt.Rows[0][0].ToString();
            AdminStubPosted.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchMUCTEmployeeBill();
        if (dt.Rows.Count > 0)
        {
            AdminMuctEmployeebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchSearchingSheetBill();
        if (dt.Rows.Count > 0)
        {
            AdminSearchingSheetbill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetch15PercentBill();
        if (dt.Rows.Count > 0)
        {
            Admin15percentbill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchKMCHeadOfficeBill();
        if (dt.Rows.Count > 0)
        {
            AdminHeadofficeDaily.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchKMCCampOfficeBill();
        if (dt.Rows.Count > 0)
        {
            AdminCampOffice.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchDuplicateBill();
        if (dt.Rows.Count > 0)
        {
            Adminduplicatebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchCompleteBill();
        if (dt.Rows.Count > 0)
        {
            AdminCompletebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchRebateBill();
        if (dt.Rows.Count > 0)
        {
            AdminRebatebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchPostingVoucher();
        if (dt.Rows.Count > 0)
        {
            AdminTotalpostingVoucher.InnerHtml = "Total (" + dt.Rows[0][0].ToString() + ") Stubs Posted Today";
        }

        dt = Fetch.AdminFetchHBLPostingDaily();
        if (dt.Rows.Count > 0)
        {
            Adminhblposteddaily.InnerHtml = dt.Rows[0][0].ToString() + " Stubs";
            Adminhblposteddailypercent.Attributes["width"] = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchNBPPostingDaily();
        if (dt.Rows.Count > 0)
        {
            Adminnbpposteddaily.InnerHtml = dt.Rows[0][0].ToString() + " Stubs";
            Adminnbpposteddailypercent.Attributes["width"] = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchSBPPostingDaily();
        if (dt.Rows.Count > 0)
        {
            Adminsbpposteddaily.InnerHtml = dt.Rows[0][0].ToString() + " Stubs";
            Adminsbpposteddailypercent.Attributes["width"] = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchPDOTable();
        if (dt.Rows.Count > 0)
        {
            tbPDOCreatedby.InnerHtml = dt.Rows[0][0].ToString();
            tbPDOConsumer.InnerHtml = dt.Rows[0][1].ToString();
            tbPDOZone.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchKATable();
        if (dt.Rows.Count > 0)
        {
            tbKACreatedby.InnerHtml = dt.Rows[0][0].ToString();
            tbKAConsumer.InnerHtml = dt.Rows[0][1].ToString();
            tbKAZone.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchLandTable();
        if (dt.Rows.Count > 0)
        {
            tbLandCreatedby.InnerHtml = dt.Rows[0][0].ToString();
            tbLandConsumer.InnerHtml = dt.Rows[0][1].ToString();
            tbLandZone.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchEstateTable();
        if (dt.Rows.Count > 0)
        {
            tbEstateCreatedby.InnerHtml = dt.Rows[0][0].ToString();
            tbEstateConsumer.InnerHtml = dt.Rows[0][1].ToString();
            tbEstateZone.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchChargeParkingTable();
        if (dt.Rows.Count > 0)
        {
            tbParkingCreatedby.InnerHtml = dt.Rows[0][0].ToString();
            tbParkingConsumer.InnerHtml = dt.Rows[0][1].ToString();
            tbParkingZone.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchChargeParkingTable();
        if (dt.Rows.Count > 0)
        {
            tbParkingCreatedby.InnerHtml = dt.Rows[0][0].ToString();
            tbParkingConsumer.InnerHtml = dt.Rows[0][1].ToString();
            tbParkingZone.InnerHtml = dt.Rows[0][2].ToString();
        }

        P.AdminPostingEmployee = "wahaj";
        dt = Fetch.AdminFetchPostingEmployeeDaily(P);
        if (dt.Rows.Count > 0)
        {
            Adminpostingdailyemp1.InnerHtml = dt.Rows[0][0].ToString();
        }

        P.AdminPostingEmployee = "wajahat";
        dt = Fetch.AdminFetchPostingEmployeeDaily(P);
        if (dt.Rows.Count > 0)
        {
            Adminpostingdailyemp2.InnerHtml = dt.Rows[0][0].ToString();
        }

        P.AdminPostingEmployee = "zain";
        dt = Fetch.AdminFetchPostingEmployeeDaily(P);
        if (dt.Rows.Count > 0)
        {
            Adminpostingdailyemp4.InnerHtml = dt.Rows[0][0].ToString();
        }

        P.AdminPostingEmployee = "Ali";
        dt = Fetch.AdminFetchPostingEmployeeDaily(P);
        if (dt.Rows.Count > 0)
        {
            Adminpostingdailyemp3.InnerHtml = dt.Rows[0][0].ToString();
        }

        P.AdminPostingEmployee = "Raafay";
        dt = Fetch.AdminFetchPostingEmployeeDaily(P);
        if (dt.Rows.Count > 0)
        {
            Adminpostingdailyemp5.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchcOCompleteDaily();
        if (dt.Rows.Count > 0)
        {
            AdminCOCompletebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchCODuplicateDaily();
        if (dt.Rows.Count > 0)
        {
            AdminCODuplicatebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchCORebateDaily();
        if (dt.Rows.Count > 0)
        {
            AdminCORebatebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchHOCompleteDaily();
        if (dt.Rows.Count > 0)
        {
            AdminHOCompletebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchHOCompleteDaily();
        if (dt.Rows.Count > 0)
        {
            AdminHOCompletebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchHODuplicateDaily();
        if (dt.Rows.Count > 0)
        {
            AdminHODuplicatebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchHORebateDaily();
        if (dt.Rows.Count > 0)
        {
            AdminHORebatebill.InnerHtml = dt.Rows[0][0].ToString();
        }

        dt = Fetch.AdminFetchPDOSuspendedTable();
        if (dt.Rows.Count > 0)
        {
            tbPDOConsumerSame.InnerHtml = dt.Rows[0][0].ToString();
            tbPDOCreatedbySame.InnerHtml = dt.Rows[0][1].ToString();
            tbPDOZoneSame.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchKASuspendedTable();
        if (dt.Rows.Count > 0)
        {
            tbKAConsumerSame.InnerHtml = dt.Rows[0][0].ToString();
            tbKACreatedbySame.InnerHtml = dt.Rows[0][1].ToString();
            tbKAZoneSame.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchLandSuspendedTable();
        if (dt.Rows.Count > 0)
        {
            tbLandConsumerSame.InnerHtml = dt.Rows[0][0].ToString();
            tbLandCreatedbySame.InnerHtml = dt.Rows[0][1].ToString();
            tbLandZoneSame.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchEstateSuspendedTable();
        if (dt.Rows.Count > 0)
        {
            tbEstateConsumerSame.InnerHtml = dt.Rows[0][0].ToString();
            tbEstateCreatedbySame.InnerHtml = dt.Rows[0][1].ToString();
            tbEstateZoneSame.InnerHtml = dt.Rows[0][2].ToString();
        }

        dt = Fetch.AdminFetchChargeParkingSuspendedTable();
        if (dt.Rows.Count > 0)
        {
            tbParkingConsumerSame.InnerHtml = dt.Rows[0][0].ToString();
            tbParkingCreatedbySame.InnerHtml = dt.Rows[0][1].ToString();
            tbParkingZoneSame.InnerHtml = dt.Rows[0][2].ToString();
        }
    }
}