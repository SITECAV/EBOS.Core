using SIE.Core.Primitives.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SIE.Core.Primitives;

public abstract class ErasedEntity : ISoftDelete
{
    [Required]
    public bool Erased { get; set; }
}
