# CTCI 1.8 String Rotation
## Cracking the Coding Interview, Chapter 1 Problem 1.8

Algo:
1. Check if strings are null or empty. 
2. Check if same length.
3. Double one string (concatenate it with itself)
3. Check if the doubled string contains the other string

The doubling fixes the "word wrap" (AKA rotation) problem.

<B>Complexity: </B>
<P>Algorithm runs in O(N) time
            Every element must be touched once to check for a match.
            I'm assuming String.Contains() uses the <a href="https://en.wikipedia.org/wiki/Boyer%E2%80%93Moore_string_search_algorithm">Boyer-Moore algorithm</a>

            <P>Algorithm requires O(N) space
            The method concatenates one of the strings to itself, requiring
            2 characters of memory for every 1 character in that string.        

