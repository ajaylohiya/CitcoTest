﻿using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Funds.Queries.GetFunds
{
  public class FundsDto: IMapFrom<Fund>
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
