using IntermediarioPOO.Entities.ExeercicioEC.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities.ExeercicioEC
{
    class Ordert
    {
        public DateTime Moment { get; set; }
        public OrderStatust Status { get; set; }
        public List<OrderItem> OrderList { get;  private set; } = new List<OrderItem>();
        public Client Client { get; private set; }

        public Ordert(DateTime moment, OrderStatust status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item) 
        {
            OrderList.Add(item);
        }
        public void removeItem(OrderItem item) 
        {
            OrderList.Remove(item);
        }

        public double Total() 
        {
            double sum = 0;
            foreach (OrderItem obj in OrderList) 
            {

                for (int i = 1; i <= obj.Quantity; i++) 
                {
                    sum += obj.Price;
                }
                   
            
            }

            return sum;
        
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string summary = "order summary: ";
            sb.AppendLine(summary.ToUpper());
            sb.AppendLine("Order moment: " +Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine($"Client: {Client.Name}  ({Client.BirthDate}) - {Client.Email}");

            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("|---------------------------------------|");
            sb.AppendLine("|         ----  Order items  -----      |");

            foreach (OrderItem obj in OrderList) 
            {
                sb.AppendLine("------------------------------------------");
                sb.AppendLine($"Item: {obj.Product.Name.ToString()} ");
                sb.AppendLine($"Price: ${obj.Product.Price.ToString()} ");
                sb.AppendLine($"Quantity: {obj.Quantity}, SubTotal: {obj.SubTotal().ToString("F2")}");
                
            }


            sb.AppendLine();
            sb.AppendLine($"| Total price: $: {Total().ToString("F2")} |");
            return sb.ToString();

        }
    }

}
