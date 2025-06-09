using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    private Rigidbody _rigidbody; 
    public bool andando;
    private float velocidade;
     void Start()
     {
         velocidade = gameObject.GetComponent<Personagem>().Velocidade();
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 posicao = transform.position;
        andando = false;
        
        //esquerda X-
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            andando = true;
        }

        //direira  X+
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            andando = true;
        }
        
        //cima  Z+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            andando = true;
        }
        
        //baixo Z-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            andando = true;
        }
        
        transform.position = posicao;
        
        

    }
}