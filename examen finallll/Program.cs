#include <iostream>
#include <string>
using namespace std;

struct Estudiante
{
    string nombre;
    int edad;
    string genero;
    float calificaciones[5];
};

void agregarEstudiante(Estudiante estudiantes[], int& contador)
{
    Estudiante estudiante;

    cout << "Ingrese el nombre del estudiante: ";
    cin.ignore();
    getline(cin, estudiante.nombre);

    cout << "Ingrese la edad del estudiante: ";
    cin >> estudiante.edad;

    cout << "Ingrese el genero del estudiante: ";
    cin.ignore();
    getline(cin, estudiante.genero);

    for (int i = 0; i < 5; i++)
    {
        cout << "Ingrese la calificacion para la asignatura " << i + 1 << ": ";
        cin >> estudiante.calificaciones[i];
    }

    estudiantes[contador] = estudiante;
    contador++;

    cout << "Estudiante agregado correctamente." << endl;
}

void mostrarEstudiantes(Estudiante estudiantes[], int contador)
{
    if (contador == 0)
    {
        cout << "No hay estudiantes registrados." << endl;
        return;
    }

    cout << "Lista de estudiantes:" << endl;

    for (int i = 0; i < contador; i++)
    {
        cout << "Nombre: " << estudiantes[i].nombre << endl;
        cout << "Edad: " << estudiantes[i].edad << endl;
        cout << "Genero: " << estudiantes[i].genero << endl;

        cout << "Calificaciones:" << endl;
        for (int j = 0; j < 5; j++)
        {
            cout << "Asignatura " << j + 1 << ": " << estudiantes[i].calificaciones[j] << endl;
        }

        cout << endl;
    }
}

void buscarEstudiante(Estudiante estudiantes[], int contador)
{
    string nombreBuscado;

    cout << "Ingrese el nombre del estudiante a buscar: ";
    cin.ignore();
    getline(cin, nombreBuscado);

    bool encontrado = false;

    for (int i = 0; i < contador; i++)
    {
        if (estudiantes[i].nombre == nombreBuscado)
        {
            cout << "Estudiante encontrado:" << endl;
            cout << "Nombre: " << estudiantes[i].nombre << endl;
            cout << "Edad: " << estudiantes[i].edad << endl;
            cout << "Genero: " << estudiantes[i].genero << endl;

            cout << "Calificaciones:" << endl;
            for (int j = 0; j < 5; j++)
            {
                cout << "Asignatura " << j + 1 << ": " << estudiantes[i].calificaciones[j] << endl;
            }

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        cout << "Estudiante no encontrado." << endl;
    }
}

void editarEstudiante(Estudiante estudiantes[], int contador)
{
    string nombreBuscado;

    cout << "Ingrese el nombre del estudiante a editar: ";
    cin.ignore();
    getline(cin, nombreBuscado);

    bool encontrado = false;

    for (int i = 0; i < contador; i++)
    {
        if (estudiantes[i].nombre == nombreBuscado)
        {
            cout << "Estudiante encontrado. Ingrese la nueva informacion:" << endl;

            cout << "Nuevo nombre: ";
            getline(cin, estudiantes[i].nombre);

            cout << "Nueva edad: ";
            cin >> estudiantes[i].edad;

            cout << "Nuevo genero: ";
            cin.ignore();
            getline(cin, estudiantes[i].genero);

            for (int j = 0; j < 5; j++)
            {
                cout << "Nueva calificacion para la asignatura " << j + 1 << ": ";
                cin >> estudiantes[i].calificaciones[j];
            }

            encontrado = true;
            cout << "Informacion del estudiante actualizada correctamente." << endl;
            break;
        }
    }

    if (!encontrado)
    {
        cout << "Estudiante no encontrado." << endl;
    }
}

int main()
{
    Estudiante estudiantes[100];
    int contador = 0;
    int opcion;

    do
    {
        cout << "*******************" << endl;
        cout << "Sistema de Gestion de Estudiantes" << endl;
        cout << "*******************" << endl;
        cout << "1. Agregar estudiante" << endl;
        cout << "2. Mostrar estudiantes" << endl;
        cout << "3. Buscar estudiante" << endl;
        cout << "4. Editar estudiante" << endl;
        cout << "0. Salir" << endl;
        cout << "*******************" << endl;
        cout << "Ingrese una opcion: ";
        cin >> opcion;

        switch (opcion)
        {
            case 1:
                agregarEstudiante(estudiantes, contador);
                break;
            case 2:
                mostrarEstudiantes(estudiantes, contador);
                break;
            case 3:
                buscarEstudiante(estudiantes, contador);
                break;
            case 4:
                editarEstudiante(estudiantes, contador);
                break;
            case 0:
                cout << "Saliendo del programa..." << endl;
                break;
            default:
                cout << "Opcion invalida. Intente nuevamente." << endl;
        }

        cout << endl;
    } while (opcion != 0);

    return 0;
}
