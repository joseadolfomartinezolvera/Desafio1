using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private float propellorSpeed = 1000;
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }

}
//hecho por Jose Adolfo Martinez Olvera