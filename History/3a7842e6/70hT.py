import random, time
   #ALGORITMOS DE BUSQUEDA
def busquedaSecuencia(array,numero):                                                    
    for i in range(0,len(array)):
        if numero==array[i]:
                print("Encontrado")
                print(f"El número que desea buscar es el número {numero}\nA sido encontrado con {i+1} iteraciones\nEl número se encuentra en la pocisión {i} de la lista")
                p=0
                break
        else:
            p=1
    if p==1:
        print("Elemento no encontrado.")

def Dicotomica (array,numero) :                                                                
    for i , item in enumerate (array) :
        if item ==numero :
            return f"El número que desea buscar es el número {(numero)} \nA sido encontrado en tan solo {i+1} iteraciones\nEl número {numero} se encuentra en la posición {i} de la lista."
    return "Elemento no encontrado."

    #ALGORITMOS DE ORDENAMIENTO
def Burbuja(array):                                                                             
        length=len(array)-1
        for i in range(0,length):#puntero
            print(array)
            for j in range(0, length):#intercambio
                if array[j] > array [j+1]:
                    aux=array[j]
                    array[j]=array[j+1]
                    array[j+1]=aux
        return array

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
def Shell(array):                                                                              
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

def Quicksort(array):                                                                    
        if len(array)<=1:
            return array
        r=array.pop()
        p=[]#list 1
        q=[]#list 2
        for i in array:
            if i <= r:
                p.append(i)
            else:
                q.append(i)
            print(array)
        p=Quicksort(p)
        q=Quicksort(q)
        return p + [r] + q

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
def Binario(array):                                                                                        
    for i in range(1, len(array)):
        print(array)
        temp = array[i]
        pos = binary_search(array, temp, 0, i) + 1

        for j in range(i, pos, -1):
            array[j] = array[j - 1]

        array[pos] = temp
    print(array)

def binary_search(array, key, strt, end):                                                                    
    if end - strt <= 1:
        if key < array[strt]:
            return strt - 1
        else:
            return strt

    middle = (strt + end)//2
    if array[middle] < key:
        return binary_search(array, key, middle, end)
    elif array[middle] > key:
        return binary_search(array, key, strt, middle)
    else:
        return middle
def merge(array1, array2):                                                                                   
    array3=[]
    while (len(array1)> 0 and len(array2)>0):
        if array1[0]<array2[0]:
            array3.append(array1[0])
            array1=array1[1:]
        else:
            array3.append(array2[0])
            array2=array2[1:]
        print(array3)

    if len(array1)>0:
        array3=array3+array1
    if len(array2)>0:
        array3=array3+array2
    return array3
def mergesort (array):                                                                                      
    if len(array)==1:
        return array
    array_izq=array[:len(array)//2]
    array_der=array[len(array)//2:]

    array_izq=mergesort(array_izq)
    array_der=mergesort(array_der)

    return merge(array_izq, array_der)



#                             PROGRAMA PRINCIPAL
                                                                                                                                                                                            
salir=1
while(salir==1):
    Menu=int(input("\tDESEA REALIZAR UN ORDENAMIENTO O UNA BUSQUEDA:\n--> 1. ORDENAMIENTO\n--> 2. BUSQUEDA\n--->"))
    if Menu==1:
        Ordenamiento=int(input("QUE METODO DE ORDENAMIENTO DESEA REALIZAR:\n--> 1. BURBUJA\n--> 2. BARAJA\n--> 3. SHELL\n--> 4.QUICKSORT\n--> 5. RADIX\n--> 6. BINARIO\n--> 7. MERGESORT\n--->"))
        if Ordenamiento==1:#burbuja                  
            inicio=time.time()
            lista = [int(random.randint(1,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            print(Burbuja(lista))
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de ordenamiento Burbuja= {tiempo}")
        elif Ordenamiento==2:#baraja                  
            inicio=time.time()
            lista = [int(random.randint(1,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            Baraja(lista)
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de ordenamiento Baraja= {tiempo}")
        elif Ordenamiento==3:#shell                    
            inicio=time.time()
            lista = [int(random.randint(1,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            print(Shell(lista))
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de ordenamiento Shellsort= {tiempo}")
        elif Ordenamiento==4:#quicksort                 
            inicio=time.time()
            lista = [int(random.randint(1,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            print(Quicksort(lista))
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de ordenamiento Quicksort= {tiempo}")
        elif Ordenamiento==5:#radix                      
            inicio=time.time()
            lista = [str(random.randint(1,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            print(Radix(lista))
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de ordenamiento Radixsort= {tiempo}")
        elif Ordenamiento==6:#Binario                    
            inicio=time.time()
            lista = [int(random.randint(1,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            Binario(lista)
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de ordenamiento Binario= {tiempo}")
        elif Ordenamiento==7:#mergesort                  
            inicio=time.time()
            lista = [int(random.randint(1,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            print(mergesort(lista))
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de ordenamiento Mergesort= {tiempo}")
        else:
            print("X OPCIÓN NO VALIDA X")                  
    elif Menu==2:
        Busqueda=int(input("QUE METODO DE BUSQUEDA DESEA UTILIZAR:\n--> 1. SECUENCIAL\n--> 2. DICOTOMICO\n--->"))
        if Busqueda==1:                       
            inicio=time.time()
            lista = [int(random.randint(1,100)) for i in range (20)]
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            Num=int(input("Que número desea buscar en la lista\n\t--->"))
            buscar=busquedaSecuencia(lista,Num)
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de busqueda Secuencial= {tiempo}")
        elif Busqueda==2:                       
            inicio=time.time()
            lista = [int(random.randint(1,100)) for i in range (20)]
            print(f"\t\t\t ====LISTA DE ELEMENTOS====\n{lista}")#IMPRIMIR LISTA ALEATORIA
            Num=int(input("Que número desea buscar en la lista\n\t--->"))
            buscar =Dicotomica(lista,Num)
            print(buscar)
            final=time.time()
            tiempo= (final-inicio)
            print(f"Tiempo del programa de busqueda Dicotomica= {tiempo}")
        else:
            print("X OPCIÓN NO VALIDA X")                   
    else:
        print("X OPCIÓN NO VALIDA X")                     
    salir=int(input("Desea ejecutar nuevamente algun algoritmo de ordenamiento o busqueda\n 1. Si \n 2. No\n--->"))