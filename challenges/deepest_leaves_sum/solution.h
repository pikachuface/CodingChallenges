#pragma once
#include <vector>

using namespace std;

struct TreeNode {
  int val;
  TreeNode *left;
  TreeNode *right;
  TreeNode() : val(0), left(nullptr), right(nullptr) {}
  TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
  TreeNode(int x, TreeNode *left, TreeNode *right)
      : val(x), left(left), right(right) {}
};

class Solution {
public:
  int deepestLeavesSum(TreeNode *root) {
    vector<vector<int>> levels;
    Calculate(root, 0, levels);
    int sum = 0;
    for (int i = 0; i < levels[levels.size() - 1].size(); i++)
      sum += levels[levels.size() - 1][i];
    return sum;
  }

  void Calculate(TreeNode *root, int level, vector<vector<int>> &out) {
    if (out.size() <= level)
      out.push_back(vector<int>());
    if (root->left != nullptr)
      Calculate(root->left, level + 1, out);
    if (root->right != nullptr)
      Calculate(root->right, level + 1, out);
    if (root->right == nullptr && root->left == nullptr)
      out[level].push_back(root->val);
  }
};