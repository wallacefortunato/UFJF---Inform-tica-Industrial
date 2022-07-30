#include <iostream>
#include "sensorvazao.h"

using namespace std;

int main()
{
    vector<string> headers = {"id", "unidade", "Numero de amostras", "Periodo de amostragem (s)"};
    SensorVazao sensor("W:\\2020-1\\Informartica Industrial\\Atividades de frequencia\\Semana 3\\dados\\dados.csv", headers);
    sensor.lerDados();
    string h = "08:17:00";
    double d;
    if(sensor.getDado (h,d))
    {
        cout<<"Dado encontrado: "<<d<<" "<<sensor.getUnidade()<<endl;
    }
    else
    {
        cout <<"Dado nao encontrado"<<endl;
    }

    sensor.imprimeDados();
    int resp = sensor.salvarDados("W:\\2020-1\\Informartica Industrial\\Atividades de frequencia\\Semana 3\\dados\\dadosSalvos.csv",
    "07:17:00","07:19:00");
    if (resp == 0)
    {
        cout<< "Dados salvos com sucesso"<<endl;
    }
    else
    {
        cout<< "Erro: "<< resp <<endl;
    }

    return 0;
}