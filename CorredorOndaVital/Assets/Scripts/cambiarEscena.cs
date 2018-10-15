using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscena : MonoBehaviour {
    public void IrJuego()
    {
        SceneManager.LoadScene(0);
    }
    public void IrMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void IrGameOver()
    {
        SceneManager.LoadScene(1);
    }   
}

