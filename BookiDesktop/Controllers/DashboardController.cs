using BookiDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookiDesktop.Controllers {
    public class DashboardController {

        private EmployeesController eCtrl;
        private DashboardGUI dGUI;

        public async Task<int> AddVenueStats() {
            int NoOfVenues = 0;
            eCtrl = new EmployeesController();
            dGUI = DashboardGUI.Instance;
            List<Venue> venues = await eCtrl.GetVenues(dGUI.EmployeeId);
            int a = 0;
            foreach (Venue v in venues) {
                if (venues.Count > 0) {
                    a++;
                }
            }
            NoOfVenues = a;
            return NoOfVenues;
        }

    }
}
