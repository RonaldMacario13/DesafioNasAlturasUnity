using UnityEngine;

public class Obstaculo : MonoBehaviour {

    [SerializeField]
    private float velocidade;

    void Update() {
        // Aqui realizamos a movimentação do obstáculo.
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
