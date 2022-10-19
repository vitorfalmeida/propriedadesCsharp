using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedadesCsharp.Model
{
    public class VendaDeserializada
    {
       public int Id { get; set; } 
       public string Produto { get; set; }
       public Decimal Preco { get; set; }
    
       public DateTime DataVenda { get; set; }     
    }

}