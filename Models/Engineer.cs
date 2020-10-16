using System.Collections.Generic;
namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string Disc { get; set; }
    public virtual ICollection<License> Licenses { get; set; }
  }
}