using System;
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
            using (var context = new COVID19Entities())
            {
                var getSuspected = (from x in context.ContactTracings
                                    where x.Temp >= 38
                                    select x.FullName).Distinct();
                foreach (var item in getSuspected)
                {
                    cbSuspectedPeople.Items.Add(item);
                }
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lbRecords.Items.Clear();
            lbTier0.Items.Clear();
            lbTier1.Items.Clear();
            lbTier2.Items.Clear();
            lbTier3.Items.Clear();
            using (var context = new COVID19Entities())
            {
                if (cbSuspectedPeople.SelectedItem != null)
                {
                    var getContact = (from x in context.ContactTracings
                                      where x.FullName == cbSuspectedPeople.SelectedItem.ToString()
                                      select x.Contact).FirstOrDefault();
                    Route(getContact);
                }

            }
        }

        public void Route(string phoneNumber)
        {
            using (var context = new COVID19Entities())
            {
                var symptoms = (from x in context.ContactTracings
                                where x.Contact == phoneNumber
                                where x.Temp >= 38
                                orderby x.RegisterDateTime descending
                                select x.RegisterDateTime).FirstOrDefault().Date.AddDays(-14);

                var UserHistory = (from x in context.ContactTracings
                                   where x.Contact == phoneNumber
                                   where x.RegisterDateTime >= symptoms
                                   select x).ToList();

                var groupDates = (from x in UserHistory
                                  group x by x.RegisterDateTime.Date into y
                                  orderby y.Key descending
                                  select y);
                var list = new List<ContactTracing>();
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
                            lbRecords.Items.Add($"\tCurrent: IT-{contactTracing[i].Location.LocationFloor}-{contactTracing[i].Location.LocationUnitNumber} " +
                                $"Time in: {contactTracing[i].RegisterDateTime}");
                            lbRecords.Items.Add($"\t\tTravelled rooms: {String.Join(",", RouteTracing(contactTracing[i], contactTracing[i + 1]))}");

                            list.AddRange(getTier0(contactTracing[i], contactTracing[i + 1]));

                        }
                        else
                        {
                            lbRecords.Items.Add($"\tCurrent: IT-{contactTracing[i].Location.LocationFloor}-{contactTracing[i].Location.LocationUnitNumber} " +
                                $"Time in: {contactTracing[i].RegisterDateTime}");
                            list.AddRange(getTier0(contactTracing[i], null));

                        }
                    }

                }
                var groupList = (from x in list
                                 group x by x.Contact into y
                                 orderby y.Key.Count() descending
                                 select y);
                foreach (var tier0 in groupList)
                {
                    lbTier0.Items.Add($"{tier0.Key}({tier0.Key.Count()})");
                }

            }

        }

        public List<long> RouteTracing(ContactTracing source, ContactTracing destination)
        {
            var list = new List<long>();
            var checkSource = source.LocationID % 10;
            var checkDestination = destination.LocationID % 10;
            long firstRoomSource = 0;

            if (checkSource == 0)
            {
                firstRoomSource = source.LocationID - 9;
            }
            else
            {
                firstRoomSource = Convert.ToInt64(source.LocationID / 10) * 10 + 1;
            }
            
            long firstRoomDestination = 0;
            
            if (source.Location.LocationFloor == destination.Location.LocationFloor)
            {
                firstRoomDestination = firstRoomSource;
            }
            else if (checkDestination == 0)
            {
                firstRoomDestination = destination.LocationID - 9;
            }
            else
            {
                firstRoomDestination = Convert.ToInt64(destination.LocationID / 10) * 10 + 1;
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

        public List<ContactTracing> getTier0(ContactTracing contactTracing, ContactTracing nextTimeIn)
        {
            using (var context = new COVID19Entities())
            {
                if (nextTimeIn == null)
                {
                    var endHour = contactTracing.RegisterDateTime.Date + dtpTime.Value.TimeOfDay;
                    var getDirectContact = (from x in context.ContactTracings
                                            where x.Contact != contactTracing.Contact
                                            where x.LocationID == contactTracing.LocationID && x.RegisterDateTime >= contactTracing.RegisterDateTime && x.RegisterDateTime < endHour
                                            select x).ToList();
                    return getDirectContact;
                }
                else
                {
                    //Assumes infected takes 1 minute to travel to each room
                    var endTime = nextTimeIn.RegisterDateTime.AddMinutes(-1);
                    var getDirectContact = (from x in context.ContactTracings
                                            where x.Contact != contactTracing.Contact
                                            where x.LocationID == contactTracing.LocationID && x.RegisterDateTime >= contactTracing.RegisterDateTime && x.RegisterDateTime < endTime
                                            select x).ToList();
                    return getDirectContact;
                }

            }
        }

    }
}
