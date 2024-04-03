using Microsoft.AspNetCore.Mvc;

namespace Skibidibi
{
    public class SkibidiService : BaseSkibidi
    {

       

        public override Skibidi Get(int index)
        {
            if (index >= 0 && index < _skibidiList.Count)
            {
                return _skibidiList[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// asdasdas
        /// </summary>
        /// <param name="skibidi"></param>
        /// <returns></returns>
        public override Skibidi Add(Skibidi skibidi)
        {
            _skibidiList.Add(skibidi);
            //return CreatedAtAction(nameof(Add), new {index = _skibidiList.Count - 1}, skibidi);
            return skibidi;
        }

        public override bool Delete(int index)
        {
            if (index >= 0 && index < _skibidiList.Count)
            {
                _skibidiList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetStrenght(int index)
        {
            return _skibidiList[index].Strenght;
        }

        
    }
}
