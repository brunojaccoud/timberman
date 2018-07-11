using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private SpriteRenderer sprite;
	private Animator anim;
	private string ladoAtual = "E"; //E == Esquerda D == Direita;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
