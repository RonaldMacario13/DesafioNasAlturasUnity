using UnityEngine;

public class Diretor : MonoBehaviour {

    [SerializeField]
    private GameObject imagemGameOver;
    private Aviao aviao;
    private Pontuacao pontuacao;

    private void Start() {
        aviao = FindObjectOfType<Aviao>();
        pontuacao = FindObjectOfType<Pontuacao>();
    }

    public void FinalizarJogo() {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo() {
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        aviao.Reiniciar();
        DestruirObstaculos();
        pontuacao.ReiniciarPontuacao();
    }

    private void DestruirObstaculos() {
        Obstaculo[] obstaculos = FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo obstaculo in obstaculos) {
            obstaculo.Destruir();
        }
    }

}
