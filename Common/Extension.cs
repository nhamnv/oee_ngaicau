using System.Data;

namespace Common
{
    public static class Extension
    {
        /// <summary>
        /// nhamnv - convert datatable to list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        private static List<T> ConvertDataTableToList<T>(DataTable dt) where T : new()
        {
            List<T> list = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T obj = new T();
                foreach (DataColumn col in dt.Columns)
                {
                    var prop = obj.GetType().GetProperty(col.ColumnName);
                    if (prop != null && row[col] != DBNull.Value)
                        prop.SetValue(obj, row[col]);
                }
                list.Add(obj);
            }
            return list;
        }

        /// <summary>
        /// nhamnv - Clone a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listToClone"></param>
        /// <returns></returns>
        public static List<T> Clone<T>(this List<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }

}
