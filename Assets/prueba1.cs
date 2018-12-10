using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba1 : MonoBehaviour {
    public KeyCode TeclaAsignada = KeyCode.A;
    float velocidad = 0.4f;
    public GameObject coche1;
    public GameObject enemigo;
    public GameObject azul;
    public GameObject rosa;

        
    // Use this for initialization
    void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < 8 & enemigo.transform.position.x < 8)
        {
            if (Input.GetKeyDown(TeclaAsignada))
            {
                this.transform.Translate(new Vector3(velocidad, 0, 0));


            }
            if (azul.transform.position.x > 8 & rosa.transform.position.x < 8)
            {
                Debug.Log("player 1 win");
            }
            if (azul.transform.position.x < 8 & rosa.transform.position.x > 8)
            {
                Debug.Log("player 2 win");
            }
        }
        }
    }
