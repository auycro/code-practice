//https://leetcode.com/problems/permutations/submissions/
public class Solution {    
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> arr = new List<int>();
        
        //Validate Null 
        if (nums.Count() < 0){
            result.Add(new List<int>());
            return result;
        }
        
        //Only one member
        if (nums.Count() == 1){
            result.Add(new List<int>{nums[0]});
            return result;
        }    
        
        DoPermute(result, arr, nums, 0);
        
        return result;
    }
    
    public void DoPermute(IList<IList<int>> result, List<int> arr, int[] nums, int count){
        if (arr.Count() == nums.Count()){
            result.Add(arr);
            return;
        }
        
        for (int i=count; i<nums.Count(); i++){
            if(arr.Contains(nums[i]))
                continue;
            
            arr.Add(nums[i]);
            DoPermute(result, arr.ToList(), nums, 0);
            
            arr.RemoveAt(arr.Count()-1);
        }
    }
}