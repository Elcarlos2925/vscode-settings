import random
class Ordenamiento_Shell(object):
    def shell (array):
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


lista = [int(random.randint(0,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA
print(Ordenamiento_Shell.shell(lista))
