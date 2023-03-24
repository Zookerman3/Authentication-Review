using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pierres.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The item's description can't be empty!")]
    public string Description { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}