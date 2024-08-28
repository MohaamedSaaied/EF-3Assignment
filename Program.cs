using EF_3InhertanceExample.Context;
using EF_3InhertanceExample.Models;

namespace EF_3InhertanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using DBContext DB = new DBContext();

            #region

            //1.TPC
            //2.TPH
            //3.TPCC


            //FullTimeEmp FullTime=new FullTimeEmp() { name="Ahmed",salary=5000,email="ahmed@gmail.com",address="address"};
            //DB.FullTimeEmps.Add(FullTime);
            //DB.SaveChanges();

            //PartTimeEmp PartTime = new PartTimeEmp() { name = "Ahmed",NumOfHour=5, email = "ahmed@gmail.com", address = "address",HoureRate=5.0 };
            //DB.PartTimeEmps.Add(PartTime);
            //DB.SaveChanges();


            //FullTimeEmp FullTime = new FullTimeEmp() { name = "Ahmed", salary = 5000, email = "ahmed@gmail.com", address = "address" };
            //DB.Employees.Add(FullTime);
            //DB.SaveChanges();

            //PartTimeEmp PartTime = new PartTimeEmp() { name = "Ahmed", NumOfHour = 5, email = "ahmed@gmail.com", address = "address", HoureRate = 5.0 };
            //DB.PartTimeEmps.Add(PartTime);
            //DB.SaveChanges();

            //var res = DB.Employees.OfType<FullTimeEmp>();
            //foreach (var employee in res) 
            //{ Console.WriteLine(employee.name); }


            #endregion

        }
    }
}
