int fatorial (int n)
{
int b = n-1;
while(b>0)
{
    n*=b;
    b=b-1;    
}
return n;
}

float potencia(float b, int exp)
{
 int k=1;
 float resultado = b;
 while   (k<exp){
    resultado*=b;
    k++;
  }
  return resultado;
}

float funcaoy (float x)
{
 float y = fatorial(5)*potencia(x,3) + fatorial(4)*potencia(x,2) + fatorial(3)*x + fatorial(2);
 return y;

}
