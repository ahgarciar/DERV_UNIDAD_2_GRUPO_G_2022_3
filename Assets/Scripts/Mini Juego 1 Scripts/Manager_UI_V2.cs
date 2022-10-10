using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_UI_V2 : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI txt_usuario;

    // Start is called before the first frame update
    void Start()
    {
        string nom_usuario = PlayerPrefs.GetString("usuario","");

        Scene scene = SceneManager.GetActiveScene();

        if (scene.buildIndex == 4) //Indice de la Escena Final
        {
            txt_usuario.text = nom_usuario;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            Scene scene;
            scene = SceneManager.GetActiveScene();
            if (scene.buildIndex == 5)
            {                
                cargarEscena(4); //fin de juego
            }    
        }
    }

    public void cargarEscena(int index) {

        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 3) //Indice de la Escena de Inicio
        {
            string nom_usuario = txt_usuario.text;
            PlayerPrefs.SetString("usuario", nom_usuario);
        }

        SceneManager.LoadScene(index); 
        //index 3 = inicio
        // 4 = fin
        // 5  = juego
    }
}
