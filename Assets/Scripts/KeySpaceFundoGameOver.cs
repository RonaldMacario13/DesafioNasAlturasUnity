using UnityEngine;
using UnityEngine.UI;

public class KeySpaceFundoGameOver : MonoBehaviour {

    Button button;

    void Start() {
        button = GetComponent<Button>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            button.onClick.Invoke();
        }        
    }
}
