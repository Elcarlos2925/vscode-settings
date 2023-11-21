import random
#class Ordenamiento_Quicksort(object):
def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista = []
def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista.append(item)
def  Quicksort(self,array):
        izquierda = []
        centro = []
        derecha = []
        array=self.lista
        if len(array) > 1:
            p = array[0]
            for i in array:
                print(array)
                if i < p:
                   izquierda.append(i)
                elif i == p:
                   centro.append(i)
                elif i > p:
                    derecha.append(i)
            return Quicksort(izquierda)+centro+ Quicksort(derecha)
        else:
            return array

lista = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]#LISTA PARA ALMACENAR 20 ELEMENTOS
#Lista=Ordenamiento_Quicksort()
for i in range(len(lista)):#VECTOR PARA ALMACENAR ELEMENTOS
    add(lista)#AGREGAR ELEMENTO A LA LISTA
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{Lista.lista}")#IMPRIMIR LISTA ALEATORIA
print(Quicksort(lista))