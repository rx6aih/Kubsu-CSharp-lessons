using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kub_c_.DAL.Entities
{
    public class Futura
    {
        public int Id { get; set; }
        public int ClientId {  get; set; }
        public string Data {  get; set; }
        public int TotalSum {  get; set; } = 0;

        public Client Client { get; set; }
    }
}
