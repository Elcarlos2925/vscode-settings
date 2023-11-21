import random
class Ordenamiento_Baraja(object):
    def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista = []
    def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista.append(item)
    def Baraja (self,array):
        array=self.lista
        for i in range(1,len(array)):
            p = array[i]
            j = i-1
            while (j>=0 and array[j] > p):
             array[j+1] = array[j]
             j = j-1
             array[j+1] = p
             print(array)
        print(array)


lista = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]#LISTA PARA ALMACENAR 20 ELEMENTOS
Lista=Ordenamiento_Baraja()
for i in range(len(lista)):#VECTOR PARA ALMACENAR ELEMENTOS
    Lista.add()#AGREGAR ELEMENTO A LA LISTA
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{Lista.lista}")#IMPRIMIR LISTA ALEATORIA
Lista.Baraja(lista)