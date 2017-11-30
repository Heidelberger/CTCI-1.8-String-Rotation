# CTCI 1.8 String Rotation
## Cracking the Coding Interview, Chapter 1 Problem 1.8

<B>Algo:</B>
<ol>
<li>Check if strings are null or empty.</li>
<li>Check if same length.</li>
<li>Double one string (concatenate it with itself).</li>
<li>Check if the doubled string contains the other string.</li>

<P>The doubling fixes the "word wrap" (AKA rotation) problem.

<B>Complexity: </B>
<P>Algorithm runs in O(N) time
<P>Every element must be touched once to check for a match.
<P>I'm assuming String.Contains() uses the <a href="https://en.wikipedia.org/wiki/Boyer%E2%80%93Moore_string_search_algorithm">Boyer-Moore algorithm</a>

<P>Algorithm requires O(N) space
<P>The method concatenates one of the strings to itself, requiring 2 characters of memory for every 1 character in that string.        

