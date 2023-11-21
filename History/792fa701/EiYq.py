import random
class Ordenamiento_RadixSort(object):
    def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista = []
    def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista.append(item)
    def Radix(self,array):
        array=self.lista
        length=len(array)
        n=0
        for i in array:
            if len(i)>n:
                n=len(i)
        for j in range(0,length):
                while len(array[i])<n:
                    array[i]= "0" + array[i]#igualar cantidad de digitos agregando 0
        for k in range(n-1,-1,-1):
                grupos=[[]for i in range(10)]#10 grupos dentro de la lista para asignarle su grupo a cada elemento
                for i in range(length):
                    grupos[int(array[i][j])].append(array[i])
                array=[]
                for l in grupos:
                    lista += grupos
        return [int(i) for i in array]


Lista=Ordenamiento_RadixSort()
lista = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]#LISTA PARA ALMACENAR 20 ELEMENTOS
for i in range(len(lista)):#VECTOR PARA ALMACENAR ELEMENTOS
    Lista.add()#AGREGAR ELEMENTO A LA LISTA
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{Lista.lista}")#IMPRIMIR LISTA ALEATORIA
print(Lista.Burbuja(lista))