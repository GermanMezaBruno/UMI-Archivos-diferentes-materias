#include <stdio.h>
#include <iostream>

    /*Yo personalmente me gusta usar el printf y el scanf porque es el unico metodo que
    conozco, tambien me parece mas intuitivo */
int main(){
    int edad; //Declaras la variable con tipo de dato entero//
    printf("Ingrese su edad para determinar si es mayor o menor de edad: \n");
    scanf ("%i",&edad);
    // Con pintf pedimos un número y con scanf lo escaneamos//
    
    if (edad >= 18 ){
        printf ("Usted es mayor de edad");
    } else {
        printf ("Usted es menor de edad");
    }
    /*Aquí utilizamos una estructura de control selectiva, donde
    solo nos puede dar 2 resultados posibles*/
    return 0;
}