using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public interface IEntyty
    {
    }

    public class AEntity : IEntyty
    {
        public static void getPropertiesName(IEntyty foo)
        {
            var fieldValues = foo.GetType()
                                 .GetProperties()
                                 .Select(field => field.GetValue(foo))
                                 .ToString();

        }

        private string addPropertyName(PropertyInfo item)
        {
            if (item.PropertyType.Name == "String") return $"'{item.Name}'";


            return item.Name;
        }
    }
    public class Invoice : IEntyty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Term { get; set; }
        public int PaymentMethodID { get; set; }
        public decimal TotalNetAmount { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public decimal TotalBrtAmount { get; set; }
        public dynamic State { get; set; }
    }

    public class InvoiceItem : IEntyty
    {
        public int InvoiceId { get; set; }
        public int ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal NetPrice { get; set; }
        public decimal NetAmount { get; set; }
        public int VatRate { get; set; }
        public decimal VatAmount { get; set; }
        public decimal BrtAmount { get; set; }
    }
    public class Company : IEntyty
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string NIP { get; set; }

        public string[] GetData()
        {
            return new string[] { Name, Street, ZipCode, City, NIP };
        }
    }

    public class Product : IEntyty
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public dynamic Jm { get; set; }
        public dynamic Vat { get; set; }
        public decimal Price { get; set; }

        public dynamic[] getData()
        {
            return new dynamic[] { Name, Jm, Vat, Price.ToString() };
        }
    }

    public class JM:IEntyty
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Precision { get; set; }
    }

    public class VatRates:IEntyty
    {
        public int ID { get; set; }
        public int Rate { get; set; }
    }

    public class PaymentMethod : IEntyty
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class State : IEntyty
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class SmallTable<TKey,TValue> : Dictionary<TKey,TValue>
    {
        SmallTable() : base() { }
    }
}
