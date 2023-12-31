using UnityEngine;


// Esta classe está responsável por controlar todo o compotamento do jogo.
public class Diretor : MonoBehaviour {

    private Aviao aviao;
    private Pontuacao pontuacao;
    private InterfaceGameOver interfaceGameOver;

    private void Start() {
        aviao = FindObjectOfType<Aviao>();
        pontuacao = FindObjectOfType<Pontuacao>();
        interfaceGameOver = FindObjectOfType<InterfaceGameOver>();
    }

    // Método responsável por parar o jogo e mostrar "Game Over" ao perder o jogo.
    public void FinalizarJogo() {
        Time.timeScale = 0;
        pontuacao.SalvarRecorde();
        interfaceGameOver.MostrarInterface();
    }

    // Método resposável por organizar todo o cenário e reiniciá-lo.
    public void ReiniciarJogo() {
        interfaceGameOver.EsconderInterface();
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
