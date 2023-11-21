import random
class Ordenamiento_Quicksort(object):
  def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista = []
  def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista.append(item)
def  sort(self,array):
        array=self.lista
        izquierda = []
        centro = []
        derecha = []
        if len(array) > 1:
            pivote = array[0]
            for i in array:
                if i < pivote:
                    izquierda.append(i)
                elif i == pivote:
                    centro.append(i)
                elif i > pivote:
                    derecha.append(i)
            print(izquierda+["-"]+centro+["-"]+derecha)
            return sort(izquierda)+centro+sort(derecha)
        else:
            return array




lista = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]#LISTA PARA ALMACENAR 20 ELEMENTOS
#Lista=Ordenamiento_Quicksort()
for i in range(len(lista)):#VECTOR PARA ALMACENAR ELEMENTOS
    add()#AGREGAR ELEMENTO A LA LISTA
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{Lista.lista}")#IMPRIMIR LISTA ALEATORIA
print(sort(lista))