using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void LoadScene(string cena)
    {
        SceneManager.LoadScene(cena);

        Debug.Log("apertei o botão");


    }

    public void Quit()
    {
        Application.Quit();

    }
}
