namespace Common.Utility
{
    public static class Extensions
    {
        //public static IEnumerable<T> Clone<T>(IEnumerable<T> source)
        //{
        //    try
        //    {
        //        var serialized = JsonConvert.SerializeObject(source);
        //        return JsonConvert.DeserializeObject<List<T>>(serialized);
        //    }
        //    catch (Exception)
        //    {
        //        return new List<T>();
        //    }
        //}

        /// <summary>
        /// Clone 1 object dạng list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listToClone"></param>
        /// <returns></returns>
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

        /// <summary>
        /// Clone 1 nhé
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="oldList"></param>
        /// <returns></returns>
        public static List<T> Clone<T>(IEnumerable<T> oldList)
        {
            return new List<T>(oldList);
        }
    }
}
