using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    bool KeyRedfound = false;

    public Text Keys;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KeyRedfound = true)
        {
            Keys.text = "Fundet nøgle: Rød";
            print("Rød nøgle fundet");
        }
        else
        {
            Keys.text = "Fundet nøgle: Ingen";
            print("ingen nøgler");
        }
    }

    public void AddRedkey()
    {
        print("Rød nøgle fundet");
        KeyRedfound = true;
    }
}
