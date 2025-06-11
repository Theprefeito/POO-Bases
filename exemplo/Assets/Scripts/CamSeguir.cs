using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSeguir : MonoBehaviour
{
    public Transform _Alvo;
    public float interpolacao = 12f;
    public float CamMoveSpeed = 5f;
    public float distancia = -5f;
    
    void Start()
    {
        
    }


    void Update()
    {
        transform.position = Vector3.Lerp(
            transform.position, new Vector3(_Alvo.position.x, _Alvo.position.y, _Alvo.position.z + distancia),CamMoveSpeed * Time.deltaTime);
    }
}
