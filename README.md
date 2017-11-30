# CTCI 1.8 String Rotation
## Cracking the Coding Interview, Chapter 1 Problem 1.8

Check if strings are null or empty. Check if same length.

Double one of the strings and see if it contains the other (fixes 
"word wrap" (AKA rotation) problem.
 
Complexity: Algorithm runs in O(N) time
            Every element must be touched once to check for a match.
            I'm assuming String.Contains() uses the Boyer-Moore algorithm.
            https://en.wikipedia.org/wiki/Boyer%E2%80%93Moore_string_search_algorithm

            Algorithm requires O(N) space
            The method concatenates one of the strings to itself, requiring
            2 characters of memory for every 1 character in that string.        
