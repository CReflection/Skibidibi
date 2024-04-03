using Microsoft.AspNetCore.Mvc;

namespace Skibidibi
{
    public interface ISkibidiService
    {


        Skibidi Add(Skibidi skibidi);
        bool Delete(int index);
        Skibidi Get(int index);
        IEnumerable<Skibidi> GetAll();
        int GetStrenght(int index);
        int SumTheStrongest();
    }
}