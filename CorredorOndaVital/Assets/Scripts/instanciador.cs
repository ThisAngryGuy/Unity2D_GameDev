using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour {

    public GameObject[] objetos;
    public float min = 1f, max = 2f;
	// Use this for initialization
	void Start ()
    {
        Instanciar();	
	}

    // Update is called once per frame
    void Instanciar()
    {
        Instantiate(objetos[Random.Range(0, objetos.Length)], transform.position, Quaternion.identity);
        Invoke("Instanciar", Random.Range(min, max));
	}
}
