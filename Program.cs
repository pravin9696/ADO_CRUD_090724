using System.Data;
using System.Data.SqlClient;

namespace ADO_CRUD_090724
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  insert logic ADO.net

            //int rl;
            //string nm;
            //int contact;
            //string add1;
            //Console.WriteLine("Enter roll,name,contact and city");
            //rl = int.Parse(Console.ReadLine());
            //nm = Console.ReadLine();
            //contact = int.Parse(Console.ReadLine());
            //add1 = Console.ReadLine();

            ////step1
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRFMLF6\\SQLEXPRESS;Initial Catalog=dbTemp;Integrated Security=True;TrustServerCertificate=True");

            //con.Open();

            ////step2
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            ////cmd.CommandText = "insert into tblStudent090724 values(" + rl + ",'" + nm + "'," + contact + ",'" + add1 + "')";
            //cmd.CommandText = $"insert into tblStudent090724 values({rl},'{nm}',{contact},'{add1}')";
            //cmd.CommandType = CommandType.Text;

            ////step3
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    Console.WriteLine("record inserted successully");
            //}
            //else
            //{
            //    Console.WriteLine("record not inserted!!!");
            //}

            //con.Close();

            #endregion

            #region  update logic ADO.net

            //int rl;
            //string nm;
            //int contact;
            //string add1;

            //Console.WriteLine("Enter roll whose information we are changing");
            //rl = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter new name, contact number and address of student");
            //nm = Console.ReadLine();
            //contact = int.Parse(Console.ReadLine());
            //add1 = Console.ReadLine();

            ////step1
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRFMLF6\\SQLEXPRESS;Initial Catalog=dbTemp;Integrated Security=True;TrustServerCertificate=True");
            //con.Open();

            ////step2
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            ////cmd.CommandText = "insert into tblStudent090724 values(" + rl + ",'" + nm + "'," + contact + ",'" + add1 + "')";
            //cmd.CommandText = $"update tblStudent090724 set name='{nm}',contact={contact},address='{add1}' where roll={rl}";
            //cmd.CommandType = CommandType.Text;

            ////step3

            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    Console.WriteLine("record updated  successully");
            //}
            //else
            //{
            //    Console.WriteLine("record not updated!!!");
            //}

            //con.Close();
            #endregion

            #region  delete logic ADO.net

            int rl;
           

            Console.WriteLine("Enter roll to delete record from database");
            rl = int.Parse(Console.ReadLine());
           
            //step1
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRFMLF6\\SQLEXPRESS;Initial Catalog=dbTemp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            //step2
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "insert into tblStudent090724 values(" + rl + ",'" + nm + "'," + contact + ",'" + add1 + "')";
            cmd.CommandText = $"delete  from tblStudent090724 where roll={rl}";
            cmd.CommandType = CommandType.Text;

            //step3

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record Deleted  successully");
            }
            else
            {
                Console.WriteLine("record Not found to Delete!!!");
            }

            con.Close();
            #endregion

        }
    }
}
