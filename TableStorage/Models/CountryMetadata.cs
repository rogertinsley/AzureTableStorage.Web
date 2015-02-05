using System;
using System.ComponentModel.DataAnnotations;

namespace TableStorage
{
    [MetadataType(typeof(CountryMetadata))]
    public partial class Country { }

    public class CountryMetadata
    {
        [Display(Name="Continent")]
        public string PartitionKey { get; set; }

        [Display(Name="Name")]
        public string RowKey { get; set; }

        [ScaffoldColumn(false)]
        public DateTimeOffset Timestamp { get; set; }

    }
}