#include "sensores.h"
#include "medicao.h" 
#include <iostream>
#include <string>
#include <vector>
#include <fstream>

using namespace std;

SensorGenerico::SensorGenerico(const string &path, const vector<string> &h) : nomeSensor("desconhecido"), id("desconhecido"), numMed("desconhecido"), numDeAmosPorSeg(0), horaInicio("desconhecido"), numTotalDeAmos(0), dados("sem dados")
{
    this->headers.assign(h.begin(), h.end());
    this->abrirArquivo(path);
}

SensorGenerico::~SensorGenerico()
{
    this->file.close();
}

bool SensorGenerico::abrirArquivo(const string &path)
{
    try
    {
        this->file.open(path);
        return true;
    }
    catch (const std::exception &e)
    {
        std::cout << e.what() << '\n';
    }
    return false;
}

bool SensorGenerico::lerDados()
{
    try
    {
        if (this->file.is_open())
        {
            string d;
            getline(this->file, d);
            int n = 0;
            int idx;
            vector<string> dadosHeader(this->headers.size());
             while (n < this->headers.size())
            {
                getline(this->file, d);
                idx = d.find(":");
                if (d.substr(0, idx) == this->headers[n])
                {
                    dadosHeader[n] = d.substr(idx + 1, d.length() - idx);
                    n++;
                }
                else
                {
                    return false;
                }
            } 
            this->nomeSensor = dadosHeader[0];
            this->id = dadosHeader[1];
            this->numMed = dadosHeader[2];
            this->numDeAmosPorSeg = stod(dadosHeader[3]);
            this->horaInicio = dadosHeader[4];
            this->numTotalDeAmos = stod(dadosHeader[5]);
            this->dadosTemporarios = dadosHeader[6];

            getline(this->file, d);
            
            int n=0;
            int idx;

            for (int i = 0; i < dadosTemporarios.size(); i=idx+1)
            {
                int anterior = i;
                idx = dadosTemporarios.find(",");
                dados[n] = stod(dadosTemporarios.substr(anterior,idx-1);
                n +=1;
                anterior = idx;
            }
            Medicao m;
            for (i = 0; i<dados.length(); i++)
            {
                m.valor = dados[i];
            }
            //for (j = horaInicioGlobal(); j<)
        }
        else
        {
            return false;
        }
    }
    catch (const std::exception &e)
    {
        std::cout << "Arquivo corrompido. Erro:" << e.what() << '\n';
    }
    return true;
}

void SensorVazao::imprimeDados()
{
            cout << "Dados sensor de vazao" << endl;
            cout << "Nome do Sensor:" << this->getNomeSensor() << endl;
            cout << "id do sensor: " << this->getId() << endl;
            cout << "Numero de Medicoes: " << this->getNumMed() << endl;
            cout << "Numero de Amostras por segundo: " << this->getNumDeAmosPorSeg() << endl;
            cout << "Horario de inicio:" << this->getHoraInicio() << endl;
            cout << "Total de Amostras: " << this->getNumTotaldeAmos() <<endl;

    // for (auto it = this->dados.begin(); it != this->dados.end(); it++)
    // {
    //     cout << "Horario: " << it->horario << "h | Valor: " << it->valor << " " << this->getUnidade() << endl;
    //     cout << it->valor <<",";
    // }
}

string SensorVazao::getNomeSensor()
{
    return this->nomeSensor;
}

string SensorVazao::getId()
{
    return this->id;
}

int SensorVazao::getNumMed()
{
    return this->numMed;
}

int SensorVazao::getNumDeAmosPorSeg()
{
    return this->numDeAmosPorSeg;
}

string SensorVazao::getHoraInicioGlobal()
{
    return this->horaInicio;
}

int SensorVazao::getNumTotaldeAmos()
{
    return this->numTotalDeAmos;
}

