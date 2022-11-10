using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    //The plane’s propeller does not spin solution:

    private float rotationSpeed = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spins the propeller at constant rate
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
