using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  public class Fund: AuditableEntity
  {
    public int Id { get; set; }    
    public string Name { get; set; }

    [ForeignKey("Client")]
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
  }
}
