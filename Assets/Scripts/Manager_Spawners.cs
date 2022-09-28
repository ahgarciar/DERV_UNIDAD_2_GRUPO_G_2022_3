using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Spawners : MonoBehaviour
{
    [SerializeField]
    int rnd_ubi_manzana;

    [SerializeField]
    Transform[] spawners;

    int tot_spawners = 4;

    [SerializeField]
    GameObject obj_manzana; //objeto a clonar

    private void Awake()
    {        

        spawners = new Transform[tot_spawners]; //4 spawners

        GameObject objTemp;
        for (int i = 0; i < tot_spawners; i++)
        {
            objTemp = GameObject.Find("Spawner_" + (i+1).ToString());
            spawners[i] = objTemp.transform;
        }
    }

    void createManzana() {
        rnd_ubi_manzana = Random.Range(0, tot_spawners);

        Transform aux = spawners[rnd_ubi_manzana];

        GameObject objTemp = Instantiate(obj_manzana,
            aux.position,
            aux.rotation);
        objTemp.name = "manzana";
    }

    // Start is called before the first frame update
    void Start()
    {
        createManzana();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
