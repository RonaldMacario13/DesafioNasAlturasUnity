using UnityEngine;

public class Chao : MonoBehaviour {

    [SerializeField]
    private float velocidade;
    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;
    [SerializeField]
    private float teste;

    private void Awake() {
        posicaoInicial = transform.position;
        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }

    void Update() {
        float deslocamento = Mathf.Repeat(velocidade * Time.time, tamanhoRealDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
