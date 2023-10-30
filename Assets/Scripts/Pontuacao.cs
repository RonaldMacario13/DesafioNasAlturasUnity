using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {

    [SerializeField]
    private Text textoPontuacao;
    private int pontos;
    private AudioSource audioPontuacao;

    private void Awake() {
        // Está sendo buscado o efeito sonoro realizado após passarmos por um obstáculo.
        audioPontuacao = GetComponent<AudioSource>();
    }

    // Método responsável por adicionar pontos no contador da tela.
    public void AdicionarPontos() {
        pontos++;
        textoPontuacao.text = pontos.ToString();
        audioPontuacao.Play();
    }

    // Método responsável por reiniciar a contagem de pontos da tela, após o fim de jogo.
    public void ReiniciarPontuacao() {
        pontos = 0;
        textoPontuacao.text = pontos.ToString();
    }

    public void SalvarRecorde() {
        int recordeAtual = PlayerPrefs.GetInt("recorde");
        if (pontos > recordeAtual) {
            PlayerPrefs.SetInt("recorde", pontos);
        }
    }

}
