//https://leetcode.com/problems/permutation-sequence/submissions/
public class Solution {
    public string GetPermutation(int n, int k) {
        int[] nums = new int[n];
        //string current = string.Empty;
        StringBuilder current = new StringBuilder();
        List<string> arr = new List<string>();
        for(int i=0; i<n ;i++){
            nums[i] = i+1;
        }
        
        DoPermute(nums, current, arr);
        
        return arr[k-1];
    }
    
    //12345
    //12354
    //12435
    //12453
    //12534
    //12543
    
    public void DoPermute(int[] nums, StringBuilder current, List<string> arr){
        if (current.Length == nums.Count()){
            arr.Add(current.ToString());
            return;
        }
        
        for (int i=0; i<nums.Count(); i++){
            string item = nums[i].ToString();
            if (!current.ToString().Contains(item)){
                current.Append(item);
                DoPermute(nums, current, arr);
                current.Remove(current.Length -1, 1);
            }
        }
            
    }
}