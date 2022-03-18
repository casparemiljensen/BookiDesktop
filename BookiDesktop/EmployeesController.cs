using BookiDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookiDesktop {
    public class EmployeesController {

        private BaseContr

        public async Task<List<Employee>> GetList(int id) {
            List<Employee> EmployeeInfo = new List<Employee>();
            bCtrl = new BaseController();
            using (var client = bCtrl.GetClient()) {

                HttpResponseMessage Res = await client.GetAsync("venueEmployees/" + id);

                if (Res.IsSuccessStatusCode) {
                    var EmployeeResponse = Res.Content.ReadAsStringAsync().Result;

                    EmployeeInfo = JsonConvert.DeserializeObject<List<Employee>>(EmployeeResponse);
                }
            }

            return EmployeeInfo;
        }

    }
}
