using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminstrationAPI
{
    public static class FactoryPatterns<K,T> where T : class, K,new()
    {
        public static K GetInstance()
        {
            K obj;
            obj = new T();
            return obj;
        }
    }
}
