using UnityEngine;

// Classe responsável por fazer com que os objetos, que precisam, se repitam infinitamente em carrossel.
public class Carrossel : MonoBehaviour {

    [SerializeField]
    private float velocidade;
    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;

    private void Awake() {
        posicaoInicial = transform.position;
        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }

    private void Update() {
        // Aqui estamos fazendo o comportamendo te deslocamento infinito.
        float deslocamento = Mathf.Repeat(velocidade * Time.time, tamanhoRealDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
