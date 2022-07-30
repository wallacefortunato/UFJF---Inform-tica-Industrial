#include "banco.h"
#include <iostream>

using std::cout, std::cin, std::endl;

Banco::Banco()
{
    this->contas[0] =  {1234, 1, "Felipe", "Corrente", 1};
    this->contas[1] =  {4567, 2, "Jose", "Poupanca", 800};
    this->contas[2] =  {1234, 3, "Wallace", "Corrente", 1};
    this->contas[3] =  {8956, 4, "Madalena", "Poupanca", 2000};
}

Banco::~Banco()
{

}

Conta* Banco::buscaConta(int numero)
{
    for (int i=0; i<sizeof(contas)/sizeof(contas[0]);i++)
    {
        if(numero == this->contas[i].numero)
        {
            return &this->contas[i];
        }
    }

    return nullptr;
}

void Banco::atendimento()
{
    Conta* contaCliente;
    int numC = 0;
    int senhain;
    bool atendimento = true;

    cout<< "Bem vindo ao sistema de atendimento do banco"<<endl;
    cout<< "Digite o numero da sua conta: ";
    cin>> numC;

    contaCliente = this->buscaConta(numC);

    if(contaCliente == nullptr)
    {
        cout<< "Conta invalida"<<endl;
    } else {
        cout<< "Digite a sua senha: ";
        cin>>senhain;
        if(contaCliente->validaSenha(senhain))
        {
            cout<< "Ola "<<contaCliente->titular<<endl;
            while (atendimento)
            {
                int op;
                double valor;
                cout<< "Qual operacao deseja fazer? (1- Saque, 2- Deposito, 3- Ver Saldo, 4= Sair): ";
                cin>>op;
                switch (op)
                {
                case 1:
                    cout << "Digite o valor a ser sacado: ";
                    cin>> valor;
                    contaCliente->saque(senhain, valor);
                    cout<< "Saldo disponivel: R$ "<<contaCliente->getSaldo(senhain)<<endl;
                    break;
                case 2:
                    cout << "Digite o valor a ser depositado: ";
                    cin>> valor;
                    contaCliente->deposito(valor);
                    cout<< "Saldo disponivel: R$ "<<contaCliente->getSaldo(senhain)<<endl;
                    break;
                case 3:
                    cout<< "Saldo disponivel: R$ "<<contaCliente->getSaldo(senhain)<<endl;
                    break;
                case 4:
                    atendimento=false;
                    break;
                }
            }
        } else {
            cout<< "Senha invalida"<<endl;
        }
    }
}