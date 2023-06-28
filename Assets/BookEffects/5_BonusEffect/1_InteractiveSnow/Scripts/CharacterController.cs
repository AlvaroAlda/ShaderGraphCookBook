using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    //The SerializeField Attribute will let you tweak
    //these variables from the Unity Editor
    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 300.0f;

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        var translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        var rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);

        // Avoid getting out of the Camera view
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -4, 3),
            transform.position.y,
            Mathf.Clamp(transform.position.z, -9, 0.5f));
    }
}





















