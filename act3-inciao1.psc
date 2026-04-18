Algoritmo sin_titulo
	Definir dia, mes Como Entero
	
    Escribir "Ingrese el día:"
    Leer dia
    Escribir "Ingrese el mes (1-12):"
    Leer mes
	
    Si (mes = 12 Y dia >= 21) O (mes = 1) O (mes = 2) O (mes = 3 Y dia < 21) Entonces
        Escribir "Invierno"
    Sino
        Si (mes = 3 Y dia >= 21) O (mes = 4) O (mes = 5) O (mes = 6 Y dia < 21) Entonces
            Escribir "Primavera"
        Sino
            Si (mes = 6 Y dia >= 21) O (mes = 7) O (mes = 8) O (mes = 9 Y dia < 23) Entonces
                Escribir "Verano"
            Sino
                Escribir "Otoño"
            FinSi
        FinSi
    FinSi
FinAlgoritmo
