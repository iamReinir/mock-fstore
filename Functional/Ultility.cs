namespace Functional
{
    public static class Ultility
    {
        public static U[] Map<T, U>(T[] list, Func<T, U> transformation)
        {
            var result = new U[list.Length];
            for (int i = 0; i < list.Length; ++i)
            {
                result[i] = transformation(list[i]);
            }
            return result;
        }

        public static string ToSCV<TResult>(IEnumerable<TResult> toExport)
        {
            string res = "";
            bool need_delimiter = false;
            foreach (var props in typeof(TResult).GetProperties())
            {
                if (need_delimiter) { res += " , "; }
                res += props.Name;                                
                need_delimiter = true;
            }
            res += "\n";            
            foreach (var item in toExport) {
                need_delimiter = false;
                foreach (var prop in typeof(TResult).GetProperties())
                {
                    if (need_delimiter) res += " , ";
                    res += prop.GetValue(item);                    
                    need_delimiter = true;
                }
                res += "\n";
            }
            return res;
        }
    }

}