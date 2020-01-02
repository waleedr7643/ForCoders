using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

using System.Data;

namespace TMR.GP.SMSAlertSystem
{
    public enum ConnectionType { Company = 1 }
    class DataAccess
    {
        string strConn = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
        public SqlConnection GetDBConection(ConnectionType conntype)
        {
            string strConn = "";
            if (conntype == ConnectionType.Company)
            {
                strConn = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            }

            if (strConn == null)
                return null;

            SqlConnection conn = new SqlConnection(strConn);
            return conn;

            //strConn = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            if (strConn == null)
                return null;
            Console.Write("connection error");
            //SqlConnection
            conn = new SqlConnection(strConn);
            return conn;
        }

        internal List<TMRMESSAGETABLE> ViewUnsentMessages()
        {
            List<TMRMESSAGETABLE> lst = new List<TMRMESSAGETABLE>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_VIEW_UNSENTDATA"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //"select VENDORID, DOCNUMBR from TMRMESSAGETABLE"
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TMRMESSAGETABLE info = new TMRMESSAGETABLE();
                        info.ID = int.Parse(reader["id"].ToString());
                        info.VENDORID = reader["VENDORID"].ToString();
                        info.CUSTNMBR = reader["CUSTNMBR"].ToString();
                        info.DOCNUMBR = reader["DOCNUMBR"].ToString();
                        info.DOCTYPE = int.Parse(reader["DOCTYPE"].ToString());
                        info.DUEDATE = DateTime.Parse(reader["DUEDATE"].ToString());
                        info.DOCDATE = DateTime.Parse(reader["DOCDATE"].ToString());
                        info.VCHRNMBR = reader["VCHRNMBR"].ToString();
                        info.DOCAMNT = decimal.Parse(reader["DOCAMNT"].ToString());
                        info.SERIES = reader["SERIES"].ToString();
                        info.Status = int.Parse(reader["Status"].ToString());
                        info.ErrorMsg = reader["ErrorMsg"].ToString();
                        info.PhoneNo1 = reader["PhoneNo1"].ToString();
                        info.PhoneNo2 = reader["PhoneNo2"].ToString();
                        info.PhoneNo3 = reader["PhoneNo3"].ToString();
                        info.AttemptDate = DateTime.Parse(reader["AttemptDate"].ToString());
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }//for Tmrmessagetable

        public List<TMRDOCTYPE> ViewUnsentMessagesfordoctype()//for tmrdoctype
        {
            List<TMRDOCTYPE> lst = new List<TMRDOCTYPE>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from TMRDOCTYPE";
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TMRDOCTYPE info = new TMRDOCTYPE();
                        info.id = int.Parse(reader["id"].ToString());
                        info.DOCTYPE = int.Parse(reader["DOCTYPE"].ToString());
                        info.SERIES = reader["SERIES"].ToString();
                        info.DESCRIPTION = reader["DESCRIPTION"].ToString();
                        info.Message = reader["Message"].ToString();
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }

        public bool UpdateTMRMessageTable(TMRMESSAGETABLE info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMRUPDATEMESSAGETABLE"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@status", info.Status);
                            cmd.Parameters.AddWithValue("@errormsg", info.ErrorMsg);
                            //cmd.Parameters.AddWithValue("@phoneno", info.PhoneNo3);
                            cmd.Parameters.AddWithValue("@attemptdate", info.AttemptDate);
                            cmd.Parameters.AddWithValue("@id", info.ID);

                            st = cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { }
            if (st > 0)
                return true;
            else
                return false;
        }// for storedprocedure 

        //internal List<TMRDOCTYPE> ViewMessageTable()
        //{
        //    List<TMRDOCTYPE> lst = new List<TMRDOCTYPE>();

