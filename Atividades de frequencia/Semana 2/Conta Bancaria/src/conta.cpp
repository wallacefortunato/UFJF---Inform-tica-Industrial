#include "conta.h"
#include <iostream>

Conta::Conta()
{
    this->senha = 1111;
    this->numero = 0;
    this->titular = "";
    this->saldo = 0;

    std::cout<<"Alerta!!! O construtor padrao foi invocado"<<std::endl;
}
Conta::Conta(int senha, int numero, std::string titular, double saldo)
{
    this->senha = senha;
    this->numero = numero;
    this->titular = titular;
    if (saldo>0){
        this->saldo = saldo;
    } else {
        std::cout<<"Saldo inicial invalido"<<std::endl;
        this->saldo = 0;
    }
}

Conta::~Conta()
{
    std::cout<<"Destrutor foi invocado"<<std::endl;
}

void Conta::exibeDados()
{
    std::cout<< "Titular: "<<this->titular<<std::endl;
    std::cout<< "Numero: "<<this->numero<<std::endl;

}

double Conta::getSaldo (int senha)
{
    if(senha==this->senha)
    {
        return this->saldo;
    } else{
        std::cout<<"Senha Invalida"<<std::endl;
        return -00000000000000;
    }
}

void Conta::setSaldo (double valor)
{
    this->saldo = valor;
}

void Conta::setSenha (int novaSenha)
{
    this->senha = novaSenha;
}

void Conta::deposito (double valor)
{
    if (valor>0)
    {
        this->saldo+=valor;
    } else {
        std::cout<<"Valor inválido"<<std::endl;
    }
}

void Conta::saque (int senha, double valor)
{
    if(senha==this->senha)
    {
        if (this->saldo>valor)
        {
            this->saldo -=valor;
            std::cout<<"Saque de R$"<<valor<<" realizado com sucesso."<<std::endl;
        } else {
            std::cout<<"Saldo insuficiente"<<std::endl;
        }
    } else{
        std::cout<<"Senha invalida"<<std::endl;
    }
}