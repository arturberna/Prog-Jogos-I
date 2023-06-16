using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 2.5f;
    public float aceleracao;
    public string nome = "Avião Azul";

    // Função chamada quando o jogo inicia
    void Start()
    {
        print("Iniciando o jogo!");
        GameObject label = transform.GetChild(0).gameObject;
        label.GetComponent<TextMesh>().text = nome;
        
    }

    /** Função padrão da Unity, é sempre chamada duranta a 
        atualização do quadro do jogo
    */
    void Update()
    {
        if(aceleracao==0.0f)
            moveAviao();
        else
            aceleraAviao();
            
    }
    /**
    Função que faz o avião se mover em linha reta, seguindo a equação 
    do movimento retilíneo uniforme
    */
    void moveAviao(){
        // variáveis
        float tempo = Time.deltaTime;
        float posicaoInicial = transform.position.x;
        float posicao = posicaoInicial+velocidade*tempo;
        // comando para acessar e alterar a posição do avião
        transform.position = (new Vector3(posicao,transform.position.y,transform.position.z));

    }
    /**
        Função que faz o avião se mover em linha reta, seguindo a equação 
        do movimento retilíneo uniformimente variado
    */
    void aceleraAviao(){
        // variáveis
        float tempo = Time.deltaTime;
        float posicaoInicial = transform.position.x;
        float posicao = posicaoInicial+velocidade*tempo+0.5f*aceleracao*tempo*tempo;
        // comando para acessar e alterar a posição do avião
        transform.position = (new Vector3(posicao,transform.position.y,transform.position.z));
    }
}
