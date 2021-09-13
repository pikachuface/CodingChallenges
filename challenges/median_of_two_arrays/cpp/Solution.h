#include<vector>
#include<cmath>
#include<iostream>

using namespace std;

class Solution {
public:
    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2) {
        int sortedArray [nums1.size()+ nums2.size()];
        int IndexA = 0;
        while(true)
        {
            int index1 = 0;
            int index2 = 0;


            if(index1+1==nums1.size() && index2+1== nums2.size() )
            {
                break;
            }


            if(nums1.size()>index1 && nums2.size()>index2)
            {

                if( nums1[index1] < nums2[index2])
                {
                    sortedArray[IndexA++] = nums1[index1++];
                    std::cout<<nums1[index1-1]<<endl;
                }
                else
                {
                   sortedArray[IndexA++] = nums2[index2++];
                   std::cout<<nums2[index2-1]<<endl;
                }
            }
            else if(nums1.size()==index1+1&&nums2.size()==index2+1)
            {
                sortedArray[IndexA++] = nums2[index2++];
                std::cout<<nums2[index2-1]<<endl;
            }
            else if(nums2.size()==index2+1&&nums1.size()==index1+1)
            {
                sortedArray[IndexA++] = nums1[index1++];
                std::cout<<nums1[index1-1]<<endl;
            }



                        
            

        }

        if(IndexA+1 % 2 == 1)
        {
               return sortedArray[IndexA/2+1];  
        }
        else 
        {
            int half = (IndexA+1)/2;
            double a = sortedArray[half];
            double b = sortedArray[half+1];
            return a/b;
        }


				
    }
};
