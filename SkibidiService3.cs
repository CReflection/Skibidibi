using Microsoft.AspNetCore.Mvc;

namespace Skibidibi
{
    public class SkibidiService3 : BaseSkibidi
    {
        public override Skibidi Add([FromBody] Skibidi skibidi)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int index)
        {
            throw new NotImplementedException();
        }

        public override Skibidi Get(int index)
        {
            throw new NotImplementedException();
        }

        public override int GetStrenght(int index)
        {
            throw new NotImplementedException();
        }
    }
}
