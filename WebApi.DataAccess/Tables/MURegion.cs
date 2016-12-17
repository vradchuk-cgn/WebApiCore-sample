using System.ComponentModel.DataAnnotations;

namespace WebApi.DataAccess.Tables
{
    public class MURegion
    {
        [Key]
        private int MURegionId { get; set; }
        public string MURegionName { get; set; }
    }
}