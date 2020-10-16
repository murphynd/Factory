
using System;
using System.Collections.Generic;
namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string Name { get; set; }
    public string Disc { get; set; }
    public virtual ICollection<License> Licenses { get; set; }
  }
}