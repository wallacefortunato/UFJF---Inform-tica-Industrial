#include <iostream>
#include "mylib.h"

using namespace std;

int main(){

    float a,b,c; 
    a=25;  ; c= potencia(2.5,3),b=fatorial(7);

    float y = funcaoy(a);
    cout<< "y(25) :" <<y<<endl;

    y = funcaoy(b);
    cout<< "y(7!) : " << y <<endl;

    y = funcaoy(c);
    cout<< "y(2.5^3) : " <<y <<endl;

    return 0;
}

