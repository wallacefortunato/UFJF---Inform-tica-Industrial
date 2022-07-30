#ifndef BANCO_H
#define BANCO_H
#include <string>

#include "conta.h"

class Banco
{
private:
    Conta contas[100];

public:
    Banco();
    ~Banco();

    Conta* buscaConta(int numero);
    void atendimento ();
};

#endif