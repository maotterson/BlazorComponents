using BlazorComponents.WASM.Data.Models;

namespace BlazorComponents.WASM.Data.Utils;

public static class MuscleGroupCategoryUtils
{
    public static MuscleGroup Pectorals = new MuscleGroup { Name = "Pectorals", Slug = "pectorals", MuscleGroupCategory = MuscleGroupCategory.Chest };
    public static MuscleGroup Abdominals = new MuscleGroup { Name = "Abdominals", Slug = "abdominals", MuscleGroupCategory = MuscleGroupCategory.Core };
    public static MuscleGroup Obliques = new MuscleGroup { Name = "Obliques", Slug = "obliques", MuscleGroupCategory = MuscleGroupCategory.Core };
    public static MuscleGroup SpinalErectors = new MuscleGroup { Name = "SpinalErectors", Slug = "spinal-erectors", MuscleGroupCategory = MuscleGroupCategory.Back };
    public static MuscleGroup Deltoids = new MuscleGroup { Name = "Deltoids", Slug = "deltoids", MuscleGroupCategory = MuscleGroupCategory.Shoulders };
    public static MuscleGroup Trapezius = new MuscleGroup { Name = "Trapezius", Slug = "trapezius", MuscleGroupCategory = MuscleGroupCategory.Shoulders };
    public static MuscleGroup Lats = new MuscleGroup { Name = "Lats", Slug = "lats", MuscleGroupCategory = MuscleGroupCategory.Back };
    public static MuscleGroup Biceps = new MuscleGroup { Name = "Biceps", Slug = "biceps", MuscleGroupCategory = MuscleGroupCategory.Arms };
    public static MuscleGroup Triceps = new MuscleGroup { Name = "Triceps", Slug = "triceps", MuscleGroupCategory = MuscleGroupCategory.Arms };
    public static MuscleGroup HipFlexors = new MuscleGroup { Name = "Hip Flexors", Slug = "hip-flexors", MuscleGroupCategory = MuscleGroupCategory.Core };
    public static MuscleGroup Calves = new MuscleGroup { Name = "Calves", Slug = "calves", MuscleGroupCategory = MuscleGroupCategory.Legs };
    public static MuscleGroup Quadriceps = new MuscleGroup { Name = "Quadriceps", Slug = "quadriceps", MuscleGroupCategory = MuscleGroupCategory.Legs };
    public static MuscleGroup Hamstrings = new MuscleGroup { Name = "Hamstrings", Slug = "hamstrings", MuscleGroupCategory = MuscleGroupCategory.Legs };
    public static MuscleGroup Glutes = new MuscleGroup { Name = "Glutes", Slug = "glutes", MuscleGroupCategory = MuscleGroupCategory.Legs };

    public static List<MuscleGroup> MUSCLE_GROUP_LIST = new List<MuscleGroup>
    {
        Pectorals, Abdominals, Obliques, SpinalErectors, Deltoids, Trapezius, Lats, Biceps, Triceps, HipFlexors, Calves, Quadriceps, Hamstrings, Glutes
    };
}
