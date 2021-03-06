﻿using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
  public class Client : AuditableEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Fund> Funds { get; set; }
  }
}
