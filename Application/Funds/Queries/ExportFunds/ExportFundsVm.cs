namespace Application.Funds.Queries.ExportFunds
{
  public class ExportFundsVm
  {
    public string FileName { get; set; }
    public string ContextType { get; set; }
    public byte[] Content { get; set; }
  }
}
