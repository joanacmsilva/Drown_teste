using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogo : MonoBehaviour
{

    [SerializeField]
    Transform[] coordenadas = new Transform[2];

    [SerializeField]
    GameObject colectavel;

    [SerializeField]
    Text textoPontos;

    public bool instanciar = true;

    private int[] preenchidos = new int[2];
    private int contaPreenchidos = 0;

    private int pontos = 0;

    // Start is called before the first frame update
    void Start()
    {
        ResetPreenchidos();
    }

    // Update is called once per frame
    void Update()
    {
        if (instanciar) InstanciaColectavel();
    }

    private void InstanciaColectavel()
    {
        instanciar = false;
        Instantiate(colectavel, coordenadas[Sorteio()].position, Quaternion.identity);
    }

    private int Sorteio()
    {
        int sorteado = 0;
        bool livre = false;
        while (livre == false)
        {
            sorteado = Random.Range(0, 2);
            if (preenchidos[sorteado] == 0)
            {
                preenchidos[sorteado] = 1;
                livre = true;
            }
        }
        contaPreenchidos++;
        if (contaPreenchidos >= 2) ResetPreenchidos();
        return sorteado;
    }

    private void ResetPreenchidos()
    {
        contaPreenchidos = 0;
        for (int i = 0; i < preenchidos.Length; i++)
        {
            preenchidos[i] = 0;
        }
    }

    public void Pontuacao()
    {
        pontos++;
        textoPontos.text = pontos.ToString();
    }
}
