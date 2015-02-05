using Microsoft.WindowsAzure.Storage.Table.DataServices;

namespace TableStorage
{
    public partial class Country : TableServiceEntity
    {
        public Country(string name, string continent)
        {
            PartitionKey = continent;
            RowKey = name;
        }

        public Country()
        {

        }
        
        public string Language { get; set; }
        public string Population { get; set; }
    }
}