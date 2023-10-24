using UnityEngine;

public class Aviao : MonoBehaviour {

    private Rigidbody2D fisica;
    [SerializeField] // Isso faz com que seja mostrado no painel "Inspector" do Unity.
    private float forcaDePulo;
    private Diretor diretor;
    private Vector3 posicaoInicial;

    // Awake é chamado quando uma instância de script habilitada está sendo carregada.
    private void Awake() {
        // Aqui estamos buscando o Rigidbidy2D que está no componete.
        fisica = GetComponent<Rigidbody2D> ();
        posicaoInicial = transform.position;
    }

    private void Start() {
        diretor = FindObjectOfType<Diretor>();
    }

    // Essa função é chamada a cada frame.
    private void Update() {
        // Esse IF é responsável por chamar a função Impulsionar, que faz o avião "Voar".
        if(Input.GetButtonDown("Fire1")) {
            Impulsionar();
        }
    }

    // Função que faz o avião ser impulsinado para cima.
    private void Impulsionar() {
        fisica.velocity = Vector2.zero;
        fisica.AddForce(Vector2.up * forcaDePulo, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D() {
        fisica.simulated = false;
        diretor.FinalizarJogo();
    }

    public void ReiniciarAviao() {
        transform.position = posicaoInicial;
        fisica.simulated = true;
    }

}
