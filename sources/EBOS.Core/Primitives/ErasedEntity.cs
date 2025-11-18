using EBOS.Core.Primitives.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EBOS.Core.Primitives;

public abstract class ErasedEntity : ISoftDelete
{
    [Required]
    public bool Erased { get; set; }
}
