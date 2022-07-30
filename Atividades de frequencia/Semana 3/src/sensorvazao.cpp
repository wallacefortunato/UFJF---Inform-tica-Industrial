#include "sensorvazao.h"
#include <fstream>
#include <iostream>

using namespace std;

SensorVazao::SensorVazao(const string &path, vector<string>& h)
{
    this->id = "desconhecido";
    this->unidade = "desconhecida";
    this->numMed = 0;
    this->headers.assign(h.begin(),h.end());
    abrirArquivo(path);
}
SensorVazao::~SensorVazao()
{
    this->file.close();
}

bool SensorVazao::abrirArquivo(const string &path)
{
    try
    {
        this->file.open(path);
        return true;
    }
    catch (const std::exception &e)
    {
        std::cout << e.what () << '\n';
    }
    return false;
}

bool SensorVazao::lerDados()
{
    try
    {
        if(this->file.is_open())
        {
            string d;
            getline(this->file,d);
            int n=0;
            int idx;
            vector<string> dadosHeader(this->headers.size());
            while (n<this->headers.size())
            {
                getline(this->file,d);
                idx = d.find(":");
                if(d.substr(0,idx) == this->headers[n])
                {
                    dadosHeader[n] = d.substr(idx+1,d.length()-idx);
                    n++;
                }
                else
                {

                    return false;
                }
            }
            this->id = dadosHeader[0];
            this->unidade = dadosHeader[1];
            this->numMed = stod(dadosHeader[2]);
            this->Ts = (int)stod(dadosHeader[3]);

            Medicao m;
            getline(file,d);
            for(int i=0;i<this->numMed;i++)
            {
                getline(file,d);
                idx = d.find(",");
                m.horario = d.substr(0,idx);
                m.valor = stod(d.substr(idx+1,d.length()-idx));
                this-> dados.push_back(m);
            }
        }
        else
        {
            return false;
        }
    }
    catch(const std::exception &e)
    {
        cout <<"Arquivo corrompido. Erro:" << e.what() << '\n';
        return false;
    }
    return true;
}

 void SensorVazao::imprimeDados ()
 {
     cout << "Sensor de vazao: "<<endl;
     cout << "ID: "<< this->getId() <<endl;
     cout <<"Numero de amostras: "<< this->getNumMed()<<endl;
     cout <<"Periodo de amostragem (s): "<< this->getPeriodoAmostragem() <<endl;

     for (auto it = this->dados.begin(); it !=this->dados.end(); ++it)
     {
         cout<< "Horario: "<< it->horario<<" h | Valor: " << it->valor << " " << this->getUnidade() << endl;
     }
 }

 string SensorVazao::getId()
 {
     return this->id;
 }

 string SensorVazao::getUnidade()
 {
     return this->unidade;
 }

 int SensorVazao::getNumMed()
 {
     return this->numMed;
 }

 int SensorVazao::getPeriodoAmostragem()
 {
     return this->Ts;
 }

bool SensorVazao::getDado(const string &horario, double &dado)
{
    for (auto it = this->dados.begin(); it!= this->dados.end(); ++it)
    {
        if (it->horario == horario)
        {
            dado = it->valor;
            return true;
        }
    }
    return false;
}

int SensorVazao::salvarDados(const string &path, const string &horai, const string &horaf)
{
    bool flag[2] = {false,false};
    try
    {
        ofstream ofile;
        ofile.open(path, std::ios_base::out | std::ios_base::trunc);
        ofile << "Dados sensor de vazao"<<endl;
        ofile << "id: " << this->getId() <<endl;
        ofile << "unidade: " << this->getUnidade()<<endl;
        ofile << "Numero de amostras: " << this->getNumMed() <<endl;
        ofile << "Periodo de amostragem (s): " << this->getPeriodoAmostragem() << endl;
        ofile << "Horario,dado" << endl;
        if (ofile.is_open())
        {
            for (auto it = this ->dados.begin(); it != this->dados.end (); ++it)
            {
                if (it->horario == horai)
                {
                    flag [0] = true;
                }

                if (flag[0] && ~flag[1])
                {
                    ofile << it->horario << "," << it->valor << endl;
                }

                if (it->horario == horaf)
                {
                    flag [1] = true;
                    return 0;
                }
            }
        }
        else
        {
            return -1;
        }
    }
    catch(const std::exception &e)
    {
        std::cout << e.what() << '\n';
    }

    if (flag[0]&&~flag[1])
    {
        return 1; 
    }
    else
    {
        return 2;
    }
       
}