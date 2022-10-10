using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Acceleration : MonoBehaviour
{
    [SerializeField]
    public Rigidbody rb;

    [SerializeField]
    float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.right * velocidad, ForceMode.Acceleration);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
