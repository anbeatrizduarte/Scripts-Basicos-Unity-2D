using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLeveDojogo;
    [SerializeField] private GameObject painelmenuinicial;
    [SerializeField]private GameObject painelopcoes;
    public void jogar(){
        SceneManager.LoadScene(nomeDoLeveDojogo);
    }

    public void abriropcoes(){
        //painelmenuinicial.SetActive(false);
        painelopcoes.SetActive(true);
    }

    public void fecharopcoes(){
        painelopcoes.SetActive(false);
        painelmenuinicial.SetActive(true);
    }

    public void fecharjogo(){
        Debug.Log("sair do jogo");
        Application.Quit();
    }
}
