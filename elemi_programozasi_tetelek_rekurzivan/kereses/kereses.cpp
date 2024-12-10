#include <iostream>
#include <vector>

using namespace std;

int Helye1(vector<double>& lista)
{
    int i = 0;
    while (i < lista.size() && !(lista[i] < 0))
    {
        i++;
    }
    return i;
}

int Helye2(vector<double>& lista)
{
    for (int i = 0; i < lista.size(); i++)
    {
        if (lista[i] < 0)
        {
            return i;
        }
    }
    return lista.size();
}

int Keres(vector<double>& lista)
{
    int h = Helye1(lista);
    return h == lista.size() ? -1 : h;
}

int Eldontes(vector<double>& lista)
{
    return Helye1(lista) != lista.size();
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
    vector<double> vvan = { 4, 5, 1, -2, 3 };
    vector<double> vnincs = { 4, 5, 1, 2, 3 };

    cout << Helye1(vvan) << endl
        << Helye1(vnincs) << endl
        << Helye2(vvan) << endl
        << Helye2(vnincs) << endl
        << Keres(vvan) << endl
        << Keres(vnincs) << endl
        << Eldontes(vvan) << endl
        << Eldontes(vnincs) << endl;
}
    
