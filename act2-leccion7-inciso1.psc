Algoritmo sin_titulo
	Definir opcion Como Entero
	
    Escribir "=== BUZÓN DE VOZ ==="
    Escribir "1. Ventas"
    Escribir "2. Soporte técnico"
    Escribir "3. Atención al cliente"
    Escribir "4. Dejar un mensaje"
    Escribir "Seleccione una opción (1-4):"
    Leer opcion
	
    Segun opcion Hacer
        1:
            Escribir "Ha seleccionado VENTAS. Un asesor le atenderá."
        2:
            Escribir "Ha seleccionado SOPORTE TÉCNICO. Espere en línea."
        3:
            Escribir "Ha seleccionado ATENCIÓN AL CLIENTE."
        4:
            Escribir "Por favor, deje su mensaje después del tono."
        De Otro Modo:
            Escribir "Opción inválida. Intente nuevamente."
    FinSegun
FinAlgoritmo
