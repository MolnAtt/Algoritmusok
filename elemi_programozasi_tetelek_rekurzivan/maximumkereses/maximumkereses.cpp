#include <iostream>
#include <vector>

using namespace std;

double Maximum(vector<double> lista)
{
    double max = lista[0];
    for (int i = 1; i < lista.size(); i++)
    {
        if (max < lista[i])
        {
            max = lista[i];
        }
    }
    return max;
}

int Maximum_indexe(vector<double> lista)
{
    double max = lista[0];
    int maxi = 0;
    for (int i = 1; i < lista.size(); i++)
    {
        if (max < lista[i])
        {
            max = lista[i];
            maxi = i;
        }
    }
    return maxi;
}

int main()
{
    vector<double> v = { 4, 5, 1, 2, 3 };
    cout << Maximum(v) << endl << Maximum_indexe(v);
}
