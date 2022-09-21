using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovBasico : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txt_vida;
    [SerializeField]
    TextMeshProUGUI txt_ataque;


    // Start is called before the first frame update
    void Start()
    {
        int v = Singleton_Usuario.instancia.vida;
        int a = Singleton_Usuario.instancia.ataque;

        txt_vida.text = v.ToString();
        txt_ataque.text = a.ToString();
    }

    float valX;
    float valZ;
    public float velocidad = 20;

    // Update is called once per frame
    void Update()
    {
        valX = Input.GetAxis("Horizontal");
        valZ = Input.GetAxis("Vertical");
        //Debug.Log("Val X: " + valX + " -- Val Z:" + valZ);

        //Vector3.forward //

        valX = valX * velocidad * Time.deltaTime;
        valZ = valZ * velocidad * Time.deltaTime;

        Vector3 v = new Vector3(valX, 0, valZ);

        transform.Translate(v);

        
    }
}
