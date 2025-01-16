#include <iostream>
#include <vector>

using namespace std;

double Elsoi(vector<double>& lista)
{
    int i = 0;
    while (!(lista[i] < 0))
    {
        i++;
    }
    return i;
}

double Elso1(vector<double>& lista)
{
    return lista[Elsoi(lista)];
}

double Elso2(vector<double>& lista)
{
    for (double& elem : lista)
    {
        if (elem < 0)
        {
            return elem;
        }
    }
}
int main()
{
    vector<double> v = { 4, 5, 1, -2, 3 };
    cout << Elsoi(v) << endl << Elso1(v) << endl << Elso2(v);
}
    
