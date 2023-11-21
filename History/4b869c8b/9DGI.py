import random
                                                                                                
def busquedaSecuencia(lista,num):
    p=True
    for i in range(0,len(lista)):
        if num==lista[i]:
             p=True
             print(encontrado)
    p=False
    if p==True:
        print("Felicidades humano haz colocado un numero de la lista ahora dame la patita:)")
    else:
        print("Humano tonto intentalo de nuevo")

lista = [int(random.randint(0,100)) for i in range (20)]
print (lista)
num=int(input("\nHumano por favor ingresa un numero de la lista anterior:"))

encontrado=busquedaSecuencia(lista,num)