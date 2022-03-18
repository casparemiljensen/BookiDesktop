using BookiDesktop.Controllers;
using BookiDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookiDesktop.GUIs {
    public partial class EditVenuesGUI : Form {
        public EditVenuesGUI() {
            InitializeComponent();
            GetVenueFromID();
        }

        public async void GetVenueFromID() {
            VenuesController vCtrl = new VenuesController();
            VenuesGUI venuesGUI = VenuesGUI.Instance;
            Venue venue = null;
            List<Venue> venuesList = await vCtrl.Get(venuesGUI.idFromTable);
            foreach (Venue currVenue in venuesList) {
                if (currVenue.Id.Equals(venuesGUI.idFromTable)) {
                    venue = currVenue;
                }
            }
            tbVenueID.ReadOnly = true;
            tbVenueID.Text = "" + venuesGUI.idFromTable;
            tbName.Text = venue.Name;
            tbAddress.Text = venue.Address;
            tbZip.Text = ""+ venue.Zip;
            tbCity.Text = venue.City;
        }
    }
}
