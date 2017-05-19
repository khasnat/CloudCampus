using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for BusinessClass
/// </summary>
public class BusinessClass
{
    public BusinessClass()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //GD--------------//
    SqlConnection con = new SqlConnection(@"Data Source=(local);Integrated Security=SSPI;Initial Catalog=CloudCampus");
    //only for dml query--------------//

    public int dml_query(string sql)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = sql;
        int a = 0;
        con.Open();
        a = cmd.ExecuteNonQuery();
        con.Close();
        return a;


    }
    public int select_query(string sql)
    {
        //string sql = "Select * from AddAudiofile Order By Title";
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds,"a");
        int a = 0;
        DataTable dt = ds.Tables["a"];
        if (dt.Rows.Count > 0)
        {
            a = a + 1;
        }
        return a;
    } 


    //public DataTable dml_select(string select)
    //{
    //   SqlDataAdapter da = new SqlDataAdapter();
    //   DataTable dt = new DataTable();
    //   da.Fill(dt);
    //  return dt;
    //}


}
