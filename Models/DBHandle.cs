using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public class DBHandle
    {
        EFdbHandle context = new EFdbHandle();
        /*  public List<Customer> getRecords()
          {
              EFdbHandle context = new EFdbHandle();
              List<Customer> ListP = context.Customers.ToList();
              // listP.Add(new Customer());

              return ListP;
          }
          */

        public string getAllRecords()
      {
       
        EFdbHandle context = new EFdbHandle();

        var listP = from ct in context.Customers
                    select new
                    {
                        Customer_Id = ct.Customer_Id,
                        FirstName = ct.FirstName,
                        LastName=ct.LastName,
                        Cuntry=ct.Cuntry,
                       CreatedDate= ct.CreatedDate,
                    };
       List<Customer> listS = new List<Customer>();
      
      foreach (var listE in listP)
        {
                Customer ct = new Customer();
            ct.Customer_Id = listE.Customer_Id;
            ct.FirstName = listE.FirstName;
             ct.LastName = listE.LastName;
                ct.Cuntry = listE.Cuntry;
                ct.CreatedDate = listE.CreatedDate;
                listS.Add(ct);



        }

        return JsonConvert.SerializeObject(listS);

      }

        public Customer getCustomer(int Customer_Id)
        {
            EFdbHandle context = new EFdbHandle();
            var cust = context.Customers.Find(Customer_Id);
            return cust;

        }
       
        public void addCustomer(Customer c)
        {
            EFdbHandle context = new EFdbHandle();
            c.CreatedDate = DateTime.Now;
            context.Customers.Add(c);
            context.SaveChanges();
            return;

        }
        /*public void deleteUser(int  customer_id)
        {
            EFdbHandle context = new EFdbHandle();
            
            context.Customers.Remove(context.Customers.FirstOrDefault(c => c.Customer_Id == customer_id));
            context.SaveChanges();
            return;
        }*/
        public void DeleteCustomer(int id)
        {
            EFdbHandle context = new EFdbHandle();
            context.Customers.Remove(context.Customers.FirstOrDefault(e => e.Customer_Id == id));
            context.SaveChanges();
            return;
        }

        public void updatecustomer(Customer c)
        {
            EFdbHandle context = new EFdbHandle();
            Customer cus = context.Customers.Find(c.Customer_Id);
            cus.FirstName = c.FirstName;
            cus.LastName = c.LastName;
            cus.Cuntry = c.Cuntry;

            context.SaveChanges();
            return;
        }

    }
}

