﻿using BlazorComponents.WASM.Data.Models;

namespace BlazorComponents.WASM.Components.TypeaheadList.Models;

public class ExerciseSearchResultItem
{
    public Exercise Exercise { get; set; } = default!;
    public Queue<ExerciseSearchMatchingSubstring> MatchingSubstrings { get; set; } = default!;
}
