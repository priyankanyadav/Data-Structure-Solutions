//leetcode problem number:904
//Fruit Into Basket
public class Solution {
    public int TotalFruit(int[] fruits) {
           Dictionary<int, int> basket = new Dictionary<int, int>();
        int left = 0, maxFruits = 0;

        for (int right = 0; right < fruits.Length; right++) {
            if (!basket.ContainsKey(fruits[right]))
                basket[fruits[right]] = 0;
            basket[fruits[right]]++;

            // If we have more than 2 fruit types, shrink from the left
            while (basket.Count > 2) {
                basket[fruits[left]]--;
                if (basket[fruits[left]] == 0)
                    basket.Remove(fruits[left]);
                left++;
            }

            // Update max length
            maxFruits = Math.Max(maxFruits, right - left + 1);
        }

        return maxFruits;
    }
}
