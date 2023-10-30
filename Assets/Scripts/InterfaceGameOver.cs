using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour {

    [SerializeField]
    private GameObject imagemGameOver;
    [SerializeField]
    private Text ValorRecorde;

    public void MostrarInterface() {
        AtualizarInterfaceGrafica();
        imagemGameOver.SetActive(true);
    }

    public void EsconderInterface() {
        imagemGameOver.SetActive(false);
    }

    private void AtualizarInterfaceGrafica() {
        int recorde = PlayerPrefs.GetInt("recorde");
        ValorRecorde.text = recorde.ToString();
    }
}
