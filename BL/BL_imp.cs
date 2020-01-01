using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;

namespace BL
{
    class BL_imp : IBL
    {
        IDAL dal = FactoryDal.getDal();

        //------------------------GuestRequest------------------------------
        public void addGuestRequest(GuestRequest guestRequest)
        {
            dal.addGuestRequest(guestRequest);
        }
        public void updateGuestRequest(GuestRequest guestRequest, GuestRequest guestRequestUpdate)
        {
            dal.updateGuestRequest(guestRequest, guestRequestUpdate);
        }
        public void deleteGuestRequest(GuestRequest guestRequest)
        {
            dal.deleteGuestRequest(guestRequest);
        }

        //-----------------------HostingUnit--------------------------------
        public void addHostingUnit(HostingUnit hostingUnit)
        {
            dal.addHostingUnit(hostingUnit);
        }
        public void updateHostingUnit(HostingUnit hostingUnit, HostingUnit hostingUnitUpdate)
        {
            dal.updateHostingUnit(hostingUnit, hostingUnitUpdate);
        }
        public void deleteHostingUnit(HostingUnit hostingUnit)
        {
            dal.deleteHostingUnit(hostingUnit);
        }

        //-----------------------Order--------------------------------
        public void addOrder(Order order)
        {
            dal.addOrder(order);
        }
        public void updateOrder(Order order, Order orderUpdate)
        {
            dal.updateOrder(order, orderUpdate);
        }

        //-----------------------gets--------------------------------
        public List<GuestRequest> GetGuestRequests()
        {
            return dal.GetGuestRequests();
        }
        public List<HostingUnit> getHostingUnits()
        {
            return dal.getHostingUnits();
        }
        public List<Order> GetOrders()
        {
            return dal.GetOrders();
        }
        public List<Host> GetHosts()
        {
            return dal.GetHosts();
        }

        /*-------------------------------------------------*/

        public int daysBetween(DateTime date1, DateTime date2)
        {
            if (date1 > date2)
                return (date1 - date2).Days;
            return (date2 - date1).Days;

        }
        public int daysBetween(DateTime date)
        {
            if (DateTime.Now > date)
                return (DateTime.Now - date).Days;
            return (date - DateTime.Now).Days;
        }

        public List<HostingUnit> freeHostingUnits(DateTime dateTime, int day)
        {
            var list = from unit in getHostingUnits()
                       where unit.AvailableOnDate(dateTime, day)
                       select unit;

            return list.ToList();
        }

        public IEnumerable<IGrouping<Location, GuestRequest>> GuestRequestByLocation()
        {
            IEnumerable<IGrouping<Location, GuestRequest>> guestRequests = from guestRequest in dal.GetGuestRequests()
                                                                           group guestRequest by guestRequest.location;
            return guestRequests;
        }

        public IEnumerable<IGrouping<Location, HostingUnit>> HostingUnitByLocation()
        {
            IEnumerable<IGrouping<Location, HostingUnit>> hostingUnits = from hostingUnit in dal.getHostingUnits()
                                                                         group hostingUnit by hostingUnit.location;
            return hostingUnits;
        }

        public IEnumerable<IGrouping<int, GuestRequest>> GuestRequestByVacationers()
        {
            IEnumerable<IGrouping<int, GuestRequest>> guestRequests = from guestRequest in dal.GetGuestRequests()
                                                                      group guestRequest by (guestRequest.Adults + guestRequest.Children);
            return guestRequests;
        }

        public List<GuestRequest> guestRequests(Func<GuestRequest, bool> func)
        {
            var list = from guestRequest in dal.GetGuestRequests()
                       where func
                       select guestRequest;

            return (List<GuestRequest>) list;
        }

        public IEnumerable<IGrouping<int, Host>> HostByhostingUnitNum()
        {
            IEnumerable<IGrouping<int, Host>> hosts = from host in dal.GetHosts()
                                                      group host by host.hostingUnits.Count;

            return hosts;
        }

        public int numOfOrders(GuestRequest guestRequest)
        {
            throw new NotImplementedException();
        }

        public int OrdersSentOrClosed(GuestRequest guestRequest)
        {
            throw new NotImplementedException();
        }

        public List<Order> timePast(int day)
        {
            throw new NotImplementedException();
        }  
       
    }
}
