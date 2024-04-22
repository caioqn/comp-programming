#include <iostream>
#include <cstdio>
#include <vector>
#include <cmath>
#include <algorithm>
#include <unordered_map>
#include "lceasy.h"

using std::vector, std::unordered_map, std::cin, std::cout, std::string, std::ranges::copy, std::ostream_iterator;

// Pointers here would overcomplicate things
vector<int> TwoSumResolver(vector<int>& nums, int target) {
	vector<int> result;
	unordered_map<int, int> map;
	for (int i = 0; i < nums.size(); i++) {
		int n = nums[i];
		int complement = target - n;
		if (map.find(complement) != map.end() && map.find(complement)->second != i) {
			result.push_back(i);
			result.push_back(map.find(complement)->second);
			return result;
		}
		map[n] = i;
	}

	return result;
}

void TwoSumRun() {
    vector<int> arr = { 2, 7, 11, 15 };
    int target = 9;
	vector<int> ouput = TwoSumResolver(arr, target);
	copy(ouput, ostream_iterator<int>(cout, " "));
}