# 🧮 Calculadora - Pipeline CI/CD

[![Pipeline IC y SonarQube](https://github.com/gusti233/ics-calculadora-ic-cd/actions/workflows/ci.yaml/badge.svg)](https://github.com/gusti233/ics-calculadora-ic-cd/actions/workflows/ci.yaml)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=gusti233_ics-calculadora-ic-cd&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=gusti233_ics-calculadora-ic-cd)

## 📝 Descripción
Este proyecto es una Calculadora implementada en **.NET**, desarrollada como parte de las prácticas académicas de Ingeniería en Sistemas de Información, en la materia de Ingeniería y Calidad de Software. El objetivo principal de este repositorio es demostrar la implementación sólida de una arquitectura profesional de **Integración Continua (CI)** y **Entrega Continua (CD)**.

## 🚀 Tecnologías Utilizadas
* **Lenguaje y Framework:** .NET / C#
* **Testing Automatizado:** SpecFlow (Behavior-Driven Development)
* **Análisis de Código (Calidad y Seguridad):** SonarCloud
* **Contenedores:** Docker & Docker Hub
* **Automatización:** GitHub Actions
* **Notificaciones:** Slack Webhooks

## ⚙️ Arquitectura CI/CD
El pipeline automatizado (`ci.yml`) realiza las siguientes tareas en cada actualización a la rama principal:
1. **Build:** Descarga el código y compila la solución en un entorno Ubuntu.
2. **Test:** Ejecuta las pruebas automatizadas con SpecFlow.
3. **Análisis:** Envía el código a SonarCloud para evaluar vulnerabilidades, "code smells" y cobertura.
4. **Empaquetado:** Si el Quality Gate es aprobado, construye la imagen Docker.
5. **Despliegue:** Sube la imagen a Docker Hub de manera pública.
6. **Notificación:** Envía una alerta al canal de Slack indicando el resultado.

## 📦 Cómo ejecutar con Docker
Puedes descargar y ejecutar la última versión estable de esta calculadora desde Docker Hub utilizando estos comandos:

```bash
docker pull gusti233/calculadora-gpa:latest
docker run -it gusti233/calculadora-gpa:latest
```

## 👨‍💻 Autor
**Tomás Suárez**
Estudiante de 4to año - Ingeniería en Sistemas de Información
