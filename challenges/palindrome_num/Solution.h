#include<string>

class Solution {
public:
    static bool isPalindrome(int x) {
        std::string number(std::to_string(x));
        for(int i = 0; i < number.length()/2; i++)
        {
            if(number[i]!=number[number.length()-1-i])
            {
                return false;
            }
        }        
        return true;
    }
};
