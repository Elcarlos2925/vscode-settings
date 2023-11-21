sudo service postfix restart
clear

echo "1. Enviar correo con Mutt"
echo "2. Enviar correo con Mailx"
echo "3. Descifrar contenido de correo con Decode"
echo "4. Salir"

read -p "Selecciona una opción: " opcion

case $opcion in
    1)
        read -p "Escribe el asunto del correo: " asunto
        read -p "Escribe el cuerpo del correo: " cuerpo
        read -p "Escribe el destinatario: " destinatario
        echo "$cuerpo" | mutt -s "$asunto" $destinatario@localhost
        ;;
   2) 
   	read -p "Escribe el asunto del correo: " asunto
        read -p "Escribe el cuerpo del correo: " cuerpo
        read -p "Escribe el destinatario: " destinatario
        echo "$cuerpo" | mail -s "$asunto" $destinatario
        ;;
  3)
  	read -p "Escribe el destinatario: " destinatario
  	cd ..
  	cd ..
  	cd var
  	cd mail
  	sudo gedit $destinatario
  	;;
  4)
  	exit
  	;;
  	esac
