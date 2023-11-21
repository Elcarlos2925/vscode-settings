import random
class Ordenamiento_Shell(object):
    def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista = []
    def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista.append(item)
    def shell (self,array):
        array=self.lista
        lenght=len(array)
        print(lenght)
        intervalo=lenght//2
        while intervalo>0:
            for i in range (intervalo,lenght):
                print(array)
                p=array[i]
                q=i
                while q >= intervalo and array [q-intervalo]> p:
                    array[q]=array[q-intervalo]
                    q -= intervalo
                    array[q]=p
            intervalo//=2
        return array

Lista=Ordenamiento_Shell()
lista = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]#LISTA PARA ALMACENAR 20 ELEMENTOS
for i in range(len(lista)):#VECTOR PARA ALMACENAR ELEMENTOS
    Lista.add()#AGREGAR ELEMENTO A LA LISTA
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{Lista.lista}")#IMPRIMIR LISTA ALEATORIA
print(Lista.shell(lista))
