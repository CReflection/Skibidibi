using Microsoft.AspNetCore.Mvc;

namespace Skibidibi
{
    public class SkibidiService3 : BaseSkibidi
    {
        public override ISkibidiService Add([FromBody] ISkibidiService skibidi)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int index)
        {
            throw new NotImplementedException();
        }

        public override ISkibidiService Get(int index)
        {
            throw new NotImplementedException();
        }

        public override int GetStrenght(int index)
        {
            throw new NotImplementedException();
        }
    }
}
