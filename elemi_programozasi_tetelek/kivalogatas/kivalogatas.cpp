#include <iostream>
#include <vector>

using namespace std;

vector<double> Kivalogat(vector<double>& lista)
{
    vector<double> result;
    for (double& elem : lista)
    {
        if (0<elem)
        {
            result.push_back(elem);
        }
    }
    return result;
}

int main()
{
    vector<double> v = { -4, 5, -1, -2, 3 };
    for (auto& elem : Kivalogat(v))
    {
        cout << elem << " ";
    }
}
