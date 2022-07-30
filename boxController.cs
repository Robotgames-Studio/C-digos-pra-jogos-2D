
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController : MonoBehaviour {


	[Header("Componentes físicos do Player")]
	Rigidbody2D ball; //RB2 do Corpo com Script.
	public MeshRenderer player; //Material Inicial do Player.

	[Header("Funçoes pra verificar o chão")]
	public bool TaNoChao; //Condição de verdadeiro ou falso.
	public Transform Detectachao; //Esse é o gameobject vazio ou seja o Overlapse.Circle cujo raio será usado pra detectar objectos com layer chão.
	public LayerMask WhatIsGround; //Ativar a procura de LayerMask no Player,qual objecto está com LayerMask que estamos procurando?Nesse caso o chão.
	public float raio; //Raio de colisão entre Overlapse.Circle e LayerMask.

	[Header("Componentes de Material pra objectos na cena")]
	public MeshRenderer anotherMat; //Material que será atribuido ao Player mundando a sua cor.
	public MeshRenderer playerMat; //Material que fará retornar a cor do Player.
	public MeshRenderer portalMat; //Material do Portal que será atribuido ao Player quando colidir com o mesmo.

	// Use this for initialization
	void Start () {
		
		ball = GetComponent<Rigidbody2D>(); //Pegar o componente RB2D
	}

	// Update is called once per frame
	void Update () {
		
		TaNoChao = Physics2D.OverlapCircle (Detectachao.position, raio, WhatIsGround);

		//Quando Alguns desses buttons for apertado, então o Rigidibody2D do corpo vai receber uma força com alguma direção do vector
		//E a direção será consoante ao Button que estás a pressionar, e simultaneamente com o número velocidade
		//Esse núemro será Multiplicando com a força do corpo em direção do Button pressionado.
		if (Input.GetKey (KeyCode.D))
		{
			ball.AddForce (Vector2.right * 5);
		}

		else if (Input.GetKey (KeyCode.A)) 
		{
			ball.AddForce (Vector2.left * 5);
		}

		if (Input.GetKey (KeyCode.W) && TaNoChao == true) //Se pressionar W e a condição de colisão com chão for true então pule,se não então o raio tem que colidir de novo com LayerMask do chão pra saltar de novo.
		{
			ball.AddForce (Vector2.up * 15);
		}

		else if (Input.GetKey (KeyCode.S)) 
		{
			ball.AddForce (Vector2.down * 5);	
		}

	}
	
	//Se o Player Collider com uma ball ele recebe outro material mudando de cor nesse caso o material da com cor verde.
	void OnCollisionStay2D(Collision2D materials)
	{
		switch (materials.transform.tag) {
		case "Obj":
			player.material = anotherMat.material;
			break;
		case "Obj2":
			player.material = anotherMat.material;
			break;
		case "Obj3":
			player.material = anotherMat.material;
			break;
		case "use":
			player.material = anotherMat.material;
			break;
		}
	}

	//Se o Player sair da colisão com uma ball recebe outro material mudando de cor e regressando pra cor inical o cinzento nesse caso.
	void OnCollisionExit2D(Collision2D materials)
	{
		switch (materials.transform.tag) {
		case "Obj":
			player.material = playerMat.material;
			break;
		case "Obj2":
			player.material = playerMat.material;
			break;
		case "Obj3":
			player.material = playerMat.material;
			break;
		case "use":
			player.material = playerMat.material;
			break;
			//Se o Player colidir com "portalMat" então recebe outro material nesse caso com a cor do Portal,vermelho;
		case "portalMat":
			player.material = portalMat.material;
			break;
		}
	}
}
