namespace InvoiceMenagment.Api.Models
{
    public class SupervisorAssignSector : BasicEntity
    {
        public int? SupervisorId { get; set; } 
        public LookUpName? Supervisor { get; set; } 

        public int? SectorId { get; set; } 
        public LookUpName? Sector { get; set; } 
    }
}
