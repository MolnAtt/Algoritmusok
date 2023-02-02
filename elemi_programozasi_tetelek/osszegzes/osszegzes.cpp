#include <iostream>
#include <vector>

using namespace std;

double Osszeg1(vector<double> lista)
{
    double sum = 0;
    for (double& elem : lista)
    {
        sum += elem;
    }
    return sum;
}

double Osszeg2(vector<double> lista)
{
    double sum = 0;
    for (int i = 0; i < lista.size(); i++)
    {
        sum += lista[i];
    }
    return sum;
}

int main()
{
    vector<double> l = { 1, 2, 3, 4, 5 };
    cout << Osszeg1(l) << endl << Osszeg2(l);
}
