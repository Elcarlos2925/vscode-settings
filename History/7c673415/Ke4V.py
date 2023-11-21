"""
import random
def Busqueda_binaria(array,q):
    if len (array)<=0:
        return"Lamentablemente su número no a podido ser encontrado"
    p=array[len(array)//2]
    if p == q:
        return f"Felicidades su número a sido encontrado exitosamente ({q})"
    else:
        if q<p:
            return Busqueda_binaria(array[:len(array)//2],q)
        else:
            return Busqueda_binaria(array[(len(array)//2)+1],q)

lista = [int(random.randint(0,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA

Num=int(input("Que número desea buscar en la lista\n\t--->"))
print(Busqueda_binaria(lista,Num))
"""
import random
valores=[int(random.randint(0,100)) for i in range (20)]
print(valores)
 
def busquedaBinaria(buscar,inicio,fin,iteraciones):
 
    centro=int((fin-inicio)/2)+inicio
 
    if centro>len(valores)-1 or inicio>fin:
        return (False,iteraciones)
 
    if buscar>valores[centro]:
        return busquedaBinaria(buscar,centro+1,fin,iteraciones+1)
    elif buscar<valores[centro]:
        return busquedaBinaria(buscar,inicio,centro-1,iteraciones+1)
    else:
        return (True,iteraciones)
       
 
while True:
    buscar=input("indica un numero a buscar: ")
    if buscar=="":
        break
 
    try:
        buscar=int(buscar)
    except:
        print("El valor tienes que ser numerico")
        continue
 
    conseguido,iteraciones=busquedaBinaria(buscar,0,len(valores),1)
    if conseguido:
        print("Encontrado en {} iteraciones".format(iteraciones))
    else:
        print("El valor introducido no se encuentra en la lista de valores")
