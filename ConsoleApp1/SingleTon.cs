using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MemoryCache
    {
        private static MemoryCache _cache;
        private static int i = 0;
        private static object _cachelock = new object();
        // constructor is private 
        //cant create via new keyword
        private MemoryCache()
        {
            i++;
            Console.WriteLine($"Calling Constructor {i}");
        }

        //static constructor so 1 instance can be returned 
        /// <summary>
        /// as soom your application start static ctor is caled so 1 instance created at the run time 
        /// 1000 singleton time consuming
        /// </summary>  
        //static MemoryCache()
        //{
        //    _cache = new MemoryCache();
        //}

        //create or return an existing instance
        public static MemoryCache Create()
        {
            //return _cache ?? (_cache = new MemoryCache());
            if (_cache == null)
            {
                lock (_cachelock)
                {
                    if (_cache == null)
                    {
                        return _cache = new MemoryCache();
                    }
                }   
            }


            return _cache;
        }
    }
}
