import random
class Ordenamiento_Baraja(object):
    def Baraja (array):
        lenght=len(array)
        for i in range(1,lenght):
            p = array[i]
            j = i-1
            while (j>=0 and array[j] > p):
             array[j+1] = array[j]
             j = j-1
             array[j+1] = p
             print(array)
        print(array)



lista = [int(random.randint(0,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA
print(Ordenamiento_Baraja.Baraja(lista))