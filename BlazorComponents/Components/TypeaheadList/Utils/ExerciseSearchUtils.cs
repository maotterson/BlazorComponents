using BlazorComponents.WASM.Components.TypeaheadList.Models;

namespace BlazorComponents.WASM.Components.TypeaheadList.Utils;

public static class ExerciseSearchUtils
{
    public static List<ExerciseSearchMatchingSubstring> GetMatchingSubstrings(string parentString, string substring)
    {
        List<ExerciseSearchMatchingSubstring> matchingSubstrings = new List<ExerciseSearchMatchingSubstring>();
        int index = 0;
        int substringLength = substring.Length;

        if(substring.Length == 0)
        {
            return matchingSubstrings;
        }

        while (index < parentString.Length)
        {
            index = parentString.IndexOf(substring, index, StringComparison.OrdinalIgnoreCase);
            if (index == -1)
                break;

            matchingSubstrings.Add(new ExerciseSearchMatchingSubstring
            {
                StartingIndex = index,
                EndingIndex = index + substringLength
            });

            index += substringLength;
        }

        return matchingSubstrings;
    }
}
