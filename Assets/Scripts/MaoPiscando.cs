using UnityEngine;

public class PiscandoMao : MonoBehaviour {

    private SpriteRenderer imagem;

    private void Awake() {
        imagem = GetComponent<SpriteRenderer>();
    }

    private void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Desaparecer();
        }        
    }

    private void Desaparecer() {
        imagem.enabled = false;
    }

}