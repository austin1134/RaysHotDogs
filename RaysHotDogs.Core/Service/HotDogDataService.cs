using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Repository;

namespace RaysHotDogs.Core.Service
{
    public class HotDogDataService
    {
        private static HotDogRepository hotDogRepository = new HotDogRepository();

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            return GetHotDogsForGroup(hotDogGroupId);
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            return GetFavoriteHotDogs();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            return GetHotDogById(hotDogId);
        } 
    }
}
