using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Timer
    [SerializeField] private float timer = 1f;

    //Meu obstáculo
    [SerializeField] private GameObject obstaculo;

    //POsição do obstáculo
    [SerializeField] private Vector3 posicao;

    //Posição mínima e máxima
    [SerializeField] private float posMin = -2.2f;
    [SerializeField] private float posMax = 1.3f;

    //Tempo mínimo e máximo
    [SerializeField] private float tempoMin = 1f;
    [SerializeField] private float tempoMax = 3f;

    //Contador de Pontos
    private float pontos = 0f;

    //Verificando os Pontos do Canvas
    [SerializeField] private Text pontosTexto;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Pontos();

        //Definindo a criação de obstáculos de proceduralmente
        CriaObstaculos();
    }

    //Método para os pontos
    private void Pontos()
    {//Ganhando pontos
        pontos += Time.deltaTime;

        //Passando meus pontos para o Canvas
        pontosTexto.text = Mathf.Round(pontos).ToString();

    }



    private void CriaObstaculos()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {

            //Timer com valor aleatório
            timer = Random.Range(tempoMin, tempoMax);

            posicao.y = Random.Range(posMin, posMax);

            //Cria obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
}
