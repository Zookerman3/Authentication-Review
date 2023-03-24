using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Pierres.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The item's description can't be empty!")]
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}