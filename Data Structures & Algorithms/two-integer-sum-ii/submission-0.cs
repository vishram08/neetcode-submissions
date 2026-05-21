public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length - 1;

        while (l < r) {
            int sum = numbers[l] + numbers[r];
            if (sum == target) {
                break;
            } else if (sum < target) {
                l++;
            } else if (sum > target) {
                r--;
            }
        }
        return new int[] { (l + 1), (r + 1) };
    }
}