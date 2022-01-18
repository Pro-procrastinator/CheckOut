using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class delete
    {                                                                        // give procedure at runtime
        public void deleteUser(object id,string procedure, string parameter) // object use to give any datatype at run time
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, mainclass.con); // stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parameter,id) ;
                mainclass.con.Open();
                cmd.ExecuteNonQuery();
                mainclass.con.Close();
                mainclass.showMessage("Data Deleted Successfully.", "Success..", "Success");
            }
            catch (Exception)
            {
                mainclass.con.Close();
                mainclass.showMessage("Unable to delete record", "Error", "Error");
            }
        }
    }
}
