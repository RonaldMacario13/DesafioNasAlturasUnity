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

    void Update() {
        cronometro -= Time.deltaTime;

        if (cronometro <= 0) {
            Instantiate(prefab, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}
