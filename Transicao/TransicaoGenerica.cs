using UnityEngine;
using UnityEngine.SceneManagement;

public class Transicao : MonoBehaviour 
{
    protected bool podeInteragir = false;
    public string nomeCena;

    private bool cenaJaCarregando = false; 
    public GameObject telaCarregamento; // opcional (futuramente)

    void Update()
    {
        if (podeInteragir && Input.GetButtonDown("Submit")) // btt enter
        {
            TrocarCena(nomeCena);
        }
    }

    protected void OnTriggerEnter2D(Collider2D other) // funcao que captura a colisao do personagem com o objeto
    {
        if (other.CompareTag("Player"))
        {
            podeInteragir = true;
        }
    }

    protected void OnTriggerExit2D(Collider2D other) // funcao que captura a saida do range do objeto
    {
        if (other.CompareTag("Player"))
        {
            podeInteragir = false;
        }
    }

    protected void TrocarCena(string nomeCena) // funcao que faz a troca de cenas
    {
        if (cenaJaCarregando) return;
        cenaJaCarregando = true;

        if (telaCarregamento != null)
        {
            telaCarregamento.SetActive(true);
        }
        
        SceneManager.LoadScene(nomeCena); // so isso que e importante no momento
    }
}