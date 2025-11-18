using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBOS.Core.Primitives;

/// <summary>
/// Clase base práctica para entidades que requieren auditoría.
/// Implementa ISoftAuditable; las entidades del dominio pueden heredar de esta clase.
/// </summary>
public abstract class BaseEntity : ErasedEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
}
