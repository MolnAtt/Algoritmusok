#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

unordered_map<char, vector<string>> Csoportosit(vector<string>& lista)
{
    unordered_map<char, vector<string>> szotar;
    for (string& elem : lista)
    {
        szotar[elem[0]].push_back(elem);
    }
    return szotar;
}


int main()
{
    vector<string> szavak = { "repa", "retek", "mogyoro", "koran", "reggel", "ritkan", "rikkant", "a", "rigo" };

    unordered_map<char, vector<string>> szotar = Csoportosit(szavak);
    for (auto& par : szotar)
    {
        cout << par.first << ": ";
        for (string& elem : par.second)
        {
            cout << elem << " ";
        }
        cout << endl;
    }
}
    
