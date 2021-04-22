# Prueba Inalambria
1. [Descripción](#Descripción-)
2. [Configuración del proyecto](#configuraci%C3%B3n-del-proyecto-%EF%B8%8F)
3. [Utilidades](#Utilidades-)
4. [Ejecución del proyecto](#ejecuci%C3%B3n-del-proyecto-%EF%B8%8F)
5. [Tecnologías](#Tecnologías-)
6. [Autor](#Autor-)

## Descripción 📖
API para consultar las ventas realizadas según diferentes criterios de búsqueda

## Configuración del proyecto ⚙️
Git:

    git clone https://github.com/dcalderon96/Prueba_Inalambria.git
    cd Prueba_Inalambria

o descarga el archivo [zip](https://github.com/dcalderon96/Prueba_Inalambria/archive/refs/heads/master.zip).

## Utilidades 🔍
En el repositorio se encuentra el archivo **Prueba_Inalambria.postman_collection**, el cual tiene como finalidad ayudar a realizar las pruebas de consumo del API.

## Ejecución del proyecto ▶️
1. Restaurar el BackUp **Prueba_Inalambria.bak** de la base de datos en el servidor del equipo en el cual se abrira la solución.
2. Modificar las cadenas de conexión en los Configs de los
siguientes proyectos: *Aplicacion/HermesWebService* e *Infraestructura/DataConnection.* 

    En el atributo data source de la siguiente cadena de conexión se debe indicar el servidor e instancia de SQL Server del equipo donde se ejcutará el proyecto.

```
<add name="HermesServiceEntities" connectionString="metadata=res://*/HermesDataModel.csdl|res://*/HermesDataModel.ssdl|res://*/HermesDataModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=LAPTOP-DELL-DAN;initial catalog=Prueba_Inalambria;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data EntityClient" />
``` 
3. Abrir la colección de Postman y verificar que el puerto asignado para el localhost corresponda al *44316*, de lo contrario modificar al puerto correcto en el endpoint de cada método.

## Tecnologías 💻
- C#
- .NET Framework
- Entity Framework
- Linq

## Autor 👨
Daniel Felipe Calderón <d.calderon96.dc@gmail.com>