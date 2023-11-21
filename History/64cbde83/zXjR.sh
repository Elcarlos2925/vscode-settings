clear 
echo "1) Cifrar simetrico"
echo "2) Descifrar simetrico"
echo "3) Cifrar asimetrico"
echo "4) Descifrar asimetrico"
echo "5) Funciones de redes"
echo "6) Cambiar Privilegios"
echo "7) Salir"

read -p "Ingrese una opción: " opcion
case $opcion in 

1) read -p "-Ingresa archivo a cifrar: " archivo
sudo gpg -c $archivo 
echo "Archivo cifrado correctamente"
ls -l
;;

2) read -p "ingresa archivo a descifrar: " archivod
sudo gpg -d $archivod
echo "Archivo descifrado correctamente"
ls -l
;;

3) echo "Cifrado asimetrico" 
clear
	echo "1) Generar Claves"
	echo "2) Revisar Claves"
	echo "3) Exportar Claves"
	echo "4) Importar Claves"
	echo "5) Firmar Claves"
	echo "6) Verificar Firma"
	echo "7) Cifrar Archivo"
	read -p "Ingrese una opción: " opcCA
	case $opcCA in 
	1) sudo gpg --gen-key  #generar key
	;;
	2) sudo gpg -k #ver key
	;;
	3) sudo gpg -k
	read -p "Ingrese cadena que se encuentra despues de caducidad: " Cadena
	read -p "Ingrese nombre de la llave: " Clave
	sudo gpg --output $Clave.pub --export $Cadena #Exportar key         
	;;
	4) read -p "Ingrese nombre de la llave: " Clave
	sudo gpg --import $Clave.pub #importar key
	;;
	5) sudo gpg -k
	read -p "Ingrese cadena que se encuentra despues de caducidad: " Cadena
	read -p "Ingrese nombre de la llave: " Clave
	sudo gpg -u $Cadena --output Firma$Clave.pub --sign $Clave.pub #firmar key
	;;
	6) read -p "Ingrese nombre de la llave: " Clave
	sudo gpg --verify Firma$Clave.pub  #verificar firma  key
	;;
	7) read -p "Ingrese nombre del Archivo que desea cifrar: " ArchivoCA
	read -p "Ingrese Correo electronico" Correo
	sudo gpg --encrypt --output $ArchivoCA.gpg --recipient $Correo $ArchivoCA #Encriptar asimetrico
	;;
	esac
;;

4) echo "Descencriptar Asimetrico"
read -p "Ingrese Nombre del archivo que desea desencriptar: " ArchivoDA
sudo gpg -a --decrypt $ArchivoDA
;;

5) clear #submenu
	echo "Funciones de red"
	echo "1) Mostrar IP"
	echo "2) Arp"
	echo "3) Mostrar enlaces"
	echo "4) Mostrar rutas"

	read -p "Ingrese una opción: " opcion_redes
	case $opcion_redes in 

	1) 
	ifconfig
	echo "IP mostradas exitosamente"
	;;
	
	2) read -p "Ingrese nombre de interface: " nombre
	arp-scan --interface $nombre  --localnet
	;;
	
	3) ip link list
	echo "Enlaces mostrados exitosamente"
	;;
	
	4) ip route show
	echo "Rutas mostradas exitosamente"
	;;
	esac
;;
6) echo "Cambiar Permisos"
echo "--+--r--+--w--+--x--+"
echo "0=|--0--|--0--|--0--|"
echo "1=+--0--+--0--+--1--+"
echo "2=|--0--|--1--|--0--|"
echo "3=+--0--+--1--+--1--+"
echo "4=|--1--|--0--|--0--|"
echo "5=+--1--+--0--+--1--+"
echo "6=|--1--|--1--|--0--|"
echo "7=+--1--+--1--+--1--+"
read -p "Introduce el nombre del archivo al que deseas cambiar sus permisos o atributos: " Archivo
read -p "Introduce el permiso del propietario: " usuario
read -p"Introduce el permiso del grupo: " grupo
read -p"Introduce el permiso del otros: " otros
sudo chmod $usuario$grupo$otros $Archivo
clear
echo "Los Permisos para el archivo: ", $Archivo," fueron cambiador exitosamente"
ls -l
;;
7) echo "Hasta pronto, gracias por usar este script"
;;
esac