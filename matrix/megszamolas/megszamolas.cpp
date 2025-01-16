#include <iostream>
#include <vector>

using namespace std;

int Megszamolas(vector<double> lista)
{
    int db = 0;
    for (double& elem : lista)
    {
        db++;
    }
    return db;
}

int main()
{
    vector<double> v = { 1, 5, 1, 2, 3 };
    cout << Megszamolas(v);
}
