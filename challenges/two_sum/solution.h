#include <map>
#include <vector>

using namespace std;

class Solution {
public:
  vector<int> twoSum(vector<int> &nums, int target) {
    map<int, int> seen_nums;
    for (int i = 0; i < nums.size(); i++) {
      if (seen_nums.find(target - nums[i]) != seen_nums.end()) {
        return {seen_nums[target - nums[i]], i};
      } else {
        seen_nums[nums[i]] = i;
      }
    }
    return {};
  }
};