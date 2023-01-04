using System;
using HappyNewYear_DAL.Models;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HappyNewYear_DAL
{
    public class HappyNewYearRepository
    {
        HappyNewYearDBContext context;

        public HappyNewYearRepository()
        {
            context = new HappyNewYearDBContext();
        }

        public Detail GetDetails(string name)
        {
            Detail Name = null;
            try
            {
                Name = context.Detail.Where(d => d.YourName == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                Name = null;
            }
            return Name;
        }

        public bool AddDetails(string name)
        {
            bool status = false;
            Detail Name = new Detail();
            Name.YourName = name;
            try
            {
                context.Detail.Add(Name);
                context.SaveChanges();
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public bool DeleteDetails(string enteredName)
        {
            bool status = false;
            Detail Name = new Detail();
            try
            {
                Name = context.Detail.Find(enteredName);
                if (Name != null)
                {
                    context.Detail.Remove(Name);
                    context.SaveChanges();
                    status = true;
                }
                else
                {
                    status = false;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status= false;
            }
            return status;
        }
    }
}
