using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Data;

public class Fetch
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    private static SqlConnection conn;

    private static DataTable dt;

    public DataTable AdminFetchPDOSuspendedTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminPDOConsumerSameTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchKASuspendedTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminKAConsumerSameTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchLandSuspendedTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminLandConsumerSameTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchEstateSuspendedTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminEstateConsumerSameTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchChargeParkingSuspendedTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminChargeParkingConsumerSameTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchcOCompleteDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminCompleteConsumerCO_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchCODuplicateDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminDuplicateConsumerCO_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchCORebateDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminRebateConsumerCO_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchHOCompleteDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminCompleteConsumerHO_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchHODuplicateDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminDuplicateConsumerHO_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchHORebateDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminRebateConsumerHO_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }
    public DataTable AdminFetchPostingEmployeeDaily(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPostingEmp_Today";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@createdby", P.AdminPostingEmployee);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }
    public DataTable AdminFetchHBLPostingDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPostingHBL_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchNBPPostingDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPostingNBP_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchSBPPostingDaily()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPostingSBP_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchNewConsumers()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminDashboard_NewConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchNewEstateConsumers()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminEstateNewConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchNewLandConsumers()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminLandNewConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchNewWalkInConsumers()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminWalkInNewConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchNewKatchiAbadiConsumers()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminKatchiAbadiNewConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchMUCTEmployeeBill()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminMuctEmployeeConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchSearchingSheetBill()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminSearchingSheetConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchPostingVoucher()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPosting_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetch15PercentBill()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Admin15%Consumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchKMCHeadOfficeBill()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminKMCHeadOfficeConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchKMCCampOfficeBill()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminKMCCampOfficeConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }




    public DataTable AdminFetchDuplicateBill()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminDuplicateConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchCompleteBill()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminCompleteConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchRebateBill()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminRebateConsumer_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchPDOTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminPDONConsumerTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchKATable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminKAConsumerTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchLandTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminLandConsumerTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchEstateTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminEstateConsumerTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchChargeParkingTable()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminChargeParkingConsumerTable_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    //public DataTable AdminFetchDeletingRegion()
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_AdminDeletingRegionGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}


    //public DataTable AdminFetchDeActiveRegion()
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_AdminDe_ActiveRegionGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}



    //public DataTable AdminFetchPendingCountry()
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_AdminPendingCountryGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}



    //public DataTable AdminFetchDeletingCountry()
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_AdminDeletingCountryGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}



    //public DataTable AdminFetchDeActiveCountry()
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_AdminDe_ActiveCountryGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}



    //public DataTable AdminFetchPendingCity()
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_AdminPendingCityGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}


    //public DataTable AdminFetchDeletingCity()
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_AdminDeletingCityGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}



    //public DataTable AdminFetchDeActiveCity()
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_AdminDe_ActiveCityGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}



    //public DataTable ResellerFetchDeletingProduct(Properties P)
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_ResellerDeletingProductGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        cmd.Parameters.AddWithValue("@FK_Createdby", P.ResellerDeletingProductGridViewFK_Createdby);
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}




    //public DataTable DistributerFetchDeletingProduct(Properties P)
    //{
    //    DataTable table = new DataTable();
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_DistributerDeletingProductGridView";
    //        cmd.Connection = Getconnected.getconnecting();
    //        cmd.Parameters.AddWithValue("@FK_Createdby", P.DistributerDeletingProductGridViewFK_Createdby);
    //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //        sda.Fill(table);
    //        return table;
    //    }

    //}
}