using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private float alturaTronco;
	// variaveis da tree
	public GameObject[] troncos;
	public List<GameObject> listaTroncos;


	private float alturaTronco = 2.43f;
	private float posicaoInicialY = -4f;
	private int maxTroncos = 6;
	private bool troncoSemGalho = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CriaTroncos(int posicao) {
		GameObject tronco = Instantiate(troncoSemGalho ? troncos [Random.Range (0,3)] : troncos[0]);
		tronco.transform.localPosition = new Vector3 (0f, posicaoInicialY + posicao * alturaTronco, 0f);
		listaTroncos.Add(tronco);
		troncoSemGalho = !troncoSemGalho;
	}
}
