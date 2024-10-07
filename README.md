# LiteThinkingProject
Tarea1-Crear una Lista de Tareas (ToDo List) con .NET Core y Azure
Configuracion a Base de datos
Creacion de entidad requerida
## Características

1. **Operaciones CRUD**:
   - Crear una nueva tarea.
   - Obtener una lista de todas las tareas.
   - Obtener una tarea específica por su ID.
   - Actualizar una tarea (marcar como completada o cambiar título y descripción).
   - Eliminar una tarea.

2. **Arquitectura Hexagonal**:
   La aplicación sigue una arquitectura hexagonal (puertos y adaptadores) para mantener la separación de responsabilidades y lograr un código más mantenible.

3. **Tecnologías utilizadas**:
   - .NET Core 8
   - MediatR para el manejo de CQRS
   - AutoMapper para el mapeo de objetos
   - Azure SQL Database para almacenamiento en la nube
   - Azure App Service para el despliegue de la API

## Endpoints

| Método | Endpoint            | Descripción                                       |
|--------|---------------------|---------------------------------------------------|
| POST   | /api/activity/create | Crea una nueva tarea.                             |
| GET    | /api/activity        | Obtiene la lista de todas las tareas.             |
| GET    | /api/activity/{id}   | Obtiene una tarea específica por su ID.           |
| PUT    | /api/activity/update | Actualiza una tarea existente.                    |
| DELETE | /api/activity/{id}   | Elimina una tarea específica por su ID.           |
