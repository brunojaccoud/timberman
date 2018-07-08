using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// variaveis da tree
	public GameObject[] troncos;
	public List<GameObject> listaTroncos;


	private float alturaTronco = 2.43f;
	private float posicaoInicialY = -2.38f;
	private int maxTroncos = 6;
	private bool troncoSemGalho = false;

	// Use this for initialization
	void Start () {

		InicializaTroncos();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1")) {
			CortaTronco();
			ReposicionaTronco();
		}
		
	}

	void CriaTroncos(int posicao) {
		GameObject tronco = Instantiate(troncoSemGalho ? troncos [Random.Range (0,3)] : troncos[0]);
		tronco.transform.localPosition = new Vector3 (-0.05f, posicaoInicialY + posicao * alturaTronco, 0f);
		listaTroncos.Add(tronco);
		troncoSemGalho = !troncoSemGalho;
	}

	void InicializaTroncos() {
		for (int posicao = 0; posicao <= maxTroncos; posicao++) {
			CriaTroncos(posicao);
		}
	}

	void CortaTronco() {
		Destroy (listaTroncos[0]);
		listaTroncos.RemoveAt(0);
	}

	void ReposicionaTronco() {
		for (int posicao = 0; posicao < listaTroncos.Count; posicao++) {
			listaTroncos[posicao].transform.localPosition = new Vector3 (-0.05f, (posicaoInicialY + posicao * alturaTronco), 0f);
		}
		CriaTroncos(maxTroncos);
	}
}