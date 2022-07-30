#include <iostream>
#include "conta.h"


using namespace std;


int main()
{
    Conta c1, c2(1234, 1323421,"Wallace Fortunato", 1000000000);
    c1.numero = 47892;
    c1.titular = "Felipe Meirelles";
    c1.setSenha(1234);
    c1.setSaldo(20000);
    c1.exibeDados();
    cout<<"Saldo em conta: "<<c1.getSaldo(1234)<<endl;
    c1.deposito(50000);
    cout<<"Saldo em conta: "<<c1.getSaldo(1234)<<endl;
    c1.saque(1234, 500);
    cout<<"Saldo em conta: "<<c1.getSaldo(1234)<<endl;

    return 0;
}