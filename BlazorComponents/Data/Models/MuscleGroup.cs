using System.Runtime.Serialization;

namespace BlazorComponents.WASM.Data.Models;

public enum MuscleGroup
{
    [EnumMember(Value = "pectorals")]
    Pectorals,
    [EnumMember(Value = "abdominals")]
    Abdominals,
    [EnumMember(Value = "obliques")]
    Obliques,
    [EnumMember(Value = "spinal-erectors")]
    SpinalErectors,
    [EnumMember(Value = "deltoids")]
    Deltoids,
    [EnumMember(Value = "trapezius")]
    Trapezius,
    [EnumMember(Value = "lats")]
    Lats,
    [EnumMember(Value = "biceps")]
    Biceps,
    [EnumMember(Value = "triceps")]
    Triceps,
    [EnumMember(Value = "hip-flexors")]
    HipFlexors,
    [EnumMember(Value = "calves")]
    Calves,
    [EnumMember(Value = "quadriceps")]
    Quadriceps,
    [EnumMember(Value = "hamstrings")]
    Hamstrings,
    [EnumMember(Value = "glutes")]
    Glutes
}
