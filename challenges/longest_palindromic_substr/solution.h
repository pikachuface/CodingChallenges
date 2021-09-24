#include <string>

class Solution {
public:
    std::string longestPalindrome(std::string s) {
        int index_L = 0;
        int index_R = s.length();

        while(index_L!=index_R)
        {
            if(s[index_L]==s[index_R])
            {
                while(true)
                {
                       
                }
            }




        }
        return s.substr(index_L, (index_R-index_L)+1);
    }
};