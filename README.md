
# Sistema de Gestión de Refugiados

Este proyecto es una aplicación de escritorio construida con **.NET (Windows Forms)** que permite gestionar la información de refugiados, incluyendo su estado civil, tipo de documento, y su ubicación actual. Se conecta a una base de datos **SQL Server** y aplica buenas prácticas mediante el uso de patrones **DAO** y **DTO**.

---

## 🚀 Tecnologías utilizadas

- **.NET Framework / .NET Core** (según tu configuración)
- **Windows Forms (WinForms)**
- **Entity Framework Core**
- **SQL Server**
- **Visual Studio 2022**

---

## 📁 Estructura del proyecto

- `Entities/`: Entidades que representan las tablas de la base de datos.
- `Models/`: Objetos DTO para la transferencia de datos.
- `DAO/`: Clases que acceden a la base de datos (CRUD).
- `Data/`: Configuración del `DbContext` (`SistemaDbContext.cs`).
- `GUI/`: Interfaz gráfica de usuario (WinForms).

---

## ✅ Requisitos

Antes de ejecutar el proyecto, asegúrate de tener instalado:

- [ ] **Visual Studio 2022** con los siguientes componentes:
  - Desarrollo de escritorio con .NET
  - SQL Server Data Tools (opcional)
- [ ] **.NET Framework 4.7.2** o superior (si aplica)
- [ ] **SQL Server 2019** o superior (Express o completo)
- [ ] **Entity Framework Core** (se instala con NuGet si usas `.NET Core`)

---

## 🧩 Configuración de la base de datos

1. Crear una base de datos llamada `sistema_refugiados` en tu SQL Server.
2. Ejecutar los scripts de creación de tablas:

```sql
-- Tabla Refugiado
CREATE TABLE Refugiado (
    id_refugiado INT PRIMARY KEY IDENTITY,
    nombres VARCHAR(100),
    apellidos VARCHAR(100),
    fecha_nacimiento DATE,
    genero VARCHAR(10),
    identificacion VARCHAR(50),
    documento_identidad VARCHAR(50),
    estado_civil VARCHAR(20),
    fecha_ingreso_sistema DATE
);

-- Tabla Ubicacion
CREATE TABLE Ubicacion (
    id_ubicacion INT PRIMARY KEY IDENTITY,
    id_refugiado INT,
    pais VARCHAR(50),
    ciudad VARCHAR(50),
    tipo_albergue VARCHAR(100),
    coordenadas_gps VARCHAR(100),
    fecha_registro DATE,
    FOREIGN KEY (id_refugiado) REFERENCES Refugiado(id_refugiado) ON DELETE CASCADE
);
```

---

## ⚙️ Configurar la cadena de conexión

En el archivo `SistemaDbContext.cs`, asegúrate de que la cadena de conexión apunta correctamente a tu servidor SQL:

```csharp
options.UseSqlServer("Server=localhost\SQLEXPRESS;Database=sistema_refugiados;Trusted_Connection=True;TrustServerCertificate=True;");
```

---

## ▶️ Cómo ejecutar

1. Abre la solución `.sln` en Visual Studio.
2. Compila el proyecto.
3. Ejecuta el formulario principal (`FrmRefugiados` o similar).
4. ¡Listo! Ya puedes agregar, editar, consultar y eliminar refugiados desde la interfaz.

---

## 📊 Estadísticas

El sistema también incluye la funcionalidad de generación de estadísticas por país, obtenidas desde un procedimiento almacenado en SQL Server (`spEstadisticaRefugiadosPorPais`).

---


## 🧑‍💻 Autor

Desarrollado como proyecto académico. Puedes usar este sistema como base para proyectos similares con base de datos y WinForms.
