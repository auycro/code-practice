https://codingcompetitions.withgoogle.com/codejam/round/00000000002017f7/0000000000201847#problem

Input
The first line of the input gives the number of test cases, T. T test cases follow. Each consists of one line with a string S and an integer K. S represents the row of pancakes: each of its characters is either + (which represents a pancake that is initially happy side up) or - (which represents a pancake that is initially blank side up).

Output
For each test case, output one line containing Case #x: y, where x is the test case number (starting from 1) and y is either IMPOSSIBLE if there is no way to get all the pancakes happy side up, or an integer representing the the minimum number of times you will need to use the oversized pancake flipper to do it.

Limits
Time limit: 20 seconds per test set.
Memory limit: 1 GB.
1 ≤ T ≤ 100.
Every character in S is either + or -.
2 ≤ K ≤ length of S.
Small dataset (Test Set 1 - Visible)
2 ≤ length of S ≤ 10.
Large dataset (Test Set 2 - Hidden)
2 ≤ length of S ≤ 1000.

Sample

Input            Output
 
3
---+-++- 3       Case #1: 3
+++++ 4          Case #2: 0
-+-+- 4          Case #3: IMPOSSIBLE

