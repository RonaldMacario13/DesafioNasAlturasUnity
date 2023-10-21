using UnityEngine;

public class Obstaculo : MonoBehaviour {

    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float variacaoDaPosicaoY;
    private Vector3 posicaoDoAviao;
    private bool pontuado;
    private Pontuacao pontuacao;


    private void Awake() {
        // Aqui fazemos os objetos nascerem em alturas diferentes.
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Start() {
        posicaoDoAviao = FindObjectOfType<Aviao>().transform.position;
        pontuacao = FindObjectOfType<Pontuacao>();
    }

    private void Update() {
        // Aqui realizamos a movimentação do obstáculo.
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    // Aqui fazemos os obstáculos se destruírem, após o uso.
    private void OnTriggerEnter2D() {
        Destruir();
    }

    public void Destruir() {
        Destroy(gameObject);
    }

}
