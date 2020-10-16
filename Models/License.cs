namespace Factory.Models
{
  public class License
  {
    public int LicenseId { get; set; }
    public int EngineerId { get; set; }
    public int MachineId { get; set; }
    public virtual Machine Machine { get; set; }
    public virtual Engineer Engineer { get; set; }
  }
}