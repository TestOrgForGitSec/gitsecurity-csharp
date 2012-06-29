using System;
using System.IO;

namespace SharpRepository.Tests.Integration.Data
{
    public class MongoDbDataDirectoryFactory
    {
        private static int _num = 1;

        public static string Build(string type)
        {
            var connectionString = String.Format("mongodb://127.0.0.1");
            _num++; 
            
            return connectionString;
        }
    }
}