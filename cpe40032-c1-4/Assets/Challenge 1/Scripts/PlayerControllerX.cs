using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    private float rollSpeed = 100.0f;
    private float pitchSpeed = 100.0f;
    private float rudderSpeed = 25.0f;
    public float verticalInput;
    public float horizontalInput;
    public float rollInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Plane Pitch");

        // move the plane forward at a constant rate
        // The plane is going backward solution: Vector3.back to Vector3.forward
        // The plane is going too fast solution: add "* Time.deltaTime"
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        // The plane is tilting automatically solution: add "* verticalInput"
        transform.Rotate(Vector3.right * pitchSpeed * Time.deltaTime * verticalInput);

        // Modifications:
        horizontalInput = Input.GetAxis("Plane Rudder");
        rollInput = Input.GetAxis("Plane Roll");

        // rotate the plane left/right on q/e keys
        transform.Rotate(Vector3.up * rudderSpeed * Time.deltaTime * horizontalInput);

        // tilt the plane left/right on a/d keys
        transform.Rotate(Vector3.back * rollSpeed * Time.deltaTime * rollInput);




    }
}