#include <iostream>
#include <vector>

using namespace std;

vector<double> Masolas(const vector<double>& lista)
{
    vector<double> result(lista.size());
    for (int i = 0; i < lista.size(); i++)
    {
        result[i] = lista[i] * lista[i];
    }
    return result;
}

int main()
{
    vector<double> v = { 4, 5, 1, 2, 3 };
    for (double& elem : Masolas(v))
    {
        cout << elem << " ";
    }
}
