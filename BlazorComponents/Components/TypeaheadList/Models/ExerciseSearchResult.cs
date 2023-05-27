﻿using BlazorComponents.WASM.Data.Models;

namespace BlazorComponents.WASM.Components.TypeaheadList.Models;

public class ExerciseSearchResult
{
    public Exercise Exercise { get; set; } = default!;
    public List<(int, int)> MatchedSearchIndices { get; set; } = default!;
}
