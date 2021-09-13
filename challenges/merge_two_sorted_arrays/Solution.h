struct ListNode {
  int val;
  ListNode *next;
  ListNode() : val(0), next(nullptr) {}
  ListNode(int x) : val(x), next(nullptr) {}
  ListNode(int x, ListNode *next) : val(x), next(next) {}
};

class Solution {
public:
  ListNode *mergeTwoLists(ListNode *l1, ListNode *l2) {
    if (l1 == nullptr && l2 == nullptr)
      return nullptr;
    ListNode *output = new ListNode();
    ListNode *temp = output;
    while (true) {
      if (l1 != nullptr && l2 != nullptr) {
        if (l1->val < l2->val) {
          temp->val = l1->val;
          l1 = l1->next;
        } else {
          temp->val = l2->val;
          l2 = l2->next;
        }
      } else if (l1 == nullptr) {
        temp->val = l2->val;
        l2 = l2->next;
      } else if (l2 == nullptr) {
        temp->val = l1->val;
        l1 = l1->next;
      }
      temp = temp->next;
    }
    return output;
  }
};