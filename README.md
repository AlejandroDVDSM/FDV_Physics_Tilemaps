# FDV_Physics_Tilemaps

# Físicas 2D

## **1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity.**

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

## **2. Incorpora elementos físicos en tu escena que respondan a las siguientes restricciones:**

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

El script empleado para esta actividad se puede encontrar en `Assets/Scripts/PhysicsExercises/PlayerMovement.cs`

# Tilemaps

## **1. Construir un mapa de juego.**

Desde la pestaña _"Hierarchy"_ hacemos click derecho y seleccionamos `2D Object > Tilemap > Rectangular` para crear el tilemap. Ahora pinchamos en el objeto recién creado y pulsamos el botón _"Open Tile Palette"_ que debe aparecer en la pestaña _"Scene"_. Esto abrirá la pestaña _"Tile Palette"_, donde podremos crear una nueva paleta.

![image](https://github.com/user-attachments/assets/de8abcbb-4a93-4a37-a458-d7fc7c0ef426)

Con la paleta recién creada, seleccionamos los sprites que nos interese incluir en el mapa y los arrastramos hasta nuestra paleta.

![image](https://github.com/user-attachments/assets/4b8a664e-3186-4dd7-b740-ddf6d26c2b91)

Ahora, vamos seleccionamos el asset que nos interese y lo pintamos en la escena.

![image](https://github.com/user-attachments/assets/a8b10b31-b6f2-4f24-815e-2758032dc084)

Por el momento solo hemos pintado el fondo, que representa un cielo.

## 2. Usar varios tilemaps.

### _a. Crea dos Tilemaps adicionales, uno puede representar elementos decorativos y otro obstáculos._

Por el momento solo tenemos el cielo pintado en nuestro mapa. Es hora de crear un nuevo tilemap llamado `Tilemap_Ground` que represente la superficie por la que caminará el jugador.

![image](https://github.com/user-attachments/assets/21ba025f-bf85-4a5b-9d41-d684077386a1)

Además, se creará un tilemap más para añadir algo de vida al juego. Este nuevo tilemap es `Tilemap_Decoration`.

![image](https://github.com/user-attachments/assets/d9ded930-28b7-4554-9f04-a22beba8141d)

### _b. Agrega a la capa de obstáculos la configuración necesaria para que el Tilemap se construya de forma independiente y el obstáculo actúe como tal._

Añadimos el componente `TilemapCollider2D` en `Tilemap_Ground`, marcando la opción `UsedByComposite`. A continuación, añadimos el componente `CompositeCollider2D`, que añadirá automáticamente un `Rigidbody2D`. Por último, establecemos el `Rigidbody2D.BodyType` a `Static`, para que no se vea afectado por las físicas y se caiga al vacío. 

![image](https://github.com/user-attachments/assets/9796291b-94f2-4384-bf13-a3d04f4920f6)

![Ejercicio2b](https://github.com/user-attachments/assets/a8536fcc-404f-4f23-899e-7a21d34833ad)

## 3. Implementar un control de personajes basado en físicas.

### _a. Movimiento basado en físicas_

Añadimos las siguientes variables:

* `_moveSpeed`: indicará la velocidad del jugador.
* `_horizontalMovement`: indicará si el jugador se está moviendo. Y en caso de hacerlo, su valor será -1 si se mueve en el eje negativo de la X o 1 si lo hace en el positivo.
* `_direction`: la dirección a la que debe moverse el jugador.
* `_rigidbody2D`: la referencia al `Rigidbody2D` del jugador. Está será inicializada en el método `Start()` con la ayuda del método `GetComponent<T>()`.

También se crearán más variables, pero solo se han comentado las empleadas para el movimiento.

```c#
[SerializeField] private float _moveSpeed = 10.0f;

private float _horizontalMovement;
private Vector3 _direction;

private Rigidbody2D _rigidbody2D;
```

En el método `Update()`, comprobamos si el jugador está pulsando las teclas `A`, `S`, `<-` o `->`. En caso de que lo esté haciendo, modificamos `_direction`.

```c#
private void Update()
{
    _horizontalMovement = Input.GetAxisRaw("Horizontal");

    if (_horizontalMovement != 0)
    {
        _animator.SetBool(IsWalking, true);
        _spriteRenderer.flipX = _horizontalMovement > 0;
        
        _direction = new Vector3(_horizontalMovement, 0, 0).normalized;
    }
```

Finalmente, desde el método `FixedUpdate()`, emplearemos el método `Rigidbody2D.MovePosition(Vector2 position)` para lograr nuestro objetivo.

```c#
private void FixedUpdate()
{
    if (_horizontalMovement != 0)
    {
        _rigidbody2D.MovePosition(transform.position + _direction * (_moveSpeed * Time.fixedDeltaTime));
    }
}
```

No se incluye ningún gif del resultado porque ya se ha visto en los apartados anteriores.

### _b. Salto_

Primero, crearemos una etiqueta llamada _"Ground"_ se la aplicaremos a `Tilemap_Ground`.

![image](https://github.com/user-attachments/assets/8063d8bd-8ad9-4bbb-8f1d-8b8ec1a4d054)

A continuación, incrementamos el `Rigidbody2D.GravityScale` del jugador a 5 para que la gravedad afecte con más fuerza al personaje y empiece a caer de forma natural cuando alcanza su punto más alto durante un salto.

Luego, añadiremos tres nuevas variables:
* `bool _isJumping`: la usaremos para evitar que el jugador pueda saltar infinitamente.
* `bool _isGrounded`: nos indicará si el jugador se encuentra en el suelo.
* `float _jumpForce`: la fuerza que se empleará en el salto.

Ahora, desde el método `Update()`, comprobamos que la barra espaciadora se ha pulsado y que el jugador no se encuentre en medio de un salto. Si ese es el caso, pondremos `_isJumping` a `true` y desde `FixedUpdate()` emplearemos el método `Rigidbody2D.AddForce(Vector2 force, ForceMode2D mode)`.

```c#

private void Update() {
    // ....
    if (Input.GetKeyDown(KeyCode.Space) && !_isJumping)
        _isJumping = true;
}

private void FixedUpdate()
{
    if (_horizontalMovement != 0 && _isGrounded)
        _rigidbody2D.MovePosition(transform.position + _direction * (_moveSpeed * Time.fixedDeltaTime));

    if (_isJumping && _isGrounded)
    {
        _isGrounded = false;
        _rigidbody2D.AddForce(new Vector2(_horizontalMovement / 2, 1) * _jumpForce, ForceMode2D.Impulse);
    }
}
```

Para terminar, cuando el jugador haya colisionado con el suelo tras el salto, se volverá a poner `_isJumping` a `false` y `_isGrounded` a `true`.

```c#
private void OnCollisionEnter2D(Collision2D other)
{
    Debug.Log($"<{gameObject.name}> has collided with <{other.gameObject.name}>");

    if (other.gameObject.CompareTag("Ground"))
    {
        _isJumping = false;
        _isGrounded = true;
        _rigidbody2D.velocity = Vector2.zero; // Cancel any remaining speed
    }
}
```

![Ejercicio3b](https://github.com/user-attachments/assets/e4765257-9bc6-4219-bc93-803c7c1e3bc8)

## 4. Implementar las siguientes mecánicas relacionadas con plataformas:

### _a. Salto a una plataforma_

Lo primero que haremos será hacer que el sprite del jugador sea hijo de `Tilemap_Ground` y crear otro tilemap más al que se le incluirá la etiqueta _"Ground"_. Este nuevo tilemap consistirá en plataformas flotantes que se moverán de izquierda a derecha. Su lógica se puede encontrar en `Assets/Scripts/TilemapExercises/FloatingGround.cs`.

Como la plataforma está en constante movimiento, si el jugador salta y se sitúa encima de esta, se acabará cayendo. Por ende, cada vez que el jugador colisione con una plataforma flotante o con el suelo su padre será modificado para convertir su sistema de referencia.

Para lograr esto, desde el script que contiene la lógica para el movimiento se añadirá la línea `transform.SetParent(Transform parent)` en el método `OnCollisionEnter2D()` y `OnCollisionExit2D()`.
```c#
private void OnCollisionEnter2D(Collision2D other)
{
    Debug.Log($"<{gameObject.name}> has collided with <{other.gameObject.name}>");

    if (other.gameObject.CompareTag("Ground"))
    {
        _isJumping = false;
        _isGrounded = true;
        _rigidbody2D.velocity = Vector2.zero; // Cancel any remaining speed
        transform.SetParent(other.gameObject.transform);
    }
}
```

```c#
private void OnCollisionExit2D(Collision2D _)
{
    transform.SetParent(null);
}
```

![Ejercicio4a](https://github.com/user-attachments/assets/e6f25b65-d998-4643-96ea-d7c24513d8ff)

### _b. Manejar colisiones con elementos de una capa determinada._

Creamos la layer _"Ground"_ y sustituimos la línea `if (other.gameObject.CompareTag("Ground"))` en el método `OnCollisionEnter2D()` por `if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))`.
De esta forma, se ignorará cualquier colisión que no pertenezca a la capa _"Ground"_.

### _c. Plataformas invisibles que se vuelven visibles._

Se añade otra layer llamada _"InvisiblePlatform"_ y se le asigna a un nuevo tilemap.

![image](https://github.com/user-attachments/assets/4b6f0798-53c1-4138-955e-990f490a542a)

Para hacer que los tiles sean invisibles, se desactiva el componente `TilemapRenderer` de `Tilemap_InvisiblePlatforms`.

![image](https://github.com/user-attachments/assets/48b22f11-32ae-446f-aa66-6359b69e978b)

La acción que se realizará cuando se colisione con estas plataformas invisibles será aplicar una fuerza que eleve al jugador en el eje positivo de la Y y volver estas plataformas visibles.

```c#
private void OnCollisionEnter2D(Collision2D other)
{
    Debug.Log($"<{gameObject.name}> has collided with <{other.gameObject.name}>");

    if (other.gameObject.layer == LayerMask.NameToLayer("Ground") || other.gameObject.layer == LayerMask.NameToLayer("InvisiblePlatform"))
    {
        _isJumping = false;
        _isGrounded = true;
        _rigidbody2D.velocity = Vector2.zero; // Cancel any remaining speed
        transform.SetParent(other.gameObject.transform);
    }

    if (other.gameObject.layer == LayerMask.NameToLayer("InvisiblePlatform"))
    {
        other.gameObject.GetComponent<TilemapRenderer>().enabled = true;
        _rigidbody2D.AddForce(Vector3.up * 25, ForceMode2D.Impulse);
    }
}
```

![Ejercicio4c](https://github.com/user-attachments/assets/7ccbf042-9a95-44c4-ac74-94b06b41aab6)

### _d. Mecánica de recolección._

Añadimos los objetos que serán coleccionados a la escena y le asignamos la capa _"Item"_. Cada objeto ha de tener un componente de tipo `Collider2D` y un `Rigidbody2D` cuyo `BodyType` esté establecido como `Kinematic`.

![image](https://github.com/user-attachments/assets/3f98bfe6-333d-4624-a0b6-00c7d68993a2)

Cada objeto recolectado incrementará nuestra puntuación, por tanto, creamos una UI para mostrarla:

![image](https://github.com/user-attachments/assets/827048e7-a342-49bf-a178-888bb86cc0ab)

Ahora, añadimos las siguientes variables a nuestro script:
* `[SerializeField] float _jumpForceIncreaser`: el incremento que se añadirá a la fuerza del salto por cada objeto recolectado.
* `[SerializeField] TMP_Text _scoreTxt`: la referencia al texto que muestra la puntuación.
* `int _collectiedItems`: el número de objetos colecionados por el jugador.

Ahora, en `OnCollisionEnter2D()`, añadimos las siguientes líneas de código:

```c#
if (other.gameObject.layer == LayerMask.NameToLayer("Item"))
{
    _collectedItems++;
    _scoreTxt.text = $"Score: {_collectedItems}";
    _jumpForce += _jumpForceIncreaser;
    Destroy(other.gameObject);
}
```

![Ejercicio4d](https://github.com/user-attachments/assets/5613902a-aaf7-4312-bd14-992e522af1e3)

El script empleado para esta actividad se puede encontrar en `Assets/Scripts/TilemapExercises/PlayerTilemapMovement.cs`
