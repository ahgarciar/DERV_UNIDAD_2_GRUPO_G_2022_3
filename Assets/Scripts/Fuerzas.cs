using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerzas : MonoBehaviour
{
    Rigidbody rb;
    
    [SerializeField]
    float velocidad;

    [SerializeField]
    Transform posicionInicial;

    private void FixedUpdate()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10) { 
            transform.position = posicionInicial.position;
        }

            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(transform.forward * velocidad, ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(transform.right * -1 * velocidad, ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(transform.forward * -1 * velocidad, ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(transform.right * velocidad, ForceMode.Acceleration);
            }
        }
    }

