using UnityEngine;

public class Obstaculo : MonoBehaviour {

    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float variacaoDaPosicaoY;

    private void Awake() {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    void Update() {
        // Aqui realizamos a movimentação do obstáculo.
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
