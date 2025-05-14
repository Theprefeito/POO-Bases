using UnityEngine;

public class MovimentoPlayer : MonoBehaviour

{
    private Rigidbody _rigidbody;
    private float velocidade;
    
    void Start()
    {
        velocidade = gameObject.GetComponent<Rigidbody>().linearVelocity.magnitude;
    }


    void Update()
    {
        
    }
}
