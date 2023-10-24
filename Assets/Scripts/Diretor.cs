using UnityEngine;


// Esta classe está responsável por controlar todo o compotamento do jogo.
public class Diretor : MonoBehaviour {

    [SerializeField]
    private GameObject imagemGameOver;
    private Aviao aviao;
    private Pontuacao pontuacao;

    private void Start() {
        aviao = FindObjectOfType<Aviao>();
        pontuacao = FindObjectOfType<Pontuacao>();
    }

    // Método responsável por parar o jogo e mostrar "Game Over" ao perder o jogo.
    public void FinalizarJogo() {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
    }

    // Método resposável por organizar todo o cenário e reiniciá-lo.
    public void ReiniciarJogo() {
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        aviao.ReiniciarAviao();
        DestruirObstaculos();
        pontuacao.ReiniciarPontuacao();
    }

    // Método responsável por destruir todos os obstáculos em cena, no momento.
    private void DestruirObstaculos() {
        Obstaculo[] obstaculos = FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo obstaculo in obstaculos) {
            obstaculo.Destruir();
        }
    }

}
