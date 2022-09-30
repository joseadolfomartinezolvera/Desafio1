using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed= 20;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // obtien la entrada vertical del jugador
        verticalInput = Input.GetAxis("Vertical");

        // mueve el avión hacia adelante a una velocidad constante
        transform.Translate(Vector3.forward * speed* Time.deltaTime);

        // inclina el avión hacia arriba/abajo según las teclas de flecha arriba/abajo
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
    }
}
//hecho por Jose Adolfo Martinez Olvera