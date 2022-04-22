using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Outings_Repository
    {
      private readonly List<Outings> _outingsDatabase = new List<Outings>();
      private int _count = 0;
      public bool AddOutingToDatabase(Outings outings)
      {
          if (outings != null)
          {
              _count++;
              outings.ID = _count;
              _outingsDatabase.Add(outings);
              return true;
          }else
          {
              return false;
          }
      }
      public List<Outings> GetAllOutings()
      {
          return _outingsDatabase;
      }
      public Outings GetOutingsByID(int id)
      {
          foreach(Outings outings in _outingsDatabase)
          {
              if(outings.ID == id)
              {
                  return outings;
              }
          }
          return null;
      }
      public Outings GetOutingsByEventType(EventType eventType)
      {
          foreach(Outings outings in _outingsDatabase)
          {
            if(outings.EventType == eventType)
            {
                foreach(Outings outings1 in _outingsDatabase)
                {
                    return outings;
                }
            }
          }
          return null;
      }
      public bool UpdateStoreData(int outingID, Outings newOutingData)
      {
          Outings oldOutingData = GetOutingsByID(outingID);
          if(oldOutingData != null)
          {
              oldOutingData.EventType = newOutingData.EventType;
              oldOutingData.EventCostPerPerson = newOutingData.EventCostPerPerson;
              oldOutingData.EventCost = newOutingData.EventCost;
              oldOutingData.NumberAttended = newOutingData.NumberAttended;
              oldOutingData.Day = newOutingData.Day;
              oldOutingData.Month = newOutingData.Month;
              oldOutingData.Year = newOutingData.Year;
              return true;
          }
          else{
              return false;
          }
      }
      public bool RemoveOutingFromDatabase(int id)
      {
        var outings = GetOutingsByID(id);
        if (outings != null)
        {
            _outingsDatabase.Remove(outings);
            return true;
        }
        else 
        {
            return false;
        }
      }
    public double GetTotalCostByEventType(EventType eventType)
    {
        double totalCost = 0;
        foreach(var outing in _outingsDatabase)
        {
            if(outing.EventType == eventType)
            {
                totalCost += outing.EventCost;
            }
        }
        return totalCost;
    }
    }
