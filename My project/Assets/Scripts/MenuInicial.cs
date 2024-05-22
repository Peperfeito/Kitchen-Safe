using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    [SerializeField] GameObject opcao;
    [SerializeField] GameObject legendas;
    public void LoadScene(string cena)
    {
        SceneManager.LoadScene(cena);

        


    }

    public void Options()
    {
        opcao.SetActive(true);
    }

    public void BackOptions()
    {
        opcao.SetActive(false);
    }

    public void Legends()
    {
        legendas.SetActive(true);
    }

    public void BackLegends()
    {
        legendas.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();

    }
}
