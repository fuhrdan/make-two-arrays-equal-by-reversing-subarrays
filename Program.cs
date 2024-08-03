//*****************************************************************************
//** 1640. Make Two Arrays Equal by Reversing Subarrays  leetcode            **
//** I used a hash table instead of reversing the arrays.  I feel like this  **
//** I feel this wasn't in the spirit of the problem, but a working solution **
//** is a working solution.                                           -Dan   **
//*****************************************************************************


bool canBeEqual(int* target, int targetSize, int* arr, int arrSize) {
    int hash[1002];
    int retnum = -1;
    for(int i = 0; i < arrSize; i++)
    {
        hash[arr[i]]++;
    }
    for(int i = 0; i < targetSize; i++)
    {
        hash[target[i]]--;
        if(hash[target[i]] < 0) return 0;
    }
    return 1;

}