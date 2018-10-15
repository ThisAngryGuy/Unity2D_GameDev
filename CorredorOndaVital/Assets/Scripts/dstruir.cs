using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dstruir : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collisionador)
    {
        if(collisionador.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            if(collisionador.gameObject.transform.parent)
            {
                Destroy(collisionador.gameObject.gameObject.transform.parent);
            }
            else
            {
                Destroy(collisionador.gameObject);
            }
        }
    }
}
