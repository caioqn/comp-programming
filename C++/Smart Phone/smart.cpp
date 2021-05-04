#include <iostream>
#include <cstdio>
#include <vector>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);

    long long int i, n, aux, ans, m;
    cin >> n;

    vector<long long int> arr;

    for (i = 0; i < n; i++)
    {
        cin >> aux;
        arr.push_back(aux);
    }
    sort(arr.begin(), arr.end());
    m = n;
    ans = 0;
    for (i = 0; i < n; i++)
    {
        ans = max(ans, m*arr[i]);
        m--;
    }

    cout << ans;
    
    return 0;
}