using UnityEngine;

public class Diretor : MonoBehaviour {

    [SerializeField]
    private GameObject imagemGameOver;

    public void FinalizarJogo() {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo() {
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        aviao.Reiniciar();
        DestruirObstaculos();
    }
}
