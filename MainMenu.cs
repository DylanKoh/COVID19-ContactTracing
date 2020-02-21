﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID19_ContactTracing
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {


        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lbRecords.Items.Clear();
            using (var context = new COVID19Entities())
            {
                Route(txtPhoneNumber.Text);
            }
        }
       
        public void Route(string phoneNumber)
        {
            using (var context = new COVID19Entities())
            {
                var symptoms = (from x in context.ContactTracings
                                where x.Contact == phoneNumber
                                where x.Temp > 38
                                orderby x.RegisterDateTime descending
                                select x.RegisterDateTime).FirstOrDefault().Date.AddDays(-14);

                var UserHistory = (from x in context.ContactTracings
                                   where x.Contact == phoneNumber
                                   where x.RegisterDateTime >= symptoms
                                   select x).ToList();

                var groupDates = (from x in UserHistory
                                  group x by x.RegisterDateTime.Date into y
                                  select y);

                foreach (var item in groupDates)
                {
                    var contactTracing = new List<ContactTracing>();
                    lbRecords.Items.Add(item.Key);
                    foreach (var records in item)
                    {
                        contactTracing.Add(records);
                    }
                    for (int i = 0; i <= contactTracing.Count() - 1; i++)
                    {
                        if (i != contactTracing.Count() - 1)
                        {
                            lbRecords.Items.Add($"\tCurrent: {contactTracing[i].Location.LocationFloor}-{contactTracing[i].Location.LocationUnitNumber} " +
                                $"Time in: {contactTracing[i].RegisterDateTime} Travelled rooms: {String.Join(",",RouteTracing(contactTracing[i], contactTracing[i + 1]))}");
                        }
                        else
                        {
                            lbRecords.Items.Add($"\tCurrent: {contactTracing[i].Location.LocationFloor}-{contactTracing[i].Location.LocationUnitNumber} " +
                                $"Time in: {contactTracing[i].RegisterDateTime}");
                        }
                    }
                    
                }

            }

        }

        public List<long> RouteTracing(ContactTracing source, ContactTracing destination)
        {
            var list = new List<long>();

            var firstRoomSource = Convert.ToInt64(source.LocationID / 10) * 10 + 1;
            var checkDestination = destination.LocationID % 10;
            long firstRoomDestination = 0;
            if (checkDestination != 0)
            {
                firstRoomDestination = Convert.ToInt64(destination.LocationID / 10) * 10 + 1;
            }
            else
            {
                firstRoomDestination = firstRoomSource;
            }
            if (firstRoomSource != firstRoomDestination)
            {
                for (long i = source.LocationID; i >= firstRoomSource; i--)
                {
                    list.Add(i);
                }

                for (long i = firstRoomDestination; i <= destination.LocationID; i++)
                {
                    list.Add(i);
                }
                return list;
            }
            else
            {
                if (source.LocationID < destination.LocationID)
                {
                    for (long i = source.LocationID; i <= destination.LocationID; i++)
                    {
                        list.Add(i);
                    }
                    return list;
                }
                else
                {
                    for (long i = source.LocationID; i >= destination.LocationID; i--)
                    {
                        list.Add(i);
                    }
                    return list;
                }
                
            }
            
        }

    }
}