        //    using (SqlConnection conn = new SqlConnection(strConn))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("TMR_VIEW_UNSENTDATA"))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            //"select VENDORID, DOCNUMBR from TMRMESSAGETABLE"
        //            cmd.Connection = conn;
        //            conn.Open();

        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                TMRDOCTYPE info = new TMRDOCTYPE();
        //                info.id = int.Parse(reader["id"].ToString());
        //                info.VENDORID = reader["VENDORID"].ToString();
        //                info.CUSTNMBR = reader["CUSTNMBR"].ToString();
        //                info.DOCNUMBR = reader["DOCNUMBR"].ToString();
        //                info.DOCTYPE = int.Parse(reader["DOCTYPE"].ToString());
        //                info.DUEDATE = DateTime.Parse(reader["DUEDATE"].ToString());
        //                info.DOCDATE = DateTime.Parse(reader["DOCDATE"].ToString());
        //                info.VCHRNMBR = reader["VCHRNMBR"].ToString();
        //                info.DOCAMNT = decimal.Parse(reader["DOCAMNT"].ToString());
        //                info.SERIES = reader["SERIES"].ToString();
        //                info.Status = int.Parse(reader["Status"].ToString());
        //                info.ErrorMsg = reader["ErrorMsg"].ToString();
        //                info.PhoneNo = reader["PhoneNo"].ToString();
        //                info.AttemptDate = DateTime.Parse(reader["AttemptDate"].ToString());
        //                lst.Add(info);
        //            }
        //        }
        //    }
        //    return lst;
        //}

        internal List<TMRMESSAGETABLE> ViewTMRTABLEListObjectByindx(TMRMESSAGETABLE ID)
        {
            List<TMRMESSAGETABLE> list = new List<TMRMESSAGETABLE>();
            TMRMESSAGETABLE info = new TMRMESSAGETABLE();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("select VENDORID, DOCNUMBR from TMRMESSAGETABLE where VENDORID = @id"))
                {

                    cmd.Parameters.AddWithValue("@id", ID.VENDORID);
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows == true)
                    {
                        info = new TMRMESSAGETABLE();
                        while (reader.Read())
                        {
                            info.VENDORID = reader["VENDORID"].ToString(); ;
                            info.DOCNUMBR = reader["DOCNUMBR"].ToString();
                            list.Add(info);
                        }


                    }
                }
            }
            return list;
        }//for reference

        internal string viewvendrphnmbr(string id)//if type pm
        {
            string vendrphnmbr = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("select userdef2 from PM00200 where VENDORID = @vendorid"))
                {

                    cmd.Parameters.AddWithValue("@vendorid", id);
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            vendrphnmbr = reader["userdef2"].ToString();
                        }
                    }
                }
            }
            return vendrphnmbr;
        }

        internal string viewcustphnmbr(string id)//if type rm
        {
            string custphnmbr = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("select COMMENT1 from RM00101 where custnmbr = @custnmbr"))
                {

                    cmd.Parameters.AddWithValue("@custnmbr", id);
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            custphnmbr = reader["COMMENT1"].ToString();
                        }
                    }
                }
            }
            return custphnmbr;
        }

        internal List<TMRMESSAGETABLE> ViewFilteredMessages(string status, string series, DateTime startdate, DateTime enddate)
        {
            List<TMRMESSAGETABLE> lst = new List<TMRMESSAGETABLE>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("ViewFilteredMessages"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    int st = 0;
                    if (status == "All")
                        st = 0;
                    else if (status == "Unsent")
                        st = 1;
                    else if (status == "Sent")
                        st = 2;
                    else if (status == "Error")
                        st = 3;

                    cmd.Parameters.AddWithValue("@status", st);
                    cmd.Parameters.AddWithValue("@series", series);
                    cmd.Parameters.AddWithValue("@StartDate", startdate);
                    cmd.Parameters.AddWithValue("@EndDate", enddate);

                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TMRMESSAGETABLE info = new TMRMESSAGETABLE();
                        info.ID = int.Parse(reader["id"].ToString());
                        info.VENDORID = reader["VENDORID"].ToString();
                        info.CUSTNMBR = reader["CUSTNMBR"].ToString();
                        info.DOCNUMBR = reader["DOCNUMBR"].ToString();
                        info.DOCTYPE = int.Parse(reader["DOCTYPE"].ToString());
                        info.DUEDATE = DateTime.Parse(reader["DUEDATE"].ToString());
                        info.DOCDATE = DateTime.Parse(reader["DOCDATE"].ToString());
                        info.VCHRNMBR = reader["VCHRNMBR"].ToString();
                        info.DOCAMNT = decimal.Parse(reader["DOCAMNT"].ToString());
                        info.SERIES = reader["SERIES"].ToString();
                        info.Status = int.Parse(reader["Status"].ToString());
                        info.ErrorMsg = reader["ErrorMsg"].ToString();
                        info.PhoneNo1 = reader["PhoneNo1"].ToString();
                        info.PhoneNo2 = reader["PhoneNo2"].ToString();
                        info.PhoneNo3 = reader["PhoneNo3"].ToString();
                        info.AttemptDate = DateTime.Parse(reader["AttemptDate"].ToString());
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
    }
}
