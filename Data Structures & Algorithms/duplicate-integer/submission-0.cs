public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> map = new HashSet<int>();

        foreach(int i in nums) {
            if(!map.Add(i)) {
                return true;
            }
        }

        return false;
    }
}