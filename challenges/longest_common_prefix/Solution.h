#include<string>
#include<vector>


using namespace std;

class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
       string out;
       char current;
       bool end = false;
       int i = 0;
       while(true)
	   {
   		   if(strs[0].size()>i)
           {
               current = strs[0][i];
           }
           else
                break;

           for(int x = 1; x < strs.size(); x++)
           {
               if(strs[x].size() <= i || current!=strs[x][i])
               {
                   end = true;
                   break;
               }
           }
           if(!end)
           {
                out+=current;
           }
			else
			   break;
           i++;
       }
       return out;
    }
};
