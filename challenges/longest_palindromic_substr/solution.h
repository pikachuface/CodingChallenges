#include <iostream>
#include <string>

class Solution {
public:
  std::string longestPalindrome(std::string s) {

    std::string output = s.substr(0, 1);

    for (int index_L = 0; index_L < s.length(); index_L++) {
      for (int index_R = s.length() - 1; index_L != index_R; index_R--) {
        if (s[index_L] == s[index_R]) {
          std::string attempt = s.substr(index_L, (index_R - index_L) + 1);
          if (attempt.length() > output.length()) {
            if (isPalindrome(attempt)) {
              output = attempt;
            }
          }
        }
      }
    }
    return output;
  }

private:
  const bool isPalindrome(const std::string &input) {
    for (int i = 0; i < input.length() / 2; i++) {
      if (input[i] != input[(input.length() - 1) - i])
        return false;
    }
    return true;
  }
};