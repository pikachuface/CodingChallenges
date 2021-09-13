#include"ListNode.h"

class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
		ListNode* output = new ListNode();
		ListNode* Node = output;
		bool overflow = 0;
		do{
			int value = overflow;
			overflow = 0;
			if(l1!=nullptr)
			{
				value += l1 -> val;
				l1 = l1->next;
			}
			if(l2!=nullptr)
			{
				value += l2 -> val;
				l2 = l2->next;
			}
			if(value > 9)
			{
				overflow += 1;
				value-=10;	
			}
            
            Node->val = value;
            
			if(l1==nullptr && l2==nullptr && overflow == 0)
			{
				break;
			}
			
            Node->next = new ListNode();
			Node = Node->next;
			
		}while(true);

		return output;
    }
};

