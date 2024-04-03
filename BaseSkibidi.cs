using Microsoft.AspNetCore.Mvc;

namespace Skibidibi
{
    public abstract class BaseSkibidi : ISkibidiService
    {

       
        protected  List<Skibidi> _skibidiList = new List<Skibidi>
        {
            new Skibidi { Name = "Skibidi1", Strenght = 10, Speed = 5, Raiting = 8 },
            new Skibidi { Name = "Skibidi2", Strenght = 8, Speed = 7, Raiting = 9 },
        };
        public abstract Skibidi Add(Skibidi skibidi);
        public abstract bool Delete(int index);
        public abstract Skibidi Get(int index);
        public virtual IEnumerable<Skibidi> GetAll()
        {
            return _skibidiList;
        }
        public abstract int GetStrenght(int index);

        public virtual int SumTheStrongest()
        {
            var top3 = _skibidiList.GetStrongest();
            return top3.Sum(s => s.Strenght);
        }
    }
}
