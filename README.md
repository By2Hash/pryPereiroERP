------ EPISODIO 1: La amenaza fantasma  -----

<img width="628" height="433" alt="{0F7E8070-B053-4751-ABFC-76199924C4A6}" src="https://github.com/user-attachments/assets/a757f0a1-44b8-4b5f-8f5a-4f701c7548d3" />


CONSIGNAS

1 - Crear una base de datos con los ususarios, perfiles y su relacion

2 - Crear una clase clsConexion en el proyecto y agregar la base de datos al proyecto

3 - Crear un formulario de Iniciar Sesion, con un txtUsuario o txtNombre y txtContraseña.
  * Se pide 3 intentos, si se agotan que se cierre el programa.
  * Si se ingresa bien el usuario y contraseña, abrir el formMain
  * Mostrar en el frmMain, el usuario que se conecto, rol-perfil y la hora en la que se conecto

4 (EXTRA) - Crear la tabla 'Auditoria - Sesion' 
  * Se debe grabar desde la clase
  * se tiene que insertar la fecha la hora en la que se conecto
  * El ususario que se conecto, un contador de cuantas veces inicio sesion
  * grabar los intentos fallidos


<img width="718" height="227" alt="image" src="https://github.com/user-attachments/assets/99b46639-a0ec-4105-a129-00103b2e0844" />


------ EPISODIO 2: El ataque de los clones -----


1 - Crear la interfaz de RRHH, para ingresar los datos personales de los usuarios, tanto direccion como mail y redes sociales

2 - Crear diferentes perfiles en la tabla 'Perfil', si en el Login se selecciona el RRHH en el comboBox, redirigir al nuevo form.

3 - 21/5/26 - Formularios listos, comboBoxs listos con los datos de la tablas correspondientes, falta programar el boton cuando el perdil sea RRHH para dirigir al formDatosPersonales

----- EPISODIO 3:  La venganza de los Sith  ------

1 - Una vez hecho la base de datos Auditoria, que grbae la hora y fecha en la que ingreso el usuario

2 - Crear una pantalla solo para el admin = frmMain. Se tiene que filtrar la informacion de auditoria.

Puntos a destacar: Mejorar la tabla de Auditoria, agregar mas funciones al frmMain para filtrar la tabla
<img width="640" height="391" alt="{0DA76E77-E634-4A04-BF0E-80BAC8C0580F}" src="https://github.com/user-attachments/assets/bc4e7e53-3090-4e4d-8f9b-f6ba22f19cad" />

En la tabla de 'Usuario', agregar todos las columnas 
Cambiar en la tabla 'Auditoria-Sesion' en la columna Intento, cambiarlo por un SI/NO.

Agregar la columna en Auditoria-Sesion, que registre los movimientos del usuario. Ej: Ingreso al frmMain(Panel de administrador), frmRRHH(Ingreso un nuevo usuario)

***** Mejoras 30/05/2026 *****
<img width="975" height="645" alt="image" src="https://github.com/user-attachments/assets/73af3c89-69e0-48a2-9129-e4f3c29e1dc5" />
Termine de implementar una grilla para visualizar la tabla de 'Auditoria'. Podria implementar radioButtons para filtar de manera ASC y DESC.

<img width="969" height="645" alt="image" src="https://github.com/user-attachments/assets/5aa4c3a8-a0ca-47a9-baa3-bf6dab40bf64" />
Agregue dos nuevas tablas, la de 'Domicilio_Usuario' y 'Contacto_Usuario', relacionadas o vinculadas con la tabla 'Usuario', para distribuir la informacion. Faltaria por incorporar la funcion de poder elegir mas de una red social.

----- EPISODIO 4: Una nueva esperanza ------

* Verificar en todos los campos txt en el que se ingresen numeros (DNI), hacer el keyPress 
* Implementar un radioButton en el frmLogin para mostrar la contraseña
* En el frmRRHH, implementar un Tab para tener pestañas independientes para ingresar/modificar y eliminar usuario, usando el Id
* Agregar un Icono al ejecutable (.exe)
  
* Cambiar el icono de todos los MessageBoxIncon, por el icono Warning
* UserFlow antingu de la interfaz: Login (frmLogin) → Main (frmMain) 
                                   Login (frmLogin) → Datos Personales (frmRRHH)

* UserFlow nuevo para la interfaz: Login (frmLogin) → Main (frm main), que este un tabControl para ver la grilla de la auditoria, si el usuario que ingreso es perfil 'Usuario', no tiene acceso a nada. 'RRHH', puede entrar solo al menu para registrar/modificar o eliminar usuario, 'Admin', tiene acceso a TODO

----- EPISODIO 5: El Imperio Contraataca ------
<img width="777" height="532" alt="{C8D6EAC2-A577-4A7C-AF5F-5FEF5B174611}" src="https://github.com/user-attachments/assets/9095d247-de17-4b04-9162-cbaf0f8eac68" />
Grilla de usuarios lista, falta poder modificar y eliminar usuarios haciendo doble clic en la grilla (_CellDoubleClick)
