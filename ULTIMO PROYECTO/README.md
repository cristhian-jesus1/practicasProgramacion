# 🎬 Gestor de Películas

## 1. Contexto elegido y justificación

He elegido el **gestor de películas** porque es algo que uso en el día a día. Me gusta llevar un registro de las películas que quiero ver y las que ya he visto, pero siempre se me olvida en qué estado estaban. Con esta aplicación puedo apuntarlas todas, ver de qué género son y en qué año salieron. Me parece más entretenido que una lista de tareas normal y es fácil de entender para cualquier persona.

---

## 2. Estructura de la base de datos

**Archivo:** `peliculas.db` (SQLite)

**Tabla: `Peliculas`**

| Columna | Tipo    | Descripción                             |
|---------|---------|-----------------------------------------|
| Id      | INTEGER | Clave primaria, se autoincrementa       |
| Titulo  | TEXT    | Título de la película (obligatorio)     |
| Genero  | TEXT    | Género: Acción, Drama, Comedia...       |
| Anio    | INTEGER | Año de lanzamiento (campo extra añadido)|
| Vista   | INTEGER | 0 = pendiente de ver, 1 = ya vista      |

---

## 3. URLs de la aplicación

| URL                          | Método | Qué hace                                      |
|------------------------------|--------|-----------------------------------------------|
| `/Peliculas`                 | GET    | Muestra la lista de todas las películas       |
| `/Peliculas/Crear`           | GET    | Muestra el formulario para añadir una película|
| `/Peliculas/Crear`           | POST   | Guarda la nueva película en la base de datos  |
| `/Peliculas/Editar/{id}`     | GET    | Muestra el formulario de edición pre-relleno  |
| `/Peliculas/Editar/{id}`     | POST   | Guarda los cambios del registro editado       |
| `/Peliculas/Marcar/{id}`     | GET    | Marca la película como "ya vista"             |
| `/Peliculas/Eliminar/{id}`   | GET    | Elimina la película de la base de datos       |

---

## 4. Cambios realizados respecto al código base

### Parte 1 – Cambio de contexto
- Se renombró la entidad `Tarea` → `Pelicula` con sus propiedades: `Titulo`, `Genero`, `Anio`, `Vista`.
- El controlador `TareasController` fue reemplazado por `PeliculasController`.
- Las vistas se movieron a `Views/Peliculas/` y se adaptaron al nuevo contexto.
- La ruta por defecto en `Program.cs` apunta ahora a `PeliculasController`.

### Parte 2.1 – Campo extra (`Anio`)
- Se añadió la propiedad `Anio` (int) al modelo `Pelicula`.
- Se añadió la columna `Anio INTEGER NOT NULL` en el `CREATE TABLE` de `Database.cs`.
- Todas las queries SQL (`SELECT`, `INSERT`, `UPDATE`) incluyen ahora este campo.
- La vista Index muestra el año en la tabla.

### Parte 2.2 – Edición de registros
- Nueva acción `Editar` (GET): carga la película de la BD y la pasa a la vista.
- Nueva acción `Editar` (POST): recibe el formulario y actualiza el registro con `UPDATE`.
- El formulario en `Views/Peliculas/Editar.cshtml` llega pre-relleno con los datos actuales.
- También permite cambiar el estado "Vista" mediante un checkbox.

### Parte 2.3 – Validación en el controlador
- Antes de insertar o actualizar se comprueba que `Titulo` no está vacío y tiene más de 2 caracteres.
- También se comprueba que `Genero` no está vacío.
- Si la validación falla se devuelve la vista con un mensaje de error visible (`ViewBag.Error`) sin redirigir.
- Además, los campos del formulario usan el atributo HTML `pattern=".{3,}"` como validación extra en el navegador.

### CSS
- Se rediseñó completamente `wwwroot/css/site.css` con un tema oscuro inspirado en el cine (fondos azul marino, detalles en rojo `#e94560`, tabla con hover, badges para el género).

---

## 5. Capturas de pantalla

> Ejecuta la aplicación con el comando `dotnet run` dentro de la carpeta `TODO/` y abre `http://localhost:5000` en el navegador para ver todas las vistas.

### Vista principal (Index)
Lista todas las películas con título, género, año y si ya han sido vistas. Permite marcar como vista, editar o eliminar cada una.

### Vista Crear
Formulario para añadir una nueva película con validación en cliente y servidor.

### Vista Editar
Formulario igual al de crear pero con los campos ya rellenos con los valores actuales del registro.
