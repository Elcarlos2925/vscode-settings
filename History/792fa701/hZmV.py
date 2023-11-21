import random
#class Ordenamiento_RadixSort(object):
def Radix(array):
        n=0
        for e in array:
         if len(e) > n:
            n=len(e)

        for j in range(0,len(array)):
            while len(array[j]) < n:
                array[j]= "0" + array[i]#igualar cantidad de digitos agregando 0

        for k in range(n-1,-1,-1):
            grupos=[[]for i in range(10)]#10 grupos dentro de la lista para asignarle su grupo a cada elemento
            for i in range(len(array)):
                grupos[int(array[i][j])].append(array[i])
            array=[]
            for l in grupos:
                lista += grupos
        return [int(i) for i in array]


#Lista=Ordenamiento_RadixSort()
lista = [str(random.randint(0,100))for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA
print(Radix(lista))

"""
def radixsort(lista):
    n = 0
    for e in lista:
      if len(e) > n:
         n = len(e)

    for i in range(0, len(lista)):
      while len(lista[i]) < n:
       lista[i] = "0" + lista[i]

    for j in range(n - 1,-1, -1):
        grupos = [[] for i in range(10)]

        for i in range(len(lista)):
            grupos[int(lista[i][j]) ].append(lista[i])

        lista = []
        for g in grupos:
            lista += g
    return [int(i) for i in lista]

import random
lista = [str(random.randint(0, 200)) for i in range (10)]
print(lista)
print(radixsort (lista))
"""