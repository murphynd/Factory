
using System;
using System.Collections.Generic;
namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Licenses = new HashSet<License>();
    }
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string Disc { get; set; }
    public virtual ICollection<License> Licenses { get; set; }
  }
}