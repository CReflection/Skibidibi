using Microsoft.AspNetCore.Mvc;

namespace Skibidibi
{
    public abstract class BaseSkibidi : ISkibidiService
    {

        public string? Name { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }
        public float Raiting { get; set; }
        protected static List<ISkibidiService> _skibidiList = new List<ISkibidiService>
        {
            new SkibidiService { Name = "Skibidi1", Strenght = 10, Speed = 5, Raiting = 8 },
            new SkibidiService { Name = "Skibidi2", Strenght = 8, Speed = 7, Raiting = 9 },
        };
        public abstract ISkibidiService Add(ISkibidiService skibidi);
        public abstract bool Delete(int index);
        public abstract ISkibidiService Get(int index);
        public virtual IEnumerable<ISkibidiService> GetAll()
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
