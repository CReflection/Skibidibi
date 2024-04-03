namespace Skibidibi
{
    public static class SkibidiExt
    {
        public static IEnumerable<ISkibidiService> GetStrongest(this List<ISkibidiService> skibidis)
        {
            var top3 = skibidis.OrderByDescending(s => s.Strenght).Take(3);
            return top3 ?? new List<ISkibidiService>();
        }
    }
}
