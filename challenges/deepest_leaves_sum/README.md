# Deepest leaves sum

- Filip Gajdušek 
- 15. 6. 2021
- Language: C++
- Web: LeetCode
- URL: https: //leetcode.com/problems/deepest-leaves-sum/
- Difficulty: **Medium**
---------------------------------------------------------

## Explanation
Given the root of a binary tree, return the sum of values of its deepest leaves.

**Example 1:**
```
Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
Output: 15
```
**Example 2**:
```
Input: root = [6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]
Output: 19
```
 

*Constraints:*

    The number of nodes in the tree is in the range [1, 104].
    1 <= Node.val <= 100

### Completed
Used recursive method which saved all node values, that didn't have any child. 
And then I just summed up all of the numbers in the lowest level.  
