#include "solution.h"
#include <iterator>
#include <iostream>
#include <string>

int main ()
{
    std::string input = "abba";
    Solution sol;
    std::string output = sol.longestPalindrome(input);

    std::cout<<"Input is: "<<input<<std::endl;
    std::cout<<"Output is: "<<output<<std::endl;
    return 0;
}

