namespace Skibidibi
{
    public static class SkibidiExt
    {
        public static IEnumerable<Skibidi> GetStrongest(this List<Skibidi> skibidis)
        {
            var top3 = skibidis.OrderByDescending(s => s.Strenght).Take(3);
            return top3 ?? new List<Skibidi>();
        }
    }
}
