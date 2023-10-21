using Unity.VisualScripting;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float variacaoDaPosicaoY;

    private void Awake() {
        // Aqui fazemos os objetos nascerem em alturas diferentes.
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Update() {
        // Aqui realizamos a movimentação do obstáculo.
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D outro) {
        Destroir();
    }

    private void Destroir() {
        Destroy(gameObject);
    }

}
