import random
class Ordenamiento_RadixSort(object):
 def Radix(array):
        n=0
        for i in array:
         if len(i) > n:
            n=len(i)

        for j in range(0,len(array)):
            while len(array[j]) < n:
                array[j]= "0" + array[j]#igualar cantidad de digitos agregando 0

        for k in range(n-1,-1,-1):
            grupos=[[]for i in range(10)]#10 grupos dentro de la lista para asignarle su grupo a cada elemento
            for i in range(len(array)):
                grupos[int(array[i][k])].append(array[i])
            array=[]
            for l in grupos:
                array += l
                print(grupos)
        return [int(i) for i in array]

lista = [int(random.randint(0,100))for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA
print(Ordenamiento_RadixSort.Radix(lista))