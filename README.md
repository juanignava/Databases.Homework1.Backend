# TecBankBackend

Instrucciones para usar el backend:

1) descargar .Net Core SDK (https://dotnet.microsoft.com/download)
2) clonar el repo (https://github.com/juanignava/TecBankBackend)
3) abrir una terminal en la carpeta del proyecto y escirbir "dotnet build"
4) despues escribir "dotnet run"
5) si no hay errores entonces ya se esta corriendo el backend en "http://localhost:5000"

Aciones implementadas:

1) Get all clients:

Para esta se debe usarla action GET de http con la url http://localhost:5000/client
retorna los clientes por medio de un JSON, por ejemplo:

[
    {
        "id": 1,
        "username": "juanignava",
        "password": "1234",
        "clientType": "legal",
        "monthlyIncome": 1000,
        "name": {
            "firstName": "Juan",
            "secondName": "Ignacio",
            "lastName1": "Navarro",
            "lastName2": "Navarro"
        },
        "adress": {
            "province": "Cartago",
            "canton": "Cartago",
            "district": "Oriental",
            "neighborhood": "Pitahaya",
            "aditionalDescription": "Residencial"
        }
    },
    {
        "id": 2,
        "username": "marco",
        "password": "1234",
        "clientType": "legal",
        "monthlyIncome": 3000,
        "name": {
            "firstName": "Marco",
            "secondName": null,
            "lastName1": "Rivera",
            "lastName2": "Meneses"
        },
        "adress": {
            "province": "Cartago",
            "canton": "Cartago",
            "district": "Occidental",
            "neighborhood": "Guadalupe",
            "aditionalDescription": "Residencial"
        }
    }
]

2) Get one client by id:

Para esta se debe usarla action GET de http con la url http://localhost:5000/client/id/#
donde # es un numero de id valido retorna el cliente por medio de un JSON, por ejemplo:

{
    "id": 1,
    "username": "juanignava",
    "password": "1234",
    "clientType": "legal",
    "monthlyIncome": 1000,
    "name": {
        "firstName": "Juan",
        "secondName": "Ignacio",
        "lastName1": "Navarro",
        "lastName2": "Navarro"
    },
    "adress": {
        "province": "Cartago",
        "canton": "Cartago",
        "district": "Oriental",
        "neighborhood": "Pitahaya",
        "aditionalDescription": "Residencial"
    }
}

3) Get one client by username:

Para esta se debe usarla action GET de http con la url http://localhost:5000/client/username/usr
donde usr es un string del username valido retorna el cliente por medio de un JSON, por ejemplo:

{
    "id": 1,
    "username": "juanignava",
    "password": "1234",
    "clientType": "legal",
    "monthlyIncome": 1000,
    "name": {
        "firstName": "Juan",
        "secondName": "Ignacio",
        "lastName1": "Navarro",
        "lastName2": "Navarro"
    },
    "adress": {
        "province": "Cartago",
        "canton": "Cartago",
        "district": "Oriental",
        "neighborhood": "Pitahaya",
        "aditionalDescription": "Residencial"
    }
}

4) Post one client

Para esta se debe usarla action POST de http con la url http://localhost:5000/client
con un JSON un body como el anterior.
