# Algebra Relacional con Entity Framework y Pubs

Este proyecto es una implementación de operaciones unarias de álgebra relacional (Selección, Proyección y Renombramiento) utilizando Entity Framework en C# sobre la base de datos **Pubs** de SQL Server.

---

## Contenido del Proyecto

- Consultas LINQ que representan las operaciones unarias:
  - **Selección (σ):** Filtrado de filas con distintos tipos de predicados.
  - **Proyección (π):** Extracción de columnas específicas eliminando duplicados.
  - **Renombramiento (ρ):** Cambio de nombres de atributos para facilitar claridad.

- Proyecto web ASP.NET con páginas para ejecutar las consultas y mostrar resultados.

- Modelo de datos generado con Entity Framework desde la base de datos Pubs.

---

## Requisitos

- Visual Studio 2019 o superior.
- SQL Server con la base de datos Pubs instalada.
- .NET Framework 4.x

---

## Cómo ejecutar el proyecto

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/RPMaykol/AgebraRelacionalPubs.git
