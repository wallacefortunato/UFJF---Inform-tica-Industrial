//Atividade para controle de frequência semana 1
//Calculadora de IMC

#include <iostream>

using namespace std;
int main (){
    float peso,altura,imc;

    cout<<"Digite o seu peso: ";
    cin>>peso;
    cout<<"Digite a sua altura: ";
    cin>>altura;

    imc=peso/(altura*altura);

    cout<<"O seu IMC é: " << imc;  
    return 0;
}