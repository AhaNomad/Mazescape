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
        Keys.text = "Fundet nøgle: Ingen";
        print("Start: ingen nøgler");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddRedkey()
    {
        print("Rød nøgle fundet");
        KeyRedfound = true;
        Keys.text = "Fundet nøgle: Rød";
    }
}
