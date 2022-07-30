#ifndef SENSORES_H
#define SENSORES_H

#include <string>
#include <vector>
#include <fstream>

#include "medicao.h" 

using namespace std;

class SensorGenerico
{
    private:
            string dadosTemporarios;
            vector<double> dados;
            vector<string> headers;
            string nomeSensor;
            string id;
            int numMed;
            int numDeAmosPorSeg;
            string horaInicioGlobal;
            int numTotalDeAmos;
            ifstream file;


    public:
            SensorGenerico(const string&, const vector<string>&);
            ~SensorGenerico();
            bool abrirArquivo(const string&);
            bool lerDados();
            void imprimeDados();        
            string getNomeSensor();
            string getId();
            int getNumMed();
            int getNumDeAmosPorSeg();
            string getHoraInicioGlobal();
            int getNumTotaldeAmos();
            int salvarDados(const string&, const string&, const string&);           
};

class SensorCorrente : public SensorGenerico
{
        int frequenciaDaRede;
};

#endif