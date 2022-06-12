package main

import "fmt"

func main() {
	//fmt.Println(maxSubArrayNaive([]int{-2, 1, -3, 4, -1, 2, 1, -5, 4}))
	//fmt.Println(maxSubArrayNaive([]int{-1}))
	//fmt.Println(maxSubArray([]int{5, 4, -1, 7, 8}))
	fmt.Println(maxSubArray([]int{1, 2, -3, 3, -3, 4}))
}

// O(n^2) -> Time Limit Exceeded
func maxSubArrayNaive(nums []int) int {
	max := nums[0]
	sum := 0
	for i := 0; i < len(nums); i++ {
		sum = 0
		for j := i; j < len(nums); j++ {
			sum += nums[j]
			if sum > max {
				max = sum
			}
		}
	}
	return max
}

// O(n)
func maxSubArray(nums []int) int {
	max := nums[0]
	sum := 0
	for _, v := range nums {
		if sum > 0 {
			sum += v
		} else {
			//fmt.Println(v)
			sum = v
		}
		if sum > max {
			max = sum
		}
	}
	return max
}
