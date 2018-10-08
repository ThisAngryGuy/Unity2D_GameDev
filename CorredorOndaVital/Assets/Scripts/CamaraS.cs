using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraS : MonoBehaviour
{
    public GameObject Jugador;
	void Update ()
    {
        transform.position = new Vector3 (Jugador.transform.position.x, 0, Jugador.transform.position.z - 10);
	}
}
