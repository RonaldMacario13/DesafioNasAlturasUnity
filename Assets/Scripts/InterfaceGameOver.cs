using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour {
    [SerializeField]
    private Text ValorRecorde;


    private void AtualizarInterfaceGrafica() {
        int recorde = PlayerPrefs.GetInt("recorde");
        ValorRecorde.text = recorde.ToString();
    }
}
