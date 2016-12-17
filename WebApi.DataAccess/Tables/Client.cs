using System.ComponentModel.DataAnnotations;

namespace WebApi.DataAccess.Tables
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string ClientCode { get; set; }

        public int MURegionId { get; set; }
        public MURegion MURegion { get; set; }
    }
}