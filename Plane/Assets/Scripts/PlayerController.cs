using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    private Rigidbody2D meuRB;

    //velocidade
    [SerializeField] private float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando meuRG sozinho
        meuRB = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        //sunindo ao apertar espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Velocidade ir para cima
            meuRB.velocity = Vector2.up * velocidade;
        }

        //limitando velocidade de queda
        if (meuRB.velocity.y < -velocidade)
        {
            meuRB.velocity = Vector2.down * velocidade;
        }

    }

    //Colisão do Player
    void OnTriggerEnter2D(Collider2D collision)
    {
        //SceneManager para dar load na Cena
        SceneManager.LoadScene(0);
    }

}
