using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {
    
    [SerializeField]
    private float tempoParaGerar;
    private float cronometro;
    [SerializeField]
    private GameObject prefab;
    
    private void Awake() {
        cronometro = tempoParaGerar;
    }

    private void Update() {
        // Aqui fazemos ser gerado um objeto a cada X segundos, de acordo com o que vier do "tempoParaGerar".
        cronometro -= Time.deltaTime;

        if (cronometro <= 0) {
            Instantiate(prefab, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}
