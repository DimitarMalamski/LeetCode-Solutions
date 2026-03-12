# LeetCode Solutions
This repository contains my daily LeetCode problem-solving practice. It is part of my preparation for software engineering internships during my studies at Fontys University of Applied Sciences.

---
## Goals
- Strengthen knowledge of Data Structures & Algorithms;
- Build consistency by solving problems daily;
- Prepare for technical interviews;
- Track and showcase progress publicly;

---
## Repository Structure

```mathematica
leetcode-solutions/
│
├── Arrays/
├── Strings/
├── LinkedLists/
├── Trees/
├── DynamicProgramming/
└── ...
```

Each solution file includes:
  - Problem name + LeetCode link;
  - Clean, working code;

---
## Progress Tracker

```markdown
| Category            | Problems Solved |
| ------------------- | --------------- |
| Arrays              | 74              |
| Strings             | 34              |
| Linked Lists        | 10              |
| Trees / Graphs      | 25              |
| Dynamic Programming | 2               |
| Two Pointers        | 6               |
| Stack               | 4               |
| Math                | 35              |
| Bit Manipulation    | 7               |
| **Total**           | 197             |
```

*This will be updated as I progress with the problems*

---
## Example Solution Format
Each solution is structured for clarity and consistency, including the problem reference, a clean implementation, and (when relevant) an optimized approach.

### Example: Two Sum  
🔗 https://leetcode.com/problems/two-sum/  
🟢 Difficulty: Easy  

```csharp
// Problem 1. Two Sum
// Link: https://leetcode.com/problems/two-sum/
// Difficulty: Easy

class Solution
{
    static void Main (string[] args) {
      int[] nums = { 3,3 };
      int target = 6;
      var result = TwoSumImproved(nums, target);
      Console.WriteLine($"[{result[0]}, {result[1]}]");
    }

    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return null;
    }

    public int[] TwoSumImproved(int[] nums, int target)
    {
        Dictionary<int, int> map = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        return null;
    }
}
```
---
## Commit Style
  - `feat: add solution for Two Sum ( Arrays )`;
  - `feat: add solution for Valid Palindrome ( Strings )`;
  - `refactor: optimize Reverse Linked List solution`;

---
## Roadmap
  - Reach 200 problems solved;
