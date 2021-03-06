using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookiDesktop.Models {
    public class Venue {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public List<TablePackage> TablePackages { get; set; }
        public List<Table> Tables { get; set; }
        public override string ToString() {
            return $"[{Id}] - {Name}, {Address}, {Zip}, {City}";
        }

    }
}
