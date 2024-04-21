#include <iostream>
#include "../../include/lceasy.h"

using namespace std;

void flowrun()
{
	int T;
	cin >> T;
	for (int i = 0; i < T; i++)
	{
		int N;
		cin >> N;
		int rem, reverse = 0;
		while (N != 0)
		{
			rem = N % 10;
			reverse = reverse * 10 + rem;
			N /= 10;
		}
		cout << reverse << endl;
	}
}