using UnityEngine;

public class Aviao : MonoBehaviour {

    private Rigidbody2D fisica;
    [SerializeField] // Isso faz com que seja mostrado no painel "Inspector" do Unity.
    private float forcaDePulo;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    private bool deveImpulsionar;

    // Awake é chamado quando uma instância de script habilitada está sendo carregada.
    private void Awake() {
        // Aqui estamos buscando o Rigidbidy2D que está no componete.
        fisica = GetComponent<Rigidbody2D> ();
        posicaoInicial = transform.position;
    }

    private void Start() {
        diretor = FindObjectOfType<Diretor>();
    }

    // Essa método é chamada a cada frame.
    private void Update() {
        // Esse IF é responsável por chamar o método Impulsionar, que faz o avião "Voar".
        // Verificação de Input deve estar dentro do Update, é uma boa prática.
        if(Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space)) {
            deveImpulsionar = true;
        }
    }

    private void FixedUpdate() {
        if (deveImpulsionar) {
            Impulsionar();
        }
    }

    // Método que faz o avião ser impulsinado para cima.
    private void Impulsionar() {
        fisica.velocity = Vector2.zero;
        fisica.AddForce(Vector2.up * forcaDePulo, ForceMode2D.Impulse);
        deveImpulsionar = false;
    }

    // Método responsável pelo fim do jogo ao colidir nos obstáculos.
    private void OnCollisionEnter2D() {
        fisica.simulated = false;
        diretor.FinalizarJogo();
    }

    // Mátodo responsável por reiniciar posição do avião, após o fim do jogo.
    public void ReiniciarAviao() {
        transform.position = posicaoInicial;
        fisica.simulated = true;
    }

}
