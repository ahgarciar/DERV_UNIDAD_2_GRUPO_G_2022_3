using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawneador : MonoBehaviour
{
    [SerializeField]
    GameObject prefab_a_Clonar;

    [SerializeField]
    long conPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        conPrefabs = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){ 
            GameObject nuevo = Instantiate(prefab_a_Clonar,gameObject.transform
                );
            nuevo.name = "prefab_No_" + conPrefabs.ToString(); 
        }
    }
}
