using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Corrutina_Tiempo : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI t_tiempo;

    int tiempoInicio;

    private void Awake()
    {
        GameObject obj = GameObject.Find("txt_tiempo");
        t_tiempo = obj.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        tiempoInicio = 10;
        StopAllCoroutines(); //recomendacion
        StartCoroutine("controlTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator controlTiempo() {
        while(tiempoInicio>=0) {
            t_tiempo.text = tiempoInicio.ToString();
            tiempoInicio--;
           yield return new WaitForSeconds(0.5f);
        }
    }

}
