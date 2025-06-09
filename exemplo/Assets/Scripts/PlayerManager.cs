using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   public Animator animator;
   private MovimentoPlayer movimentoPlayer;
   public float velocidadeDasAnimacoes = 1;
   
    void Start()
    {
        movimentoPlayer = GetComponent<MovimentoPlayer>();
        
    }

   
    void Update()
    {
        animator.SetBool("Correndo", movimentoPlayer.andando);
        animator.speed = velocidadeDasAnimacoes;
    }
}
