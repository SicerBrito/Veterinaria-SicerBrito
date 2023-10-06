# Veterinaria-SicerBrito
Filtro Veterinaria Campuslands Proyecto 4 Capas


Consultas 
## Grupo A

1. Crear un consulta que permita visualizar los veterinarios cuya especialidad sea Cirujano vascular. (VeterinarioController) 

    http://localhost:9000/api/veterinario/especialidadCirujano  
    Primero cree el mertodo que iba a implentar dentro de esta [interfas](BackEnd/Dominio/Interfaces/IVeterinario.cs) he hice la configuracion en [repository](BackEnd/Aplicacion/Repository/VeterinarioRepository.cs) y al final lo implemente en el controlador [controlador](BackEnd/API/Controllers/VeterinarioController.cs). 

    

2. Listar los medicamentos que pertenezcan a el laboratorio Genfar

    http://localhost:9000/api/laboratorio/laboratorioGenfar
    Primero cree el mertodo que iba a implentar dentro de esta [interfas](BackEnd/Dominio/Interfaces/ILaboratorio.cs) he hice la configuracion en [repository](BackEnd/Aplicacion/Repository/VeterinarioRepository.cs) y al final lo implemente en el controlador [controlador](BackEnd/API/Controllers/LaboratorioController.cs). 


3. Mostrar las mascotas que se encuentren registradas cuya especie sea felina.

4. Listar los propietarios y sus mascotas.


5. Listar los medicamentos que tenga un precio de venta mayor a 50000 (MEDICAMENTO)
 
    http://localhost:9000/api/medicamento/medicamentomayor50000
    Primero cree el mertodo que iba a implentar dentro de esta [interfas](BackEnd/Dominio/Interfaces/IMedicamento.cs) he hice la configuracion en [repository](BackEnd/Aplicacion/Repository/MedicamentoRepository.cs) y al final lo implemente en el controlador [controlador](BackEnd/API/Controllers/MedicamentoController.cs). 


6. Listar las mascotas que fueron atendidas por motivo de vacunacion en el primer trimestre del 2023 (mascotas)




