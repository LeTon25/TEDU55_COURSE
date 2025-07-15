using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    public class ServiceConfiguration : IPrototype<ServiceConfiguration>
    {
        public string FileStorageUrl { get; set; }
        public string OperationSystem { get; set; }
        private string DbConnection { get; set; }

        public ServiceConfiguration Clone()
        {
            var clone = new ServiceConfiguration()
            {
                FileStorageUrl = FileStorageUrl,
                OperationSystem = OperationSystem,
                DbConnection = "Empty"
            };
            return clone;
        }

        public string PrintDetail()
        {
            return $"Storage URL : {this.FileStorageUrl} - OS: {this.OperationSystem} - DB Connection: {this.DbConnection}";
        }
    }
}
