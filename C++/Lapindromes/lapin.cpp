#include <iostream>
#include <string>

using namespace std;

bool comparador(string primeira, string segunda)
{
    string alfa = "abcdefghijklmnopqrstuvwxyz";
    int right[26], left[26];
    for (int x = 0; x < 26; x++)
    {
        right[x] = 0;
        left[x] = 0;
    }
    for (int j = 0; j < primeira.length(); j++)
    {
        left[alfa.find(primeira[j])] += 1;
        right[alfa.find(segunda[j])] += 1;
    }
    for (int k = 0; k < 26; k++)
    {
        if (left[k] != right[k])
        {
            return false;
        }
    }
    return true;
}

int main()
{
    int T;
    cin >> T;
    for (int i = 0; i < T; i++)
    {
        string str, sub1, sub2;
        cin >> str;
        if (str.length() % 2 == 0)
        {
            sub1 = str.substr(0, str.length() / 2);
            sub2 = str.substr(str.length() / 2, str.length());
        }
        else
        {
            sub1 = str.substr(0, str.length() / 2);
            sub2 = str.substr((str.length() / 2) + 1, str.length());
        }
        comparador(sub1, sub2) ? cout << "YES" << endl : cout << "NO" << endl;
    }
}