# MiniProyecto-Calculadora

Mini proyecto desarrollado en C# para simular un flujo de trabajo ágil utilizando Git, GitHub y prácticas de calidad de software.

## Descripción

El proyecto consiste en una calculadora básica de consola que permite realizar cuatro operaciones matemáticas:

- Suma
- Resta
- Multiplicación
- División

También se agregó una validación para evitar la división entre cero.

## Prácticas de calidad aplicadas

### 1. Coding Standards

Se utilizó un archivo `.editorconfig` para establecer reglas de formato comunes para el código C#. Entre ellas se definieron el uso de espacios para la indentación, tamaño de indentación de cuatro espacios y otras reglas básicas de formato.

Esta práctica ayuda a evitar diferencias innecesarias en el estilo del código cuando varias personas trabajan en un mismo proyecto. También permite mantener un código más ordenado, consistente y fácil de revisar.

### 2. Pull Request y Code Review

El desarrollo de la calculadora se realizó en la rama `feature/calculadora` en lugar de trabajar directamente sobre `main`.

Una vez finalizados los cambios, la rama fue enviada a GitHub y se creó un Pull Request para revisar el código antes de integrarlo a la rama principal. Durante el Code Review se verificó la lógica de las operaciones y el manejo de la división entre cero.

Después de realizar la revisión, el Pull Request fue aprobado e integrado a `main`.

## Reflexión

La aplicación de estas prácticas me permitió comprender que no solamente es importante que un programa funcione, sino también mantener un proceso ordenado durante su desarrollo.

El uso de estándares de código ayuda a prevenir problemas de estilo y facilita que otras personas puedan comprender el código. Por otra parte, trabajar con ramas y Pull Requests permite revisar los cambios antes de incorporarlos al proyecto principal, disminuyendo la posibilidad de introducir errores.

Estas prácticas también ayudan a evitar una integración tipo "Big Bang", porque los cambios pueden desarrollarse, revisarse e integrarse de manera gradual. Esto reduce el retrabajo y permite detectar problemas cuando todavía son pequeños y más fáciles de solucionar.

En conclusión, considero que integrar continuamente pequeños cambios y revisarlos antes de incorporarlos a la rama principal permite desarrollar software de una manera más organizada, colaborativa y segura.

## Repositorio

Enlace al repositorio en GitHub:

https://github.com/rfuentes2627/MiniProyecto-Calculadora.git