using System.Data;
using System.Data.SqlClient;

namespace ADO_CRUD_090724
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rl;
            string nm;
            int contact;
            string add1;
            Console.WriteLine("Enter roll,name,contact and city");
            rl = int.Parse(Console.ReadLine());
            nm = Console.ReadLine();
            contact = int.Parse(Console.ReadLine());
            add1 = Console.ReadLine();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRFMLF6\\SQLEXPRESS;Initial Catalog=dbTemp;Integrated Security=True;TrustServerCertificate=True");
            Console.WriteLine(con.DataSource);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tblStudent090724 values(" + rl + ",'" + nm + "'," + contact + ",'" + add1 + "')";
            cmd.CommandType = CommandType.Text;
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record inserted successully");
            }
            else
            {
                Console.WriteLine("record not inserted!!!");
            }

            con.Close();




        }
    }
}
