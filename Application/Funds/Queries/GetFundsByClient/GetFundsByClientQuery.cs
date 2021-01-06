using Application.Funds.Queries.GetFunds;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Funds.Queries.GetFundsByClient
{
  public class GetFundsByClientQuery: IRequest<List<FundsDto>>
  {
    public int ClientId { get; set; }
  }

  public class GetFundsByClientQueryHandler : IRequestHandler<GetFundsByClientQuery, List<FundsDto>>
  {
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetFundsByClientQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    public async Task<List<FundsDto>> Handle(GetFundsByClientQuery request, CancellationToken cancellationToken)
    {
      return await _context.Funds
              .AsNoTracking()
              .Where(f => f.ClientId == request.ClientId)
              .ProjectTo<FundsDto>(_mapper.ConfigurationProvider)              
              .OrderBy(c => c.Name)
              .ToListAsync(cancellationToken);
    }
  }
}
