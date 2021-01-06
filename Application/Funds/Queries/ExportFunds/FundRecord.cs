using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Funds.Queries.ExportFunds
{
  public class FundRecord: IMapFrom<Fund>
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
