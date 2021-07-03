using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{

    //velocidade
    [SerializeField] private float velocidade = 5f;

    [SerializeField] private GameObject eu;

    //tempo de vida
    [SerializeField] private float tempoVida = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(eu, tempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        //Indo para a esquerda
        transform.position += Vector3.left * Time.deltaTime * velocidade;
    }
}
