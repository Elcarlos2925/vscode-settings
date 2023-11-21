import random
class Ordenamiento_Quicksort(object):
    def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista = []
        self.izquierda = []
        self.centro = []
        self.derecha = []
    def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista.append(item)
    def  Quicksort(self,array):
        array=self.lista
        left=self.izquierda
        center=self.centro
        rigth=self.derecha
        if len(array) > 1:
            p = array[0]
            for i in array:
                print(left+center+rigth)
                if i < p:
                   left.append(i)
                elif i == p:
                   center.append(i)
                elif i > p:
                    rigth.append(i)
            return left+center+rigth
        else:
            return array

lista = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]#LISTA PARA ALMACENAR 20 ELEMENTOS
Lista=Ordenamiento_Quicksort()
for i in range(len(lista)):#VECTOR PARA ALMACENAR ELEMENTOS
    Lista.add()#AGREGAR ELEMENTO A LA LISTA
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{Lista.lista}")#IMPRIMIR LISTA ALEATORIA
print(Lista.Quicksort(lista))