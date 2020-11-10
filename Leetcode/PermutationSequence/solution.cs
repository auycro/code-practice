//https://leetcode.com/problems/permutation-sequence/

public class Solution {
    public string GetPermutation(int n, int k) {
        List<int> nums = new List<int>();
        
        //InitiateNum
        for(int i=0; i<n ;i++){
            nums.Add(i+1);
        }
        
        //Calculate Factorial
        int[] fact = new int[n];
        fact[0] = 1;
        for (int i = 1; i < n; i++) 
        	fact[i] = i*fact[i-1];
        
        k = k-1; //sync index;
        
        StringBuilder sb = new StringBuilder();
        //FindString
        for (int i = n; i > 0; i--){
            int index = k/fact[i-1];
            k = k%fact[i-1];
            sb.Append(nums[index]);  
            nums.RemoveAt(index);
        }
        
        return sb.ToString();
    }
}