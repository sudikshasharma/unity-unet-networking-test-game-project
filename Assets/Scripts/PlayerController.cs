//adapted from example script available at
//https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        Quaternion turn = Quaternion.Euler(0, rotation, 0);
        rb.MovePosition(rb.position + translation * this.transform.forward);
        rb.MoveRotation(rb.rotation * turn);
    }
}
