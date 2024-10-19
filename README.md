# FDV_Physics_Tilemaps

# Físicas 2D

## **_1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity._**

Añadimos dos personajes en la escena y un rectángulo. Uno de esos personajes, será controlado por el jugador con un sencillo script de movimiento, mientras que el otro será un "enemigo", aunque no tenga ningún script particular.
Ambos personajes serán nuestros sujetos de prueba para los siguientes apartados. Por otro lado, el rectángulo servirá como un suelo para que los personajes no caigan al vacío cuando empecemos a añadir físicas.

![image](https://github.com/user-attachments/assets/26ef367b-10cf-4eb7-9e08-e5517812739f)

### _a. Ninguno de los objetos será físico._

![Ejercicio1a](https://github.com/user-attachments/assets/3b19f17c-1a92-4c63-9580-07929f1c110b)

### _b. Un objeto tiene físicas y el otro no._

Añadimos los componentes `Rigidbody2D` y `BoxCollider2D` al jugador y al suelo, para evitar que el personaje caiga al vacío. El `BodyType` en el componente `Rigidbody2D` del personaje será `Dynamic`, mientras que el del suelo será estático.

![image](https://github.com/user-attachments/assets/ece6b4dd-89fb-4d44-9960-de4505e6c928)

![Ejercicio1b](https://github.com/user-attachments/assets/4d3cc567-48f7-4863-8a16-2bd9ea6b414f)

### _c. Ambos objetos tienen físicas._

Añadimos las mismas físicas que incluimos al personaje controlado por el jugador (`Rigidbody2D` y `BoxCollider2D`) al enemigo.

![image](https://github.com/user-attachments/assets/4bcd2ed8-8f80-4ac4-b5de-3ab7e984061a)

![Ejercicio1c](https://github.com/user-attachments/assets/5f515b10-4452-4885-a3ff-ab0218d5f076)

### _d. Ambos objetos tienen físicas y uno de ellos tiene 10 veces más masa que el otro._

Aumentamos a 10 la variable `Mass` del componente `Rigidbody2D` del enemigo.

![image](https://github.com/user-attachments/assets/9ea8246f-e8ba-4d78-9787-01ff67078dec)

![Ejercicio1d](https://github.com/user-attachments/assets/f035ebe6-1568-487d-aa1c-88c003404a83)

### _e. Un objeto tiene físicas y el otro es IsTrigger._

Eliminamos el `Rigidbody2D` del enemigo y marcamos la opción `IsTrigger` de su `BoxCollider2D`, lo que hará que el enemigo sea ignorado por las físicas del jugador.

![image](https://github.com/user-attachments/assets/b8c5de17-9daf-4158-a4d9-0b37cd53c649)

![Ejercicio1e](https://github.com/user-attachments/assets/55af95f0-20ba-4747-bc84-010d49bfc2ab)

### _f. Ambos objetos son físicos y uno de ellos está marcado como IsTrigger._

Volvemos a añadir un `Rigidbody2D` al enemigo y dejamos marcada la opción `IsTrigger`.

![image](https://github.com/user-attachments/assets/7965f54c-6467-488f-bf16-79985d10a1f9)

![Ejercicio1f](https://github.com/user-attachments/assets/e4a76ca9-1f43-4d33-ad9c-85e8a4abcd1a)

### _g. Uno de los objetos es cinemático._

Cambiamos el `Rigidbody2D.BodyType` del enemigo a `Kinematic`.

![image](https://github.com/user-attachments/assets/0fbc7199-3e46-4bd0-bd44-03867ea1842a)

![Ejercicio1g](https://github.com/user-attachments/assets/3133ff05-c754-4aaa-9ee3-4896a1828c76)

## **_2. Incorpora elementos físicos en tu escena que respondan a las siguientes restricciones:_**

### _a. Objeto estático que ejerce de barrera infranqueable_

Este apartado ya se ha hecho al incorporar el objeto que sirve como suelo en los apartados del ejercicio 1.

### _b. Zona en la que los objetos que caen en ella son impulsados hacia adelante._

Añadimos un nuevo GameObject en la escena con los componentes `AreaEffector2D` y `BoxCollider2D`. Este último ha de tener las variables `IsTrigger` y `UsedByEffector` a `true`.

![image](https://github.com/user-attachments/assets/becab9d0-f06e-4633-b0f9-d43c237df9ef)

![Ejercicio2b](https://github.com/user-attachments/assets/00f1f2e3-9b3b-4bff-ba9c-c39790cd9072)

### _c. Objeto que es arrastrado por otro a una distancia fija._

Añadimos otro GameObject nuevo y le añadimos los componentes `Rigidbody2D`, `DistanceJoint2D` y `CircleCollider2D`. Luego, marcamos la opción `DistanceJoint2D.EnableCollision` y asignamos una referencia a `DistanceJoint2D.ConnectedRigidbody` que apunte a nuestro personaje.

![image](https://github.com/user-attachments/assets/5becab46-7a88-44c7-aa16-fadf210767d4)

![Ejercicio2c](https://github.com/user-attachments/assets/7309900a-9fb1-4810-90f6-d00ec1e2876c)

### _d. Objeto que al colisionar con otros sigue un comportamiento totalmente físico._

Se añade un objeto con un `Rigidbody2D` cinemático.

![Ejercicio2d](https://github.com/user-attachments/assets/962fcc38-4dea-4cd1-aa26-13a9b9f55e63)

### _e. Incluye dos capas que asignes a diferentes tipos de objetos y que permita evitar colisiones entre ellos._

Añadimos las capas `Main` y `Props`. La primera será añadida al jugador, mientras que la segunda capa al otro personaje en la escena.

![image](https://github.com/user-attachments/assets/0fc896bf-0976-4206-b0d1-6916afc6768e)

![image](https://github.com/user-attachments/assets/75f26028-58d7-4cd4-987b-ba07cfd46466)

Luego, nos dirigimos a `Edit > Preferences > Physics 2D > Layer Collision Matrix` y desmarcamos la relación `Props/Main`, para que se ignoren las colisiones entre ambas capas.

![image](https://github.com/user-attachments/assets/5d770724-04cb-457e-9d82-e3b4becb0990)

![Ejercicio2e](https://github.com/user-attachments/assets/86da774d-6851-414d-b1ec-78b10100a710)

# Tilemaps

