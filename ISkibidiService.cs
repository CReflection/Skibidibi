using Microsoft.AspNetCore.Mvc;

namespace Skibidibi
{
    public interface ISkibidiService
    {
        string? Name { get; set; }
        int Strenght { get; set; }
        int Speed { get; set; }
        float Raiting { get; set; }

        ISkibidiService Add(ISkibidiService skibidi);
        bool Delete(int index);
        ISkibidiService Get(int index);
        IEnumerable<ISkibidiService> GetAll();
        int GetStrenght(int index);
        int SumTheStrongest();
    }
}