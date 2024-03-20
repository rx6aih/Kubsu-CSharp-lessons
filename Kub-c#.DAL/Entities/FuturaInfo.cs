using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kub_c_.DAL.Entities
{
    public class FuturaInfo
    {
        public int Id {  get; set; }
        public int FuturaId {  get; set; }
        public int ProductId { get; set; }
        public int Quantity {  get; set; }
        public int Price {  get; set; }

        public Futura Futura { get; set; }
        public Product Product { get; set; }
    }
}
