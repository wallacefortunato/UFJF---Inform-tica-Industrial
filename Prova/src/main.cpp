#include <iostream>
#include <math.h>

using namespace std;

class C1 {
    public:
            C1(){}
            C1(int arg)
            {
                attr1 = arg;
            }
            void alterarArg(int a);
    protected: 
        int attr1;
};

void C1::alterarArg(int a)
{
    this->attr1 = a;
};

class C2 : public C1
{
    public: C2(int arg)
    {
        attr1 = arg;
    }
};

int main()
{
    C1 C1(2);
    C2 C2(3);

    C1.alterarArg(5);
    C2.alterarArg(6);

    return 0;
}