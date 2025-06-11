using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    private Rigidbody _rigidbody; 
    public bool Andando;
    private float velocidade;
     void Start()
     {
         velocidade = gameObject.GetComponent<Personagem>().Velocidade();
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 posicao = transform.position;
        Andando = false;
        
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 45, 0);
            Andando =  true;
        }
        else
            
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 135, 0);
            Andando =  true;
        }
        else    
        
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -135, 0);
            Andando =  true;
        }
        else   
            
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -45, 0);
            Andando =  true;
        }
        else   
        
        
        
        
        //esquerda X-
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -90, 0);
            Andando = true;
        }

        //direita  X+
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            Andando = true;
        }
        
        //cima  Z+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Andando = true;
        }
        
        //baixo Z-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            Andando = true;
        }
        
        transform.position = posicao;
        
        

    }
}