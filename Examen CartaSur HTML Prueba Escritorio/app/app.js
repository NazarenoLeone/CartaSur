const API_URL = 'http://svct.cartasur.com.ar:8081/api/Empleados';

const HTMLResponse = document.querySelector("#data-list");
const ul = document.createElement('ul');

// Variables para el ingreso de datos
// Obtener referencias a los elementos del DOM
const form = document.getElementById('empleado-form');
const dJson = document.getElementById('d-json');
const nombreInput = document.getElementById('nombre');
const apellidoInput = document.getElementById('apellido');
const estadoInput = document.getElementById('estado');
const listaEmpleados = document.getElementById('employee-list');
const listaEmpleadosA = document.getElementById('employee-list-a');
const listaEmpleadosI = document.getElementById('employee-list-i');

lista = [];

let enlaceDescarga;

// Extraer los datos de la API
fetch(`${API_URL}`).then((response) => response.json())
    .then((empleados) => {
        empleados.forEach(empleado => {
            let element = document.createElement('li');
            // element.appendChild(document.createTextNode(`${empleado.nombre} ${empleado.apellido}`));
            ul.appendChild(element);
            lista.push(`{\n  "nombre": "${empleado.nombre}",\n  "apellido: " ${empleado.apellido}",\n  "activo": ${empleado.activo}\n}`); // Pushea los que ya esten la lista.

            dividirActInact(empleado);

        });
        HTMLResponse.append(ul);
    });


// Manejar envío del formulario
form.addEventListener('submit', function (event) {
    event.preventDefault(); // Evitar el envío del formulario

    // Obtener los valores ingresados por el usuario
    const nombre = nombreInput.value;
    const apellido = apellidoInput.value;
    let estado = estadoInput.value;

    // Crear un nuevo elemento de lista con la información del empleado
    const li = document.createElement('li');
    const li2 = document.createElement('li');
    // li.textContent = `${firstName} ${lastName} - Estado: ${status}`;

    // Agregar el elemento de lista al listado de empleados
    li.textContent = `${nombre} ${apellido}`;
    li2.textContent = `${nombre} ${apellido}`;

    if (estado == 'activo') {
        // employeeList.appendChild(li2);
        estado = true;
        listaEmpleadosA.appendChild(li);
        ul.appendChild(li2);
    }
    else if (estado == 'inactivo') {
        // employeeList.appendChild(li2);
        estado = false;
        listaEmpleadosI.appendChild(li);
        ul.appendChild(li2);
    }
    else {
        console.log('Hubo un error');
    }

    GenerarJson(nombre, apellido, estado);

    // Restablecer los campos del formulario
    nombreInput.value = '';
    apellidoInput.value = '';
    estadoInput.value = 'activo';
});

function GenerarJson(nombre, apellido, estado) {
    // Convertir el objeto en una cadena JSON
    let datos = {
        nombre: nombre,
        apellido: apellido,
        activo: estado
    }

    const jsonString = JSON.stringify(datos, null, 2);
    lista.push(jsonString);

    // Crear un enlace de descarga
    if (!enlaceDescarga) {
        enlaceDescarga = document.createElement('a');
    }
    enlaceDescarga.classList.add('boton');
    // enlaceDescarga.classList.add('alinear-derecha');
    // enlaceDescarga.classList.add('w-sm-100');
    enlaceDescarga.classList.add('do-json');
    enlaceDescarga.href = 'data:application/json;charset=utf-8,' + encodeURIComponent(lista);
    enlaceDescarga.download = 'datos.json';
    enlaceDescarga.innerHTML = 'Descargar archivo JSON';

    // Agregar el enlace al elemento contenedor
    dJson.appendChild(enlaceDescarga);
}

function dividirActInact(empleado) {
    // Obtener los valores ingresados por el usuario
    const firstName = empleado.nombre;
    const lastName = empleado.apellido;
    const activo = empleado.activo;

    // Crear un nuevo elemento de lista con la información del empleado
    const li = document.createElement('li');
    const li2 = document.createElement('li');
    // li.textContent = `${firstName} ${lastName} - Estado: ${status}`;

    // Agregar el elemento de lista al listado de empleados
    li.textContent = `${firstName} ${lastName}`;
    li2.textContent = `${firstName} ${lastName}`;

    if (activo) {
        // employeeList.appendChild(li2);
        listaEmpleadosA.appendChild(li);
        ul.appendChild(li2);
    }
    else if (!activo) {
        // employeeList.appendChild(li2);
        listaEmpleadosI.appendChild(li);
        ul.appendChild(li2);
    }
    else {
        console.log('Hubo un error');
    }

    // Restablecer los campos del formulario
    nombreInput.value = '';
    apellidoInput.value = '';
    estadoInput.value = 'activo';
}


