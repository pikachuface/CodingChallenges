#include<vector>
#include<iostream>

using namespace std;

class Node {
public:
    int val;
    vector<Node*> children;

    Node() {}

    Node(int _val) {
        val = _val;
    }

    Node(int _val, vector<Node*> _children) {
        val = _val;
        children = _children;
    }
};

class Solution {
public:
    vector<vector<int>> levelOrder(Node* root) {
        vector<vector<int>> output(0);
        if(root!=nullptr) 
            Calculate(root, 0, output);
        return output;
    }
private:
    void Calculate(Node* root, int level, vector<vector<int>>& out) 
    {
        if(out.size()<=level)
            out.push_back(vector<int>());
        out[level].push_back(root->val);
        for(u_int i = 0; i < root->children.size(); i++)
        {
            Calculate(root->children[i], level+1, out);
        }           
    }
};
