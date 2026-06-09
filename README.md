# PryPereiroERP

> Sistema de gestión empresarial desarrollado en fases progresivas.

---

## 📋 Episodio 1: La Amenaza Fantasma

<img width="628" height="433" alt="episodio1" src="https://github.com/user-attachments/assets/a757f0a1-44b8-4b5f-8f5a-4f701c7548d3" />

### Objetivos

1. **Base de datos** — Crear una base de datos con usuarios, perfiles y su relación.
2. **Conexión** — Crear la clase `clsConexion` en el proyecto y agregar la base de datos.
3. **Formulario de inicio de sesión** — Crear un formulario con:
   - Campos `txtUsuario` (o `txtNombre`) y `txtContraseña`.
   - Máximo **3 intentos** de inicio; al agotarlos, la aplicación se cierra.
   - Al ingresar credenciales válidas, abrir `frmMain`.
   - En `frmMain`, mostrar el usuario conectado, su rol/perfil y la hora de conexión.
4. ***(Extra)*** **Tabla `Auditoria_Sesion`**:
   - Registrar desde la clase los datos de sesión.
   - Insertar fecha y hora de conexión.
   - Almacenar el usuario conectado y un contador de inicios de sesión.
   - Registrar los intentos fallidos.

<img width="718" height="227" alt="diagrama" src="https://github.com/user-attachments/assets/99b46639-a0ec-4105-a129-00103b2e0844" />

---

## 📋 Episodio 2: El Ataque de los Clones

1. **Interfaz de RRHH** — Crear la interfaz para ingresar datos personales de los usuarios (dirección, correo y redes sociales).
2. **Perfiles** — Crear distintos perfiles en la tabla `Perfil`. Si en el login se selecciona `RRHH` en el `ComboBox`, redirigir al nuevo formulario.
3. **Estado** *(21/05/26)* — Formularios y `ComboBox` completados con datos de las tablas correspondientes. Pendiente: programar la redirección al `formDatosPersonales` cuando el perfil sea `RRHH`.

---

## 📋 Episodio 3: La Venganza de los Sith

1. **Auditoría** — Con la base de datos `Auditoria` creada, registrar la hora y fecha de ingreso del usuario.
2. **Pantalla de administración** — Crear una pantalla exclusiva para el administrador (`frmMain`) que permita filtrar la información de auditoría.

### Mejoras aplicadas

- Mejorar la tabla `Auditoria` y agregar más funcionalidades de filtrado en `frmMain`.

<img width="640" height="391" alt="admin" src="https://github.com/user-attachments/assets/bc4e7e53-3090-4e4d-8f9b-f6ba22f19cad" />

- En la tabla `Usuario`, agregar todas las columnas necesarias.
- En `Auditoria_Sesion`, cambiar la columna `Intento` por un valor `SI/NO`.
- Agregar una columna en `Auditoria_Sesion` que registre los movimientos del usuario.
  - *Ejemplo:* Ingreso a `frmMain` (Panel de administrador), `frmRRHH` (registro de nuevo usuario).

#### Mejoras — 30/05/2026

<img width="975" height="645" alt="grilla_auditoria" src="https://github.com/user-attachments/assets/73af3c89-69e0-48a2-9129-e4f3c29e1dc5" />

- Se implementó una grilla para visualizar la tabla `Auditoria`. Pendiente: agregar `RadioButtons` para filtrar de forma ascendente/descendente.

<img width="969" height="645" alt="nuevas_tablas" src="https://github.com/user-attachments/assets/5aa4c3a8-a0ca-47a9-baa3-bf6dab40bf64" />

- Se agregaron las tablas `Domicilio_Usuario` y `Contacto_Usuario`, vinculadas a la tabla `Usuario` para distribuir la información.
- Pendiente: permitir la selección de más de una red social.

---

## 📋 Episodio 4: Una Nueva Esperanza

### Tareas

- Verificar en todos los campos `txt` donde se ingresen números (ej. DNI) el evento `KeyPress` correspondiente.
- Implementar un `RadioButton` en `frmLogin` para mostrar/ocultar la contraseña.
- En `frmRRHH`, implementar un `TabControl` con pestañas independientes para **ingresar**, **modificar** y **eliminar** usuarios mediante el ID.
- Agregar un icono personalizado al ejecutable (`.exe`).
- Cambiar el ícono de todos los `MessageBox` a `Warning`.

### Flujo de usuario

#### Anterior

```
Login (frmLogin) → Main (frmMain)
Login (frmLogin) → Datos Personales (frmRRHH)
```

#### Nuevo

```
Login (frmLogin) → Main (frmMain)
```

- El `frmMain` contiene un `TabControl` para visualizar la grilla de auditoría.
  - Perfil **Usuario**: sin acceso.
  - Perfil **RRHH**: acceso solo al menú de registro/modificación/eliminación de usuarios.
  - Perfil **Admin**: acceso completo a todas las funcionalidades.

---

## 📋 Episodio 5: El Imperio Contraataca

<img width="777" height="532" alt="grilla_usuarios" src="https://github.com/user-attachments/assets/9095d247-de17-4b04-9162-cbaf0f8eac68" />

- Grilla de usuarios implementada.
- Pendiente: poder **modificar** y **eliminar** usuarios mediante doble clic en la grilla (`CellDoubleClick`).

---

## 🚀 Stack tecnológico

- **Lenguaje:** C# / .NET
- **Base de datos:** Microsoft Access
- **Arquitectura:** Windows Forms
- **Asistente de IA:** opencode
