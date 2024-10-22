using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class BuilderDesignPattern
    {
    }
    public interface IKeyValueCollectionBuider
    {
        IKeyValueCollectionBuider Add(string key, string value);
    }

    public class FormBuilder : IKeyValueCollectionBuider
    {
        private StringBuilder _formBuilder = new StringBuilder();
        public IKeyValueCollectionBuider Add(string key, string value)
        {
            _formBuilder.Append($"the key is {key}");
            _formBuilder.Append($"and the value is {value}");
            return this;
        }
        public string build()
        {
            var str = _formBuilder.ToString();
            Console.WriteLine($"have built a string {str}");
            return str;
        }
    }

    public class QueryBuilder : IKeyValueCollectionBuider
    {
        private StringBuilder _queryBuilder = new StringBuilder();
        public IKeyValueCollectionBuider Add(string key, string value)
        {
            _queryBuilder.Append(key);
            _queryBuilder.Append("-");
            _queryBuilder.Append(Uri.EscapeDataString(value) );
            return this;
        }

        public string build()
        {
            var str = _queryBuilder.ToString();
            Console.WriteLine($"have built a string {str}");
            return str;
        }
    }
    public class DictionaryBuilder : IKeyValueCollectionBuider
    {
        private Dictionary<string, string> _dictBuilder = new Dictionary<string, string>();
        public IKeyValueCollectionBuider Add(string key, string value)
        {
            _dictBuilder[key] = value;
            return this;
        }

        public string build()
        {
            foreach (var a in _dictBuilder)
            {
                Console.WriteLine($"a.key = {a.Key} = a.value = {a.Value}");
            }
            return "done";
        }
    }

    public class ExecMain
    {
        public void BuilderDpExecProcess()
        {
            //main
            QueryBuilder queryBuilder = new QueryBuilder();
            ConstructionProcess(queryBuilder);
            queryBuilder.build();
            Console.WriteLine("making Query Builder");
            FormBuilder formBuilder = new FormBuilder();
            ConstructionProcess(formBuilder);
            formBuilder.build();

            DictionaryBuilder dicBuilder = new DictionaryBuilder();
            ConstructionProcess(dicBuilder);
            dicBuilder.build();

        }
        public void ConstructionProcess(IKeyValueCollectionBuider builder)
        {
            builder.Add("make", "Lada")
                .Add("color", "red")
                .Add("description" , "Used")
                .Add("year", 1993.ToString());
        }
    }
    

}
