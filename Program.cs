using EF_3.Context;
using EF_3.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using DBContext DB = new DBContext();

            ////EF Dont load Navigational props

            //var res=DB.Employees.FirstOrDefault(E => E.id == 2);
            //Console.WriteLine(res?.id??0);
            //Console.WriteLine(res?.name??"NA");
            //Console.WriteLine(res?.salary??0);
            //Console.WriteLine(res?.address??"NA");
            //Console.WriteLine(res?.workfor.name??"NA");

            //var res=DB.Departments.FirstOrDefault(D=>D.id==1);
            //Console.WriteLine(res?.id??0);
            //Console.WriteLine(res?.name??"NA");
            //foreach(Employee emp in res.Employees) 
            //{
            //    Console.WriteLine(emp.name);
            //}

            //// Loading to the Navigational prop
            #region 1.Explicitly loading

            //var res = DB.Employees.FirstOrDefault(E => E.id == 2);

            //DB.Entry(res).Reference("workfor").Load();


            //Console.WriteLine(res?.id ?? 0);
            //Console.WriteLine(res?.name ?? "NA");
            //Console.WriteLine(res?.salary ?? 0);
            //Console.WriteLine(res?.address ?? "NA");
            //Console.WriteLine(res?.workfor.name ?? "NA");


            //var res = DB.Departments.FirstOrDefault(D => D.id == 1);

            //DB.Entry(res).Collection("Employees").Load();
            //DB.Entry(res).Collection(E=>E.Employees).Load();

            //Console.WriteLine(res?.id ?? 0);
            //Console.WriteLine(res?.name ?? "NA");
            //foreach (Employee emp in res.Employees)
            //{
            //    Console.WriteLine(emp.name);
            //}

            #endregion

            #region 2.Eager loading

            //var res = DB.Employees.Include("wo").FirstOrDefault(E => E.id == 2);

            //Console.WriteLine(res?.id ?? 0);
            //Console.WriteLine(res?.name ?? "NA");
            //Console.WriteLine(res?.salary ?? 0);
            //Console.WriteLine(res?.address ?? "NA");
            //Console.WriteLine(res?.workfor.name ?? "NA");

            //var res=DB.Departments.FirstOrDefault(D=>D.id==1);
            //Console.WriteLine(res?.id??0);
            //Console.WriteLine(res?.name??"NA");
            //foreach(Employee emp in res.Employees) 
            //{
            //    Console.WriteLine(emp.name);
            //}

            #endregion

            #region 3.Lazy loading[Implict]

            ////1.install proxies
            ////2.use lazy loading Proxies in on config
            ////3.Make all entites public
            ////4.Make all natvigation properties virtual

            //var res = DB.Employees.FirstOrDefault(E => E.id == 2);
            //Console.WriteLine(res?.id ?? 0);
            //Console.WriteLine(res?.name ?? "NA");
            //Console.WriteLine(res?.salary ?? 0);
            //Console.WriteLine(res?.address ?? "NA");
            //Console.WriteLine(res?.workfor.name ?? "NA");

            //var res=DB.Departments.FirstOrDefault(D=>D.id==1);
            //Console.WriteLine(res?.id??0);
            //Console.WriteLine(res?.name??"NA");
            //foreach(Employee emp in res.Employees) 
            //{
            //    Console.WriteLine(emp.name);
            //}

            #endregion


            #region Join
            
            ////fluent syntax
            //var res = DB.Employees.Join(DB.Departments, E => E.Deptid, D => D.id, (E, D) 
            //=> new {EmpId=E.id,EmpName=E.name,DeptID=D.id,DepartmentName=D.name});

            //foreach(var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //res = from E in DB.Employees
            //      join D in DB.Departments on E.Deptid equals D.id
            //      select new { EmpId = E.id, EmpName = E.name, DeptID = D.id, DepartmentName = D.name };

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Tracking VS no Tracking

            //Tracking Default

            var res = DB.Employees.AsNoTracking().FirstOrDefault(E => E.id == 2);
            Console.WriteLine(DB.Entry(res).State);//Detached
            res.name = "ali";//Local
            Console.WriteLine(DB.Entry(res).State);//Local
            DB.SaveChanges();//Remotly

            #endregion

            #region Local Remote

            DB.Employees.Load();


            DB.Employees.Local.Any();
            DB.Employees.Local.Any();
            DB.Employees.Local.Any();
            DB.Employees.Local.Any();
            DB.Employees.Local.Any();
            DB.Employees.Local.Any();
            DB.Employees.Local.Any();
            DB.Employees.Local.Any();
            DB.Employees.Local.Any();
            DB.Employees.Local.Any();

            #endregion








        }
    }
}
